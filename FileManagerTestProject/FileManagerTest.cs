using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrypticMules_FileManager;
using System;
using System.IO;

namespace FileManagerTestProject
{
   // D:\Spring 2022\Software Development 2\TestDirectory\VowelTest.txt

    [TestClass]
    public class FileManagerTest 
    {
        private static string? vowlPath;
        private static string? singleVowlPath;
        private static string? wordPath;
        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            string vowlTxtfile = context.Properties["VowlTest"].ToString();
            vowlPath = Path.Combine(
                Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString(),
                @"TestFiles\", vowlTxtfile);

            
            string singleVowlTxtfile = context.Properties["SingleVowlTest"].ToString();
            singleVowlPath = Path.Combine(
                Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString(),
                @"TestFiles\", singleVowlTxtfile);

            string wordfile = context.Properties["WordFileTest"].ToString();
            wordPath = Path.Combine(
                Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString(),
                @"TestFiles\", wordfile);
        }


        private FileManager _fm;
        public FileManagerTest()
        {
            _fm = new FileManager();
        }
        [TestMethod]
        public void FileExistTest()
        {

            bool result = _fm.FileExists(vowlPath);
            
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void FileGetsDirectoryTest()
        {

            string result = _fm.DirectoryName(vowlPath);

            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void FileGetsDirectoryLargestTest()
        {

            string result = _fm.LargestFileInCurrentDirectory(vowlPath);

            Assert.AreEqual("ALargeText.txt", result);

        }
        [TestMethod]
        public void FileGetsFileNameTest()
        {

            string result = _fm.FileName(vowlPath);

            Assert.AreEqual("VowelTest.txt", result);

        }
        [TestMethod]
        public void FileGetsFileExtTest()
        {

            string result = _fm.FileExtension(vowlPath);

            Assert.AreEqual(".txt", result);

        }
        [TestMethod]
        public void FileGetsVowlsWithSTest()
        {

            string result = _fm.VowelWeight(vowlPath);

            Assert.AreEqual("2 As, 2 Es, 2 Is, 2 Os, 2 Us, 2 Ys", result);

        }
        [TestMethod]
        public void FileGetsVowlsWithoutSTest()
        {

            string result = _fm.VowelWeight(singleVowlPath);

            Assert.AreEqual("1 A, 1 E, 1 I, 1 O, 1 U, 1 Y", result);

        }
        [TestMethod]
        public void FileGetsVowlsWordTest()
        {

            string result = _fm.VowelWeight(wordPath);

            Assert.AreEqual("0 As 0 Es 0 Is 0 Os 0 Us 0 Ys", result);

        }
        
        [TestMethod]
        public void FileGetsByteArrayTest()
        {
           
            byte[] result = _fm.GetByteArray(vowlPath);
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

            string result = _fm.ToString(vowlPath);
           
            Assert.IsNotNull(result);

        }

        
    }
}