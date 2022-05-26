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
                //long maxSize =
                //    (from file in fileList
                //     let len = GetFileLength(file)
                //     select len)
                //     .Max();

                

                // Return the FileInfo object for the largest file  
                // by sorting and selecting from beginning of list  
                FileInfo longestFile =
                    (from file in fileList
                     let len = GetFileLength(file)
                     where len > 0
                     orderby len descending
                     select file)
                    .First();

            return FileName(longestFile.FullName);
                                     
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

        public string VowelWeight(string filepath)
        {
           StreamReader sr = new StreamReader(filepath);
            string allWords =  sr.ReadToEnd();
            int countA = 0;
            int countE = 0;
            int countI = 0;
            int countO = 0;
            int countU = 0;
            int countY = 0;
            string A;
            string E;
            string I;
            string O;
            string U;
            string Y;

            if (allWords != null)
            {
                foreach (char c in allWords)
                {
                    //KVP.TryGetValue(c, out string g)
                    if (c == 65 || c == 97)
                        countA++;
                    if (c == 69 || c == 101)
                        countE++;
                    if (c == 73 || c == 105)
                        countI++;
                    if (c == 79 || c == 111)
                        countO++;
                    if (c == 85 || c == 117)
                        countU++;
                    if (c == 89 || c == 121)
                        countY++;
                }

                if (countA == 1)
                    A = countA.ToString() + " A";
                else
                    A = countA.ToString() + " As";
                if (countE == 1)
                    E = countE.ToString() + " E";
                else
                    E = countE.ToString() + " Es";
                if (countI == 1)
                    I = countI.ToString() + " I";
                else
                    I = countI.ToString() + " Is";
                if (countO == 1)
                    O = countO.ToString() + " O";
                else
                    O = countO.ToString() + " Os";
                if (countU == 1)
                    U = countU.ToString() + " U";
                else
                    U = countU.ToString() + " Us";
                if (countY == 1)
                    Y = countY.ToString() + " Y";
                else
                    Y = countY.ToString() + " Ys";
                return A + " " + E + " " + I + " " + O + " " + U + " " + Y;
            }

            else

                return "0 As 0 Es 0 Is 0 Os 0 Us 0 Ys";
        }
        //    //Format: 12 Es, 1 A, 4 Is, 6 Os, 2 Us, 0Ys
        //    //return all zeros if file supplied has no txt extension


        public string FileName(string filepath)
        {

            return Path.GetFileName(filepath);

        }

        public string FileExtension(string filepath)
        {
            string extention = Path.GetExtension(filepath);


            return extention;
        }

        

        public byte[] GetByteArray(string filepath)
        {

             byte[] allbytes = File.ReadAllBytes(filepath);

            return allbytes;

            //string CurrentDircetory = DirectoryName(filepath);


            //DirectoryInfo dir = new DirectoryInfo(CurrentDircetory);
            //IEnumerable<FileInfo> fileList = dir.GetFiles("*.*", SearchOption.AllDirectories);



            ////Return the size of the largest file
            //long maxSize =
            //(from file in fileList
            // let len = GetFileLength(file)
            // select len)
            // .Max();

            //FileInfo longestFile =
            //    (from file in fileList
            //     let len = GetFileLength(file)
            //     where len > 0
            //     orderby len descending
            //     select file)
            //    .First();

            //foreach (FileInfo file in fileList)
            //{
            //    long singleFile = file.Length;


            //    byte singlebyte = BitConverter.GetBytes(singleFile);

            //}



            //allBytes = .ToArray();
        }

        //string ToString()
        //    //returns a string concatenation of:
        //string FilePath
        //long Size
        //bool ReadOnly
        //DateTime DateChanged
    }
}