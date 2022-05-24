using System.IO;

namespace CrypticMules_FileManager
{

    public class FileManager
    {
        public bool FileExists(string filepath)
        {
            bool exists = File.Exists(filepath);
            return exists;
        }

        public string DirectoryName(string filepath)
        {
            string name = Path.GetDirectoryName(filepath);


            return name;
        }

        public string LargestFileInCurrentDirectory(string filepath)
        {
            string CurrentDircetory = DirectoryName(filepath);

             // Take a snapshot of the file system.  
             DirectoryInfo dir = new DirectoryInfo(CurrentDircetory);

             // This method assumes that the application has discovery permissions  
                // for all folders under the specified path.  
                IEnumerable<FileInfo> fileList = dir.GetFiles("*.*", SearchOption.AllDirectories);

                //Return the size of the largest file  
                long maxSize =
                    (from file in fileList
                     let len = GetFileLength(file)
                     select len)
                     .Max();

                

                // Return the FileInfo object for the largest file  
                // by sorting and selecting from beginning of list  
                FileInfo longestFile =
                    (from file in fileList
                     let len = GetFileLength(file)
                     where len > 0
                     orderby len descending
                     select file)
                    .First();

            return longestFile.FullName;
                                     
                //string largest = File.;

                //return largest;
        }
        static long GetFileLength(FileInfo fi)
        {
            long retval;
            try
            {
                retval = fi.Length;
            }
            catch (FileNotFoundException)
            {
                // If a file is no longer present,  
                // just add zero bytes to the total.  
                retval = 0;
            }
            return retval;
        }
        //if a tie is found, first one alpha sorted

        //string VowelWeight(filepath)
        //    //Format: 12 Es, 1 A, 4 Is, 6 Os, 2 Us, 0Ys
        //    //return all zeros if file supplied has no txt extension

        //public string FileName()
        //{

        //    return Path.GetFileName();

        //}

        public string FileExtension(string filepath)
        {
            string extention = Path.GetExtension(filepath);


            return extention;
        }

        //byte[] GetByteArray(filepath)

        //string ToString()
        //    //returns a string concatenation of:
        //string FilePath
        //long Size
        //bool ReadOnly
        //DateTime DateChanged
    }
}