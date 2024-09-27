class WorkWithFile
{
    public static string ReadFromFile(string path)
    {
        string FirstNumber = File.ReadAllText(path);
        return FirstNumber;
    }
    public static string CalculationThirdNumber(string FirstNumber)
    {
        string ThirdNumber = "";
        try
        {
            ThirdNumber = Convert.ToString(9 - Convert.ToInt32(FirstNumber));
        }
        catch(Exception e)
        {
            Console.WriteLine("Ошибка! В исходном файле должно находиться число! \n" + e.Message);
        }
        return ThirdNumber;
    }
    public static void WriteToFile(string[] digits, string path)
    {
        File.WriteAllText(path, digits[0] + digits[1] + digits[2]);
    }
}
class Program
{
    static void Main()
    {
        string InputPath = @"C:\Users\Никита\Documents\Мои работы\Задача 11\Input.txt";
        string OutputPath = @"C:\Users\Никита\Documents\Мои работы\Задача 11\Output.txt";
        string[] digits = new string[3];
        digits[1] = "9";
        digits[0] = WorkWithFile.ReadFromFile(InputPath);
        try
        {
            if (Convert.ToInt32(digits[0]) < 1 || Convert.ToInt32(digits[0]) > 9)
            {
                Console.WriteLine("Ошибка! Число в файле должно быть положительным и не должно превышать 9!");
            }
            else
            {
                digits[2] = WorkWithFile.CalculationThirdNumber(digits[0]);
                WorkWithFile.WriteToFile(digits, OutputPath);
                Console.WriteLine("Дело сделано!");
            }
        }
        catch (Exception e) 
        { 
            Console.WriteLine("Ошибка! В исходном файле должно находиться число! \n" + e.Message);
        }
    }
}