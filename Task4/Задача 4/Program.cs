using System.IO;
using System;
class Courses
{
    public static string FirstCourse(string path)
    {
        int minutes = 0;
        int temp = 0;
        try
        {
            string secondLine = File.ReadLines(path).Skip(1).First();
            string[] Numbers = secondLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(Numbers);
            for (int i = 0; i < Numbers.Length; i++)
            {
                minutes += Convert.ToInt32(Numbers[i]) + temp;
                temp += Convert.ToInt32(Numbers[i]);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Ошибка! \n" + e.Message);
        }
        return Convert.ToString(minutes);
    }
    public static string ThirdCourse(string path)
    {
        int minutes = 0;
        int temp = 0;
        try
        {
            string secondLine = File.ReadLines(path).Skip(1).First();
            string[] Numbers = secondLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(Numbers);
            for (int i = 0; i < Numbers.Length; i++)
            {
                minutes += Convert.ToInt32(Numbers[i]) + temp;
                temp += Convert.ToInt32(Numbers[i]);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Ошибка! \n" + e.Message);
        }
        return Convert.ToString(minutes);
    }
    public static string FifthCourse(string path)
    {
        int minutes = 0;
        int temp = 0;
        try
        {
            string secondLine = File.ReadLines(path).Skip(1).First();
            string[] Numbers = secondLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < Numbers.Length; i++)
            {
                minutes += Convert.ToInt32(Numbers[i]) + temp;
                temp += Convert.ToInt32(Numbers[i]);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Ошибка! \n" + e.Message);
        }
        return Convert.ToString(minutes);
    }
    public static void Champion(int first, int third, int fifth, string path)
    {
        string FirstWin = "1";
        string ThirdWin = "3";
        string FifthWin = "5";
        int minutes = 0;
        if (first <= third && first <= fifth)
            File.WriteAllText(path, FirstWin);
        if (first > third && third <= fifth)
            File.WriteAllText(path, ThirdWin);
        if (fifth < third && fifth < first)
            File.WriteAllText(path, FifthWin);
    }
}
class Program
{
    static void Main()
    {
        string InputPath = @"C:\Users\Никита\Pictures\Задача 4\Input.txt";
        string OutputPath = @"C:\Users\Никита\Pictures\Задача 4\Output.txt";
        string first = Courses.FirstCourse(InputPath);
        string third = Courses.ThirdCourse(InputPath);
        string fifth = Courses.FifthCourse(InputPath);
        Courses.Champion(Convert.ToInt32(first), Convert.ToInt32(third), Convert.ToInt32(fifth), OutputPath);
        Console.WriteLine("Дело сделано!");
    }
}