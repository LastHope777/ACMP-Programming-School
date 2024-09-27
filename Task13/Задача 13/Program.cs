class WorkWithFile
{
    public static string ReadAndCalculation(string path)
    {
        string result = "";
        try
        {
            int first = 0;
            int second = 0;
            foreach (string line in File.ReadAllLines(path))
            {
                string[] OneLine = line.Split(' ');
                first += Convert.ToInt32(OneLine[0]);
                second += Convert.ToInt32(OneLine[1]);
            }
            if (first > second)
                result = "1";
            if (first < second)
                result = "2";
            if (first == second)
                result = "DRAW";
            Console.WriteLine("Дело сделано!");
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
        string Input = @"C:\Users\Никита\Documents\Мои работы\Задача 13\Input.txt";
        string Output = @"C:\Users\Никита\Documents\Мои работы\Задача 13\Output.txt";
        string result = WorkWithFile.ReadAndCalculation(Input);
        WorkWithFile.WriteToFile(Output, result);
    }
}