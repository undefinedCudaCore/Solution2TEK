internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine();
        Console.WriteLine("Part No. 1");
        Console.WriteLine();

        Console.WriteLine(" įvesti 5 pažymius VIENOJE eilutėje atskiriant tarpu");
        string getPaz = Console.ReadLine();

        string[] didPaz = getPaz.Split(" ");
        Console.WriteLine(didPaz.Max());


        Console.WriteLine();
        Console.WriteLine("Part No. 2");
        Console.WriteLine();

        Console.WriteLine("įvesti 5 pažymius VIENOJE eilutėje atskiriant kableliu");

        string getMazPaz = Console.ReadLine();

        string[] mazPaz = getMazPaz.Split(",");
        Console.WriteLine(didPaz.Min());
        Console.ReadKey();
    }
}