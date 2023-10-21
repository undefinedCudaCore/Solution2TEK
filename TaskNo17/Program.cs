internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine();
        Console.WriteLine("Part No. 1");
        Console.WriteLine();

        Console.Write("Enter positive number: ");

        string getPositiveNumber = Console.ReadLine();
        int convertPositiveNumber = Convert.ToInt32(getPositiveNumber);

        while (convertPositiveNumber > 0)
        {
            Console.WriteLine(convertPositiveNumber);
            convertPositiveNumber--;
        }

        Console.WriteLine();
        Console.WriteLine("Part No. 2");
        Console.WriteLine();

        Console.Write("Enter negative number: ");

        string getNegativeNumber = Console.ReadLine();
        int convertNegativeNumber = Convert.ToInt32(getNegativeNumber);

        while (convertNegativeNumber <= 0)
        {
            Console.WriteLine(convertNegativeNumber);
            convertNegativeNumber++;
        }

        Console.WriteLine();
        Console.WriteLine("Part No. 3");
        Console.WriteLine();

        while (true)
        { 
        
            Console.WriteLine("Enter first number: ");

            string getFirstNumberForWhile = Console.ReadLine();
            double convertFirstNumberForWhile = Convert.ToDouble(getFirstNumberForWhile);

            Console.WriteLine("Enter second number: ");

            string getSecondNumberForWhile = Console.ReadLine();
            double convertSecondNumberForWhile = Convert.ToDouble(getSecondNumberForWhile);

            Console.WriteLine($"{convertFirstNumberForWhile} + {convertSecondNumberForWhile} = {Math.Round((convertFirstNumberForWhile + convertSecondNumberForWhile), 2)}");
            Console.WriteLine();
            Console.WriteLine($"{convertFirstNumberForWhile} - {convertSecondNumberForWhile} = {Math.Round((convertFirstNumberForWhile - convertSecondNumberForWhile), 2)}");
            Console.WriteLine();
            Console.WriteLine($"{convertFirstNumberForWhile} * {convertSecondNumberForWhile} = {Math.Round((convertFirstNumberForWhile * convertSecondNumberForWhile), 2)}");
            Console.WriteLine();
            Console.WriteLine($"{convertFirstNumberForWhile} / {convertSecondNumberForWhile} = {Math.Round((convertFirstNumberForWhile / convertSecondNumberForWhile), 2)}");
            Console.WriteLine();



        }

    }
}