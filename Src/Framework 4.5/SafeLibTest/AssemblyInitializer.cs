using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using NUnit.Framework;

namespace EdlinSoftware.Safe.SafeLibTest
{
    [SetUpFixture]
    public class AssemblyInitializer
    {
        [SetUp]
        public void Init()
        {
            var path = Utils.GetNoAccessPathFinder().GetGlobalStorageDirectory();

            var userName = WindowsIdentity.GetCurrent().Name;
            
            DirectorySecurity ds = new DirectorySecurity();
            ds.AddAccessRule(new FileSystemAccessRule(userName, FileSystemRights.FullControl, AccessControlType.Deny));
            ds.AddAccessRule(new FileSystemAccessRule(userName, FileSystemRights.ListDirectory, AccessControlType.Deny));
            ds.AddAccessRule(new FileSystemAccessRule(userName, FileSystemRights.Read, AccessControlType.Deny));
            ds.AddAccessRule(new FileSystemAccessRule(userName, FileSystemRights.Write, AccessControlType.Deny));
            ds.AddAccessRule(new FileSystemAccessRule(userName, FileSystemRights.ReadAndExecute, AccessControlType.Deny));
            ds.AddAccessRule(new FileSystemAccessRule(userName, FileSystemRights.Modify, AccessControlType.Deny));

            Directory.SetAccessControl(path, ds);
        }

        [TearDown]
        public void CleanUp()
        {
            var path = Utils.GetNoAccessPathFinder().GetGlobalStorageDirectory();

            var userName = WindowsIdentity.GetCurrent().Name;

            DirectorySecurity ds = new DirectorySecurity();
            ds.RemoveAccessRule(new FileSystemAccessRule(userName, FileSystemRights.FullControl, AccessControlType.Deny));
            ds.RemoveAccessRule(new FileSystemAccessRule(userName, FileSystemRights.ListDirectory, AccessControlType.Deny));
            ds.RemoveAccessRule(new FileSystemAccessRule(userName, FileSystemRights.Read, AccessControlType.Deny));
            ds.RemoveAccessRule(new FileSystemAccessRule(userName, FileSystemRights.Write, AccessControlType.Deny));
            ds.RemoveAccessRule(new FileSystemAccessRule(userName, FileSystemRights.ReadAndExecute, AccessControlType.Deny));
            ds.RemoveAccessRule(new FileSystemAccessRule(userName, FileSystemRights.Modify, AccessControlType.Deny));

            Directory.SetAccessControl(path, ds);
        }
    }
}
