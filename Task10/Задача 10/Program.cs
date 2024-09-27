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
            int Max = 0;
            int Min = 100000;
            for (int i = 0; i < digits.Length; i++)
            {
                if (Convert.ToInt32(digits[i]) > Max)
                {
                    Max = Convert.ToInt32(digits[i]);
                }
                if (Convert.ToInt32(digits[i])  < Min) 
                {
                    Min = Convert.ToInt32(digits[i]);
                }
            }
            result = Max - Min;
            Console.WriteLine("Дело сделано!");
        }
        catch(Exception e) 
        {
            Console.WriteLine("Ошибка! в файле должно находиться три числа!" + e.Message);
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
        string InputPath = @"C:\Users\Никита\Documents\Мои работы\Задача 10\Input.txt";
        string OutputPath = @"C:\Users\Никита\Documents\Мои работы\Задача 10\Output.txt";
        string[] digits = WorkWithFile.ReadFromFile(InputPath);
        if (digits.Length != 3)
        {
            Console.WriteLine("Ошибка! в файле должно находиться три числа!");
        }
        else
        {
            string result = WorkWithFile.Calculation(digits);
            WorkWithFile.WriteToFile(OutputPath, result);
        }
    }
}