internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine();
        Console.WriteLine("Part No. 1");
        Console.WriteLine();

        int sum = 0;

        for (int i = 0; i < 100; i++)
        {
            sum += i;
        }
        Console.WriteLine(sum);

        Console.WriteLine();
        Console.WriteLine("Part No. 2");
        Console.WriteLine();

        sum = 0;

        for (int i = 20; i < 40; i++)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }
        }
        Console.WriteLine(sum);

        Console.WriteLine();
        Console.WriteLine("Part No. 3");
        Console.WriteLine();

        sum = 0;

        for (int i = 30; i < 60; i++)
        {
            if (i % 2 != 0)
            {
                sum += i;
            }
        }
        Console.WriteLine(sum);

        Console.WriteLine();
        Console.WriteLine("Part No. 4");
        Console.WriteLine();

        sum = 0;

        for (int i = 0; i < 1000; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i;
            }
        }
        Console.WriteLine(sum);
        Console.ReadKey();
    }
}