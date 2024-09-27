class WorkWithFile
{
    public static string[] ReadFromFile(string path)
    {
        string[] digits = File.ReadAllText(path).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return digits;
    }
    public static string Calculation(string[] digits)
    {
        int result = 0;
        try
        {
            result = Convert.ToInt32(digits[0]) * Convert.ToInt32(digits[0]) * Convert.ToInt32(digits[1]);
        }
        catch(Exception e)
        {
            Console.WriteLine("Ошибка! В файле должны находиться только 2 числа! \n" + e.Message);
        }
        return Convert.ToString(result);
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
        string InputPath = @"C:\Users\Никита\Documents\Мои работы\Задача 8\Input.txt";
        string OutputPath = @"C:\Users\Никита\Documents\Мои работы\Задача 8\Output.txt";
        string[] StringDigits = WorkWithFile.ReadFromFile(InputPath);
        string result = WorkWithFile.Calculation(StringDigits);
        WorkWithFile.WriteToFile(OutputPath, result);
        Console.WriteLine("Дело сделано!");
    }
}