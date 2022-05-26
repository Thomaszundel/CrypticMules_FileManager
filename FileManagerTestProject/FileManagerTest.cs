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

            string result = _fm.DirectoryName("D:/Spring 2022/Software Development 2/TestDirectory/VowelTest.txt");

            Assert.AreEqual(@"D:\Spring 2022\Software Development 2\TestDirectory", result);

        }

        [TestMethod]
        public void FileGetsDirectoryLargestTest()
        {

            string result = _fm.LargestFileInCurrentDirectory("D:/Spring 2022/Software Development 2/TestDirectory/VowelTest.txt");

            Assert.AreEqual("ALargeText.txt", result);

        }
        [TestMethod]
        public void FileGetsFileNameTest()
        {

            string result = _fm.FileName("D:/Spring 2022/Software Development 2/TestDirectory/VowelTest.txt");

            Assert.AreEqual("VowelTest.txt", result);

        }
        [TestMethod]
        public void FileGetsFileExtTest()
        {

            string result = _fm.FileExtension("D:/Spring 2022/Software Development 2/TestDirectory/VowelTest.txt");

            Assert.AreEqual(".txt", result);

        }
        [TestMethod]
        public void FileGetsVowlsTest()
        {

            string result = _fm.VowelWeight("D:/Spring 2022/Software Development 2/TestDirectory/VowelTest.txt");

            Assert.AreEqual("2 As 2 Es 2 Is 2 Os 2 Us 2 Ys", result);

        }
        [TestMethod]
        public void FileGetsByteArrayTest()
        {
           
            byte[] result = _fm.GetByteArray("D:/Spring 2022/Software Development 2/TestDirectory/VowelTest.txt");
            string allbytes = string.Empty;
            foreach (byte b in result)
            {
                allbytes += b + ",";

            }
            Assert.AreEqual("97,65,32,69,101,32,73,105,32,79,111,32,85,117,32,89,121,32,", allbytes);

        }
    }
}