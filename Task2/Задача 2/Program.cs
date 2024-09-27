using System;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

class WorkWithFile
{
    public static int[] ReadFromFile(string path)
    {
        int[] numbers = new int[2];
        try
        {
            int NumbersCount = -1;
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] Numbers = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string number in Numbers)
                {
                    NumbersCount++;
                    if (NumbersCount >= 2)
                    {
                        Console.WriteLine("Ошибка! Должно быть два числа!");
                    }
                    else
                    {
                        numbers[NumbersCount] = Convert.ToInt32(number);
                    }
                }
            }
        }
        catch(IOException e)
        {
             Console.WriteLine("Ошибка: " + e.Message);
        }
        return numbers;
    }
    public static int Sum(int num1, int num2)
    {
        int result = num1 + num2;
        return result;
    }
    public static void WriteToFile(string path, int result)
    {
        File.WriteAllText(path, Convert.ToString(result));
    }
}
class Program
{
    static void Main()
    {
        string InputFile = @"C:\Users\Никита\Pictures\Задача 2\Input.txt";
        string OutputFile = @"C:\Users\Никита\Pictures\Задача 2\Output.txt";
        int[] NumbersFromFile = new int[2];
        NumbersFromFile = WorkWithFile.ReadFromFile(InputFile);
        int ResultSum = WorkWithFile.Sum(NumbersFromFile[0], NumbersFromFile[1]);
        WorkWithFile.WriteToFile(OutputFile, ResultSum);
        Console.WriteLine("Дело сделано!");
    }
}