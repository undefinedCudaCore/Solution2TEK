using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        string marke = "Honda";
        string modelis = "Accord";
        int metai = 2015;
        int rida = 356889;

        Console.WriteLine("Automobilio {0} {1} ({2} m.) rida - {3} km", marke, modelis, metai, rida);

        Console.WriteLine($"Automobilio {marke} {modelis} ({++metai} m.) rida - {rida+52364} km");

    }
}