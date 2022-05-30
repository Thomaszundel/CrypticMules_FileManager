using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagerTestProject
{
    public class TestBase
    {
        public static  TestContext? TestContext { get; set; }

        public static string GetFilePath()
        {
            string path = TestContext.Properties["GoodFilePath"].ToString();
            
            string newpath = Environment.CurrentDirectory;
            path = path.Replace("[ThePath]", newpath);

            return path;

        }
        //private FileManager _fm;
        //public FileManagerTest()
        //{
        //    _fm = new FileManager();
        //}
    }
}
