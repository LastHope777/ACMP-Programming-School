class WorkWithFile
{
    public static string[] ReadFromFile(string path)
    {
        string[] digits = File.ReadAllText(path).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return digits;
    }
    public static string Calculation(string[] digits)
    {
        string result = "";
        int IntResult = 0;
        try
        {
            IntResult = Convert.ToInt32(digits[0]) + Convert.ToInt32(digits[1]) - Convert.ToInt32(digits[2]);
            if (IntResult < 0)
                result = "Impossible";
            else
                result = Convert.ToString(IntResult);
        }
        catch(Exception e)
        {
            Console.WriteLine("Ошибка! В файле должны находиться только числа!" + e.Message);
        }
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
        string InputPath = @"C:\Users\Никита\Documents\Мои работы\Задача 14\Input.txt";
        string OutputPath = @"C:\Users\Никита\Documents\Мои работы\Задача 14\Output.txt";
        string[] digits = WorkWithFile.ReadFromFile(InputPath);
        if (digits.Length != 3)
            Console.WriteLine("Ошибка! В файле должно находиться 3 числа!");
        else
        {
            string result = WorkWithFile.Calculation(digits);
            if (result == "")
                Console.WriteLine("Дело не сделано! =(");
            else
            {
                WorkWithFile.WriteToFile(OutputPath, result);
                Console.WriteLine("Дело сделано!");
            }
        }
    }
}