using System.Globalization;
using System.IO;
class WorkWithFile
{
    public static string[] ReadFromFile(string path)
    {
        int NumberCounts = 0;
        string[] numbers = new string[2];
        string[] lines = File.ReadAllLines(path);
        try
        {
            foreach (string line in lines)
            {
                string[] Numbers = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string number in Numbers)
                {
                    if (NumberCounts == 0)
                    {
                        numbers[0] = number;
                        NumberCounts++;
                    }
                    else if (NumberCounts == 1)
                    {
                        numbers[1] = number;
                        NumberCounts++;
                    }
                }
            }
        }
        catch(Exception e)
        {
            Console.WriteLine("Ошибка! " + e.Message);
        }
        return numbers;
    }
    public static string Calculation(string[] digits)
    {
        string result = "";
        if (Convert.ToInt32(digits[0]) > Convert.ToInt32(digits[1]))
            result = ">";
        if (Convert.ToInt32(digits[0]) == Convert.ToInt32(digits[1]))
            result = "=";
        if (Convert.ToInt32(digits[0]) < Convert.ToInt32(digits[1]))
            result = "<";
        return result;
    }
    public static void WriteToFile(string path, string result)
    {
        File.WriteAllText(path, result);
    }
}
class Program
{
    static void Main()
    {
        string InputPath = @"C:\Users\Никита\Documents\Мои работы\Задача 5\Input.txt";
        string OutputPath = @"C:\Users\Никита\Documents\Мои работы\Задача 5\Output.txt";
        string[] Digits = WorkWithFile.ReadFromFile(InputPath);
        if (Digits.Length != 2)
            Console.WriteLine("Ошибка! Должно быть ровно 2 числа!");
        else
        {
            try 
            {
                Convert.ToInt32(Digits[0]);
                Convert.ToInt32(Digits[1]);
                string result = WorkWithFile.Calculation(Digits);
                WorkWithFile.WriteToFile(OutputPath, result);
                Console.WriteLine("Дело сделано!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка! Нужно ввести числа, а не буквы!" + e.Message);
            }

        }
    }
}