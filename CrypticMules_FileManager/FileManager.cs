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
            string name = Path.GetFileName(filepath);


            return name;
        }

        //string LargestFileInCurrentDirectory(string filepath)
        //{
        //    string largest = File.;

        //    return largest;
        //}
            //if a tie is found, first one alpha sorted

        //string VowelWeight(filepath)
        //    //Format: 12 Es, 1 A, 4 Is, 6 Os, 2 Us, 0Ys
        //    //return all zeros if file supplied has no txt extension

        //string FileName

        //string FileExtension(filepath)

        //byte[] GetByteArray(filepath)

        //string ToString()
        //    //returns a string concatenation of:
        //string FilePath
        //long Size
        //bool ReadOnly
        //DateTime DateChanged
    }
}