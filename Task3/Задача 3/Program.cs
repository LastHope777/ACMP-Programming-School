using System;
using System.IO;
class WorkWithFile
{
    public static string ReadText(string path)
    {
        string ColorNumbers = File.ReadAllText(path);
        ColorNumbers.Replace(" ", "");
        return ColorNumbers;
    }
    public static string Answer(string number)
    {
        int answer = Convert.ToInt32(number) + 1;
        return Convert.ToString(answer);
    }
    public static void WriteText(string path, string answer)
    {
        File.WriteAllText(path, answer);
    }
}
class Program
{
    static void Main()
    {
        string InputPath = @"C:\Users\Никита\Pictures\Задача 3\Input.txt";
        string OutputPath = @"C:\Users\Никита\Pictures\Задача 3\Output.txt";
        string NumberOfColor = WorkWithFile.ReadText(InputPath);
        string answer = WorkWithFile.Answer(NumberOfColor);
        WorkWithFile.WriteText(OutputPath, answer);
        Console.WriteLine("Дело сделано!");
    }
}