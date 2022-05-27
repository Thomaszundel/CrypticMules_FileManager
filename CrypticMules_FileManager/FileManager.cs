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
            if (FileExtension(filepath) != ".txt")
            {
                return "0 As 0 Es 0 Is 0 Os 0 Us 0 Ys";
            }

            StreamReader sr = new StreamReader(filepath);
            string allWords = sr.ReadToEnd().ToUpper();
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

            foreach (char c in allWords)
            {
                if (c == 65)
                    countA++;
                if (c == 69)
                    countE++;
                if (c == 73)
                    countI++;
                if (c == 79)
                    countO++;
                if (c == 85)
                    countU++;
                if (c == 89)
                    countY++;
            }

            A = countA.ToString() + " As";
            E = countE.ToString() + " Es";
            I = countI.ToString() + " Is";
            O = countO.ToString() + " Os";
            U = countU.ToString() + " Us";
            Y = countY.ToString() + " Ys";

            if (countA == 1)
                A = countA.ToString() + " A";
            if (countE == 1)
                E = countE.ToString() + " E";
            if (countI == 1)
                I = countI.ToString() + " I";
            if (countO == 1)
                O = countO.ToString() + " O";
            if (countU == 1)
                U = countU.ToString() + " U";
            if (countY == 1)
                Y = countY.ToString() + " Y";
            
            return A + " " + E + " " + I + " " + O + " " + U + " " + Y;
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

       public string ToString(string filepath)
        {
             FileInfo fileInfo = new(filepath);
            return 
                filepath + "\n" + fileInfo.Length + "\n" + fileInfo.IsReadOnly + "\n" + fileInfo.LastWriteTime;
        }
    //    //returns a string concatenation of:
    //string FilePath
    //long Size
    //bool ReadOnly
    //DateTime DateChanged
}
}