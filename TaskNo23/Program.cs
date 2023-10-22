internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine();
        Console.WriteLine("Task No. 23");
        Console.WriteLine();

        double vidutinisDegaluSunaudojimas = 11.2;

        double[] nuvaziuotiKilometrai = new double[] { 22, 653, 2015, 13, 79, 123, 521, 3674, 5 };

        Console.WriteLine($"Trumpiausias nuvažiuotas atstumas yra {nuvaziuotiKilometrai.Min()}.");
        Console.WriteLine();

        Console.WriteLine($"Ilgiausias nuvažiuotas atstumas yra {nuvaziuotiKilometrai.Max()}.");
        Console.WriteLine();

        double kuras = 0;
        double[] autoSunaudojoKuro = new double[nuvaziuotiKilometrai.Length];

        for (int i = 0; i < nuvaziuotiKilometrai.Length; i++)
        {
            kuras += nuvaziuotiKilometrai[i] / 100 * vidutinisDegaluSunaudojimas;
        }
        Console.WriteLine($"{kuras}l sunaudojo automobilis");
    }
}