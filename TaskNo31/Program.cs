using TaskNo31;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine();
        Console.WriteLine("Part No. 1");
        Console.WriteLine();

        int one = 1; int two = 2; int three = 3;

        Metodai suma = new Metodai();
        Console.WriteLine(suma.SumosFunkcija(one, two, three));

        Metodai dalmuo = new Metodai();
        Console.WriteLine(dalmuo.DalmensFunkcija(two, three));
    }
}