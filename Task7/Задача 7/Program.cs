using System.IO;
class WorkWithFile
{
    public static string[] ReadFromFile(string path)
    {
        string[] digits = File.ReadAllText(path).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return digits;
    }
    public static string Calculation(int[] digits)
    {
        int result = digits[0] * digits[1] * digits[2] * 2;
        return Convert.ToString(result);
    }
    public static int[] Converter(int[] IntDigits, string[] StringDigits)
    {
        try
        {
            for (int i = 0; i < StringDigits.Length; i++)
            {
                IntDigits[i] = int.Parse(StringDigits[i]);
            }
        }
        catch(Exception e)
        {
            Console.WriteLine("В массиве должны находиться только числа!" + e.Message);
        }
        return IntDigits;
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
        string InputPath = @"C:\Users\Никита\Documents\Мои работы\Задача 7\Input.txt";
        string OutputPath = @"C:\Users\Никита\Documents\Мои работы\Задача 7\Output.txt";
        string[] digits = WorkWithFile.ReadFromFile(InputPath);
        int[] IntDigits = new int[digits.Length];
        IntDigits = WorkWithFile.Converter(IntDigits, digits);
        string result = WorkWithFile.Calculation(IntDigits);
        WorkWithFile.WriteToFile(OutputPath, result);
        Console.WriteLine("Дело сделано!");
    }
}