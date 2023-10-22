internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine();
        Console.WriteLine("Part No. 1");
        Console.WriteLine();

        Console.WriteLine("Enter first number:");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        Suma(firstNumber, secondNumber);
        Skirtumas(firstNumber, secondNumber);
        Sandauga(firstNumber, secondNumber);
        Dalmuo(firstNumber, secondNumber);
    }

    private static void Suma(int a, int b)
    {
        Console.WriteLine($"{a} + {b} = {a + b}");
    }
    private static void Skirtumas(int a, int b)
    {
        Console.WriteLine($"{a} - {b} = {a - b}");

    }
    private static void Sandauga(int a, int b)
    {
        Console.WriteLine($"{a} * {b} = {a * b}");

    }
    private static void Dalmuo(double a, double b)
    {
        Console.WriteLine($"{a} / {b} = {Math.Round(a / b, 2)}");

    }
}