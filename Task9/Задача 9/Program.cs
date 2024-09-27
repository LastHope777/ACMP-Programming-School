class WorkWithFile
{
    public static string[] ReadFromFile(string path)
    {
        string[] digits = File.ReadAllText(path).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return digits;
    }
    public static string[] Calculation(string[] digits)
    {
        string[] StringResult = new string[2];
        try
        {
            int[] IntResult = new int[2];
            int CountOfBanks = Convert.ToInt32(digits[0]) + Convert.ToInt32(digits[1]) - 1;
            IntResult[0] = CountOfBanks - Convert.ToInt32(digits[0]);
            IntResult[1] = CountOfBanks - Convert.ToInt32(digits[1]);
            StringResult[0] = Convert.ToString(IntResult[0]);
            StringResult[1] = Convert.ToString(IntResult[1]);
            Console.WriteLine("Дело сделано!");
        }
        catch(Exception e)
        {
            Console.WriteLine("Ошибка! В исходном файле должно быть два числа!" + e.Message);
        }
        return StringResult;
    }
    public static void WriteToFile (string path, string[] result)
    {
        File.WriteAllText(path, result[0] + " " + result[1]);
    }
}
class Program
{
    static void Main()
    {
        string InputPath = @"C:\Users\Никита\Documents\Мои работы\Задача 9\Input.txt";
        string OutputPath = @"C:\Users\Никита\Documents\Мои работы\Задача 9\Output.txt";
        string[] StringDigits = WorkWithFile.ReadFromFile(InputPath);
        string[] result = WorkWithFile.Calculation(StringDigits);
        WorkWithFile.WriteToFile(OutputPath, result);
    }
}