using System;
using System.IO;
using System.Text;

namespace EdlinSoftware.Safe.SafeLib
{
    /// <summary>
    /// Class with extention methods
    /// </summary>
    internal static class Extenders
    {
        /// <summary>
        /// Writes integer value to stream.
        /// </summary>
        /// <param name="strm">Stream to write to.</param>
        /// <param name="value">Integer value to write.</param>
        /// <exception cref="ArgumentNullException">Stream is null.</exception>
        public static void WriteInt32(this Stream strm, Int32 value)
        {
            if (strm == null)
            { throw new ArgumentNullException("strm"); }

            var buffer = BitConverter.GetBytes(value);
            strm.Write(buffer, 0, buffer.Length);
        }

        /// <summary>
        /// Reads integer value from stream (reverse order of bytes).
        /// </summary>
        /// <param name="strm">Stream to write to.</param>
        /// <returns>Integer value from stream.</returns>
        /// <exception cref="ArgumentNullException">Stream is null.</exception>
        public static Int32 ReadInt32(this Stream strm)
        {
            if (strm == null)
            { throw new ArgumentNullException("strm"); }

            byte[] buffer = new byte[4];
            strm.Read(buffer, 0, 4);
            return BitConverter.ToInt32(buffer, 0);
        }
        /// <summary>
        /// Writes string value to stream.
        /// </summary>
        /// <param name="strm">Stream to write to.</param>
        /// <param name="value">String value to write.</param>
        /// <exception cref="ArgumentNullException">Stream is null.</exception>
        public static void WriteString(this Stream strm, string value)
        {
            if (strm == null)
            { throw new ArgumentNullException("strm"); }


            var buffer = Encoding.Unicode.GetBytes(value);
            strm.WriteInt32(buffer.Length);
            strm.Write(buffer, 0, buffer.Length);
        }

        /// <summary>
        /// Reads string value from stream (reverse order of bytes).
        /// </summary>
        /// <param name="strm">Stream to write to.</param>
        /// <returns>String value from stream.</returns>
        /// <exception cref="ArgumentNullException">Stream is null.</exception>
        public static string ReadString(this Stream strm)
        {
            if (strm == null)
            { throw new ArgumentNullException("strm"); }

            var bufferSize = strm.ReadInt32();

            byte[] buffer = new byte[bufferSize];
            strm.Read(buffer, 0, buffer.Length);
            return Encoding.Unicode.GetString(buffer);
        }
    }
}
