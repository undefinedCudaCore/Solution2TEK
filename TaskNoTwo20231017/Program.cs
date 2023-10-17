using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        string vardas = "Mantas";

        Console.WriteLine("Labas " + vardas);

        int amzius = 24;

        Console.WriteLine("Įvestas amžius: {0}", amzius);

        string marke = "Volksvagen";
        string modelis = "Passat CC";
        int metai = 2008;
        int rida = 200000;

        Console.WriteLine("Automobilio {0} {1} ({2} m.) rida - {3} km",marke, modelis, metai, rida);
    }
}