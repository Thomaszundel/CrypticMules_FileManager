using CrypticMules_FileManager;

string input;
bool exists = false;

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

Console.WriteLine(exists);
Console.WriteLine(directory);
Console.WriteLine(largest);
Console.WriteLine(fileName);
Console.WriteLine(extention);
Console.WriteLine(vowelCount);

string allbytes = string.Empty;
foreach (byte b in bytes)
{
    allbytes += b + ",";
   
}
Console.WriteLine(allbytes);

Console.WriteLine(toString);


