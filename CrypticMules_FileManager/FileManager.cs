using System.IO;

namespace CrypticMules_FileManager
{

    public class FileManager
    {
        Dictionary<int, string> files = new Dictionary<int, string>()
        {
            {65, "A"},
            {69, "E"},
            {73, "I"},
            {79, "O"},
            {85, "U"},
            {89, "Y"},
            {97, "a"},
            {101, "e"},
            {105, "i"},
            {111, "o"},
            {117, "u"},
            {121, "y"}
        };
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
            DirectoryInfo dir = new DirectoryInfo(CurrentDircetory);

            IEnumerable<FileInfo> fileList = dir.GetFiles("*.*", SearchOption.AllDirectories);

            FileInfo longestFile =
                (from file in fileList
                 let len = GetFileLength(file)
                 where len > 0
                 orderby len descending
                 select file)
                .First();
            string foundFile = FileName(longestFile.FullName);

            return foundFile;
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
                retval = 0;
            }
            return retval;
        }

        public string VowelWeight(string filepath)
        {
            StreamReader sr = new StreamReader(filepath);
            string allWords = sr.ReadToEnd();
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
                    files.TryGetValue(c, out string Check);
                    if (Check == "a" || Check == "A")
                        countA++;
                    if (Check == "e" || Check == "E")
                        countE++;
                    if (Check == "i" || Check == "I")
                        countI++;
                    if (Check == "o" || Check == "O")
                        countO++;
                    if (Check == "u" || Check == "U")
                        countU++;
                    if (Check == "y" || Check == "Y")
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
       
        public string FileName(string filepath)
        {
            string filename = Path.GetFileName(filepath);

            return filename;
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
        }

        //string ToString()
        //    //returns a string concatenation of:
        //string FilePath
        //long Size
        //bool ReadOnly
        //DateTime DateChanged
    }
}