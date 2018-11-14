using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using EdlinSoftware.Safe.SafeLib.Properties;

namespace EdlinSoftware.Safe.SafeLib
{
    /// <summary>
    /// Class of user storage.
    /// </summary>
    public class UserStorage
    {
        /// <summary>
        /// Last (current) version of user storage.
        /// </summary>
        public const int LastVersion = 1;
        /// <summary>
        /// Version returned by not opened user storage.
        /// </summary>
        public const int IncorrectVersion = -1;

        /// <summary>
        /// Name of storage file.
        /// </summary>
        private static readonly string storageFileName = "storage.dat";

        /// <summary>
        /// Password for storage.
        /// </summary>
        private string m_Password;

        /// <summary>
        /// Version of user storage.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_Version = IncorrectVersion;

        /// <summary>
        /// Prompt for password.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_PasswordPrompt = string.Empty;

        /// <summary>
        /// Path to storage file.
        /// </summary>
        public string StorageFilePath { get; private set; }

        /// <summary>
        /// Is user storage opened.
        /// </summary>
        /// <returns>Is user storage opened.</returns>
        public bool IsOpened
        {
            [DebuggerStepThrough]
            get { return (Topics != null); }
        }

        /// <summary>
        /// Version of user storage.
        /// </summary>
        public int Version
        {
            [DebuggerStepThrough]
            get { return m_Version; }
        }

        /// <summary>
        /// Prompt for password.
        /// </summary>
        public string PasswordPrompt
        {
            [DebuggerStepThrough]
            get { return m_PasswordPrompt; }
            [DebuggerStepThrough]
            set { m_PasswordPrompt = (value == null) ? string.Empty : value; }
        }

        /// <summary>
        /// List of topics.
        /// </summary>
        public TopicsList Topics { get; private set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="storageFilePath">Path to storage file.</param>
        private UserStorage(string storageFilePath)
        {
            if (string.IsNullOrEmpty(storageFilePath))
                throw new ArgumentNullException("storageFilePath");

            StorageFilePath = storageFilePath;
        }

        /// <summary>
        /// Returns instance of user storage.
        /// </summary>
        /// <param name="userDirectory">Storage directory for current user.</param>
        /// <returns>Instance of user storage.</returns>
        internal static UserStorage GetInstance(string userDirectory)
        {
            if (string.IsNullOrEmpty(userDirectory))
                throw new ArgumentNullException("userDirectory");

            UserStorageStatus userStorageStatus = GlobalStorage.GetUserStorageStatus();

            if (userStorageStatus != UserStorageStatus.Ready)
                throw new UserStorageCreationException(userStorageStatus);

            string storageFilePath = Path.Combine(userDirectory, storageFileName);

            return new UserStorage(storageFilePath);
        }

        /// <summary>
        /// Extracts common information from storage.
        /// </summary>
        public void GetPublicInfo()
        {
            m_Version = IncorrectVersion;
            m_PasswordPrompt = string.Empty;

            try
            {
                using (FileStream fStrm = new FileStream(StorageFilePath, FileMode.Open, FileAccess.Read))
                {
                    m_Version = fStrm.ReadInt32();

                    m_PasswordPrompt = fStrm.ReadString();
                }
            }
            catch
            {
                Topics = null;
                m_Password = null;
            }
        }

        /// <summary>
        /// Opens user storage.
        /// </summary>
        /// <param name="password">Password of storage.</param>
        /// <returns>True if storage is successfully opened; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">Password is null or empty.</exception>
        public bool Open(string password)
        {
            if (string.IsNullOrEmpty(password))
                throw new ArgumentNullException("password");

            // Store password.
            m_Password = password;

            DecipherTopics();

            return IsOpened;
        }

        /// <summary>
        /// Saves ciphered information.
        /// </summary>
        /// <exception cref="InvalidOperationException">Password is null or empty.</exception>
        public void Save()
        {
            if (string.IsNullOrEmpty(m_Password))
                throw new InvalidOperationException("Password can't be null or empty.");

            using (FileStream fStrm = new FileStream(StorageFilePath, FileMode.Create, FileAccess.Write))
            {
                fStrm.WriteInt32(m_Version);

                fStrm.WriteString(m_PasswordPrompt);

                SymmetricAlgorithm cipher = GetCipher();
                cipher.GenerateIV();

                fStrm.Write(cipher.IV, 0, cipher.IV.Length);

                using (CryptoStream cStrm = new CryptoStream(fStrm, cipher.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(cStrm, Topics);
                }
            }
        }

        /// <summary>
        /// Changes current password for storage.
        /// </summary>
        /// <param name="oldPassword">Old password.</param>
        /// <param name="newPassword">New password.</param>
        public void ChangePassword(string oldPassword, string newPassword)
        {
            if (oldPassword != m_Password)
                throw new WrongPasswordException();

            if (string.IsNullOrEmpty(newPassword))
                throw new ArgumentNullException("newPassword");

            m_Password = newPassword;
        }

        /// <summary>
        /// Deciphers list of topics.
        /// </summary>
        private void DecipherTopics()
        {
            if (!File.Exists(StorageFilePath))
            {
                Topics = new TopicsList();
                m_Version = LastVersion;
                m_PasswordPrompt = string.Empty;
                return;
            }

            m_Version = IncorrectVersion;
            m_PasswordPrompt = string.Empty;

            try
            {
                using (FileStream fStrm = new FileStream(StorageFilePath, FileMode.Open, FileAccess.Read))
                {
                    m_Version = fStrm.ReadInt32();

                    m_PasswordPrompt = fStrm.ReadString();

                    SymmetricAlgorithm cipher = GetCipher();

                    var ivBuffer = new byte[cipher.BlockSize / 8];
                    fStrm.Read(ivBuffer, 0, ivBuffer.Length);

                    cipher.IV = ivBuffer;

                    using (CryptoStream cStrm = new CryptoStream(fStrm, cipher.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        Topics = (TopicsList)formatter.Deserialize(cStrm);
                        return;
                    }
                }
            }
            catch
            {
                Topics = null;
                m_Password = null;
            }
        }

        /// <summary>
        /// Returns ciphering algorithm.
        /// </summary>
        /// <returns>Ciphering algorithm.</returns>
        private SymmetricAlgorithm GetCipher()
        {
            if (string.IsNullOrEmpty(m_Password))
                throw new InvalidOperationException("Password can't be null or empty.");

            SymmetricAlgorithm cipher = Aes.Create();
            cipher.Mode = CipherMode.CBC;
            cipher.BlockSize = 128;
            cipher.KeySize = 256;

            byte[] salt = Encoding.ASCII.GetBytes(Settings.Default.Salt);
            Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(m_Password, salt);

            cipher.Key = key.GetBytes(cipher.KeySize / 8);

            return cipher;
        }
    }
}
