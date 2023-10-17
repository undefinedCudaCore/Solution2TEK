using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter squere length:");

        string getValue = Console.ReadLine();

        int n = int.Parse(getValue);

        for (int row = 1; row <= n; row++)
        {
            for (int col = 1; col <= n; col++)
            {
                if (row == 1 || row == n)
                {
                    Console.Write("*");
                }
                else
                {
                    if (col == 1 || col == n)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}