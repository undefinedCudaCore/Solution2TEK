internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine();
        Console.WriteLine("Part No. 1");
        Console.WriteLine();

        Console.Write("Enter 3 digit number: ");

        string getNumber = Console.ReadLine();
        int convertedNumber = Convert.ToInt32(getNumber);

        int firstNumber = convertedNumber / 100;
        int secondNumber = convertedNumber / 10 % 10;
        int thirdNumber = convertedNumber % 100 % 10;

        if (getNumber.Length != 3)
        {
            Console.WriteLine("This is not 3 digit number!");
        }else if (firstNumber == secondNumber)
        {
            Console.WriteLine("First number == second number");
        }
        else if (firstNumber > secondNumber)
        {
            Console.WriteLine("First number > second number");

        }
        else if (secondNumber > thirdNumber)
        {
            Console.WriteLine("Second number > third number");
        }
        else if (thirdNumber > firstNumber)
        {
            Console.WriteLine("Third number > first number");
        }

        Console.WriteLine();
        Console.WriteLine("Part No. 2");
        Console.WriteLine();

        Console.WriteLine("Enter today's outside temperature:");

        string getTemperature = Console.ReadLine();
        int convertedTemperature = Convert.ToInt32(getTemperature);

        if (convertedTemperature < 0)
        {
            Console.WriteLine("žiauriai šalta");
        } 
        else if (convertedTemperature < 10)
        {
            Console.WriteLine("labai šalta");
        }
        else if (convertedTemperature < 20)
        {
            Console.WriteLine("šalta");
        }
        else if (convertedTemperature < 30)
        {
            Console.WriteLine("normali temperatūra");
        }
        else if (convertedTemperature < 40)
        {
            Console.WriteLine("karšta");
        }
        else if (convertedTemperature >= 40)
        {
            Console.WriteLine("visiškai degina");
        }
    }
}