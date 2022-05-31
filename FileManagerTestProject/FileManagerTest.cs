using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrypticMules_FileManager;
using System;
using System.IO;

namespace FileManagerTestProject
{


    [TestClass]
    public class FileManagerTest 
    {
        private static string? path;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            string txtfile = context.Properties["GoodFilePath"].ToString();
            path = Path.Combine(
                Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString(),
                @"TestFiles\", txtfile);
        }


        private FileManager _fm;
        public FileManagerTest()
        {
            _fm = new FileManager();
        }
        [TestMethod]
        public void FileExistTest()
        {

            bool result = _fm.FileExists(path);
            
            Assert.IsTrue(result);

        }
        [TestMethod]
        public void FileGetsDirectoryTest()
        {

            string result = _fm.DirectoryName(path);

            Assert.AreEqual(@"D:\Spring 2022\Software Development 2\TestDirectory", result);

        }

        [TestMethod]
        public void FileGetsDirectoryLargestTest()
        {

            string result = _fm.LargestFileInCurrentDirectory(path);

            Assert.AreEqual("ALargeText.txt", result);

        }
        [TestMethod]
        public void FileGetsFileNameTest()
        {

            string result = _fm.FileName(path);

            Assert.AreEqual("VowelTest.txt", result);

        }
        [TestMethod]
        public void FileGetsFileExtTest()
        {

            string result = _fm.FileExtension(path);

            Assert.AreEqual(".txt", result);

        }
        [TestMethod]
        public void FileGetsVowlsTest()
        {

            string result = _fm.VowelWeight(path);

            Assert.AreEqual("2 As 2 Es 2 Is 2 Os 2 Us 2 Ys", result);

        }
        [TestMethod]
        public void FileGetsByteArrayTest()
        {
           
            byte[] result = _fm.GetByteArray(path);
            string allbytes = string.Empty;
            foreach (byte b in result)
            {
                allbytes += b + ",";

            }
            Assert.AreEqual("97,65,32,69,101,32,73,105,32,79,111,32,85,117,32,89,121,32,", allbytes);

        }

        [TestMethod]
        public void FileToStringTest()
        {

            string result = _fm.ToString(path);
           
            Assert.AreEqual("D:/Spring 2022/Software Development 2/TestDirectory/VowelTest.txt, 18, False, 5/24/2022 12:30:48 PM", result);

        }

        
    }
}