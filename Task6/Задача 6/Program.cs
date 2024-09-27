using System.IO;
class WorkWithFile
{
    public static string[] ReadFromFile(string path)
    {
        string[] digits = File.ReadAllText(path).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return digits;
    }
    public static string Calculation(string path, int first, int second, int third)
    {
        string result = "";
        if (first * second < third)
            result = "NO";
        else
            result = "YES";
        return result;
    }
    public static void WriteToFile (string path, string result) 
    {
        File.WriteAllText(path, result);
    }
}
class Program
{
    static void Main()
    {
        string InputPath = @"C:\Users\Никита\Documents\Мои работы\Задача 6\Input.txt";
        string OutputPath = @"C:\Users\Никита\Documents\Мои работы\Задача 6\Output.txt";
        string[] digits = WorkWithFile.ReadFromFile(InputPath);
        if (digits.Length != 3)
        {
            Console.WriteLine("Ошибка! В файле должно быть ровно 3 числа!");
        }
        else
        {
            try
            {
                string result = WorkWithFile.Calculation(OutputPath, Convert.ToInt32(digits[0]), Convert.ToInt32(digits[1]), Convert.ToInt32(digits[2]));
                WorkWithFile.WriteToFile(OutputPath, result);
                Console.WriteLine("Дело сделано!");
            }
            catch
            {
                Console.WriteLine("В файле должны находиться только числа!");
            }
            
        }
    }
}