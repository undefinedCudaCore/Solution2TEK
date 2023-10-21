internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine();
        Console.WriteLine("Part No. 1");
        Console.WriteLine();

        for (int i = 0; i <=10; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine();
        Console.WriteLine("Part No. 2");
        Console.WriteLine();

        for (int i = 0; i <= 15; i++)
        {
            Console.Write(++i + " ");
        }

        Console.WriteLine();
        Console.WriteLine("Part No. 3");
        Console.WriteLine();

        for (int i = 1; i <=20; i++)
        {
            Console.Write($"[{++i}] ");
            i++;
        }

        Console.WriteLine();
        Console.WriteLine("Part No. 4");
        Console.WriteLine();

        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.ReadKey();
    }
}