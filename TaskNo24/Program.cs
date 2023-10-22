internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine();
        Console.WriteLine("Part No. 1");
        Console.WriteLine();

        Console.Write("Įveskite kiek duomenų norite įvesti į masyvą: ");

        int masyvoIlgis = Convert.ToInt32((string)Console.ReadLine());

        int[] sums = new int[masyvoIlgis + 1];

        Console.WriteLine(masyvoIlgis);
        for (int i = 1; i <= masyvoIlgis; i++)
        {
            Console.WriteLine($"Įveskite skaičių nr. {i}");
            sums[i] = Convert.ToInt32(Console.ReadLine());
        }

        int suma1 = 0;
        int suma2 = 0;

        for (int i = 0; i < sums.Length; i++)
        {
            if (i % 2 == 0)
            {
                suma1 += sums[i];
            }
            if (i % 2 != 0)
            {
                suma2 += sums[i];
            }
        }

        if (suma1 != 0)
        {
            Console.WriteLine($"{suma1} – kai masyvo elementas yra lyginis skaičius.");
        }
        if (suma2 != 0)
        {
            Console.WriteLine($"{suma2} – kai masyvo indeksas nėra lyginis skaičius");
        }
    }
}