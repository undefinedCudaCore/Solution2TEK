using TaskNo33;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine();
        Console.WriteLine("Part No. 1");
        Console.WriteLine();

        Console.WriteLine("ENTER first number: ");
        int firstNumberForTaskThreeTwo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("ENTER second number: ");
        int secondNumberForTaskThreeTwo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Select an action from list:");
        Console.WriteLine("1 - The sum of the numbers.");
        Console.WriteLine("2 - Subtraction of two numbers.");
        Console.WriteLine("3 - The number x raised to the power y.");
        Console.WriteLine("4 - Square root of sum of two numbers.");
        int selection = Convert.ToInt32(Console.ReadLine());

        Skaiciavimas skaiciavimas = new Skaiciavimas();
        switch (selection)
        {
            case 1:
                Console.WriteLine($"Answer is: {skaiciavimas.Sudetis(firstNumberForTaskThreeTwo, secondNumberForTaskThreeTwo)}");
                break;
            case 2:
                Console.WriteLine($"Answer is: {skaiciavimas.Atimtis(firstNumberForTaskThreeTwo, secondNumberForTaskThreeTwo)}");
                break;
            case 3:
                Console.WriteLine($"Answer is: {skaiciavimas.KetvirtuLaipsniu(firstNumberForTaskThreeTwo, secondNumberForTaskThreeTwo)}");
                break;
            case 4:
                Console.WriteLine($"Answer is: {skaiciavimas.Saknis(firstNumberForTaskThreeTwo, secondNumberForTaskThreeTwo)}");
                break;
            default:
                Console.WriteLine("No such action.");
                break;
        }
    }
}