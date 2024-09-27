using System;
using System.IO;
class TextFile
{
    public static string ReadFromFile(string path)
    {
        try
        {
            string text = File.ReadAllText(path);
            return text;
        }
        catch
        {
            throw new Exception("Ошибка при чтении данных из файла");
        }
    }
    public static void WriteToFile(string path, string text)
    {
        try
        {
            File.WriteAllText(path, text);
        }
        catch
        {
            throw new Exception("Ошибка при чтении данных из файла");
        }
    }
}
class Program
{
    static void Main(String[] args)
    {
        const string OutputPath = @"C:\Users\Никита\Pictures\Задача1\Test.txt";
        const string InputPath = @"C:\Users\Никита\Pictures\Задача1\Test2.txt";
        FileInfo fileinfo = new FileInfo(OutputPath);
        if (fileinfo.Exists)
        {
            string temp = TextFile.ReadFromFile(OutputPath);
            TextFile.WriteToFile(InputPath, temp);
        }
        Console.WriteLine("Дело сделано!");
    }
}