internal class Program
{
    const string _promptNumberText = "Please input a two-digit number to calculate the persistance of: ";
    const string _promptTypeText = "Please use a or m to indicate whether you want to calculate additive persistance or multiplicative persistance: ";
    const string _outputPersistance = "The presistance result is: ";
    static int CalcAddPers(int d1, int d2)
    {
        while (d1 != 0)
        {
            int res = d1 + d2;
            d1 = res / 10;
            d2 = res % 10;
        }
        return d2;
    }

    static int CalcMultPers(int d1, int d2)
    {
        while (d1 != 0)
        {
            int res = d1 * d2;
            d1 = res / 10;
            d2 = res % 10;
        }
        return d2;
    }
    static void Main()
    {
        int number = 0;
        string input = string.Empty;

        while (!int.TryParse(input, out number) || !(number >= 10 && number <= 99))
        {
            Console.WriteLine(_promptNumberText);
            input = Console.ReadLine() ?? string.Empty;
        }

        input = string.Empty;
        while (input != "a" && input != "m")
        {
            Console.WriteLine(_promptTypeText);
            input = Console.ReadLine() ?? string.Empty;
        }

        int d1 = number / 10;
        int d2 = number % 10;

        if (input == "a")
        {
            Console.WriteLine($"{_outputPersistance}{CalcAddPers(d1, d2)}");
        }
        else
        {
            Console.WriteLine($"{_outputPersistance}{CalcMultPers(d1, d2)}");
        }
    }
}