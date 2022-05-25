using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrypticMules_FileManager;

namespace FileManagerTestProject
{
    [TestClass]
    public class FileManagerTest
    {
        private FileManager _fm;
        public FileManagerTest()
        {
            _fm = new FileManager();
        }
        [TestMethod]
        public void FileExistTest()
        {

            bool result = _fm.FileExists("D:/Spring 2022/Software Development 2/TestDirectory/VowelTest.txt");
            
            Assert.IsTrue(result);

        }
        [TestMethod]
        public void FileGetsDirectoryTest()
        {

            string result = _fm.DirectoryName("D:/Spring 2022/Software Development 2/TestDirectory");

            Assert.AreEqual("TestDirectory",result);

        }
    }
}