internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine();
        Console.WriteLine("Task No. 20");
        Console.WriteLine();

        Console.WriteLine("Įveskite iš konsolės 2 skaičius (stataus trikampio statinių ilgius).");
        Console.WriteLine();

        Console.Write("1 skaičius: ");

        double pirmasSkaicius = Convert.ToInt32((string)Console.ReadLine());

        Console.Write("2 skaičius: ");

        double antrasSkaicius = Convert.ToDouble((string)Console.ReadLine());

        pirmasSkaicius = Math.Pow(pirmasSkaicius, 2);
        antrasSkaicius = Math.Pow(antrasSkaicius, 2);

        double c = Math.Sqrt(pirmasSkaicius + antrasSkaicius);

        c = Math.Round(c, 2);

        Console.WriteLine($"Įžambinės dydis yra {c}.");

    }
}