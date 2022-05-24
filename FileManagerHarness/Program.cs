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

string ohshit = fm.VowelWeight(input);

Console.WriteLine(exists);
Console.WriteLine(directory);
Console.WriteLine(largest);
Console.WriteLine(fileName);
Console.WriteLine(extention);

Console.WriteLine(ohshit);
