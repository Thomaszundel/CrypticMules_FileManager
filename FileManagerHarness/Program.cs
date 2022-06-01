using CrypticMules_FileManager;

string input;
bool exists = false;
Console.WriteLine("Please input a filepath");
input = Console.ReadLine();

FileManager fm = new FileManager();

exists = fm.FileExists(input);

string directory  = fm.DirectoryName(input);

string largest = fm.LargestFileInCurrentDirectory(input);

string fileName = fm.FileName(input);

string extention = fm.FileExtension(input);

string vowelCount = fm.VowelWeight(input);

byte[] bytes = fm.GetByteArray(input);

string toString = fm.ToString(input);   

Console.WriteLine("File Exists: "+exists);
Console.WriteLine("Directory Name: "+directory);
Console.WriteLine("Larges file in current Directory: "+largest);
Console.WriteLine("Filename: "+fileName);
Console.WriteLine("File Extention: "+  extention);
Console.WriteLine("Vowel Count: "+vowelCount);

//string allbytes = string.Empty;
//foreach (byte b in bytes)
//{
//    allbytes += b + ",";
   
//}
Console.WriteLine("Length of byte array: "+bytes.Length);

Console.WriteLine("ToString output: "+toString);


