 class WorkWithFile
{
    public static string[] ReadFromFile(string path)
    {
        string[] digits = File.ReadAllText(path).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return digits;
    }
    public static bool Check(string[] digits)
    {
        try
        {
            if (Convert.ToInt32(digits[0]) * Convert.ToInt32(digits[1]) == Convert.ToInt32(digits[2]))
                return true;
            else
                return false;
        }
        catch(Exception e)
        {
            Console.WriteLine("Ошибка! В файле должно находиться 3 числа!" + e.Message);
            return false; 
        }
    }
    public static void WriteToFile(string path, string result)
    {
        File.WriteAllText(path, result);
    }
}
class Program
{
    static void Main()
    {;
        string InputPath = @"C:\Users\Никита\Documents\Мои работы\Задача 12\Input.txt";
        string OutputPath = @"C:\Users\Никита\Documents\Мои работы\Задача 12\Output.txt";
        string[] digits = WorkWithFile.ReadFromFile(InputPath);
        if (digits.Length != 3)
            Console.WriteLine("Ошибка! В файле должно находиться 3 числа!");
        else
        {
            if (WorkWithFile.Check(digits) == true)
            {
                string result = "Yes";
                WorkWithFile.WriteToFile(OutputPath, result);
                Console.WriteLine("Дело сделано!");
            }
            else
            {
                string result = "No";
                WorkWithFile.WriteToFile(OutputPath, result);
                Console.WriteLine("Дело сделано!");
            }
        }
    }
}