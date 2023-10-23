using TaskNo34;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine();
        Console.WriteLine("Part No. 1");
        Console.WriteLine();

        Console.WriteLine("ENTER first number: ");
        int firstNumberForTaskThreeFour = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("ENTER second number: ");
        int secondNumberForTaskThreeFour = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Select an action from list:");
        Console.WriteLine("1 - Multiplication of two numbers.");
        Console.WriteLine("2 - Division of two numbers.");

        try
        {
            int selection = Convert.ToInt32(Console.ReadLine());
            Calculation calculation = new Calculation();
            if(selection == 1)
            {
                Console.WriteLine($"Answer is {calculation.Daugyba(firstNumberForTaskThreeFour, secondNumberForTaskThreeFour)}.");
            } 
            else if (selection == 2)
            {
                Console.WriteLine($"Answer is {calculation.Dalyba(firstNumberForTaskThreeFour, secondNumberForTaskThreeFour)}.");
            }
            else
            {
                Console.WriteLine("No such action.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("No such action.");
        }
    }
}