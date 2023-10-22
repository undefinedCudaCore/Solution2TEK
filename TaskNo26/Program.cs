internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine();
        Console.WriteLine("Part No. 1");
        Console.WriteLine();

        List<int> atsitiktinisSkaiciuSarasas = new List<int>();
        Random rnd = new Random();

        for (int i = 0; i < rnd.Next(1, 10); i++)
        {
            atsitiktinisSkaiciuSarasas.Add(rnd.Next(1, 100));
        }

        int vidurkis = 0;
        foreach (var item in atsitiktinisSkaiciuSarasas)
        {
            vidurkis += item;
        }

        vidurkis = vidurkis / atsitiktinisSkaiciuSarasas.Count;

        Console.WriteLine($"Mažiausią skaičių {atsitiktinisSkaiciuSarasas.Min()}");
        Console.WriteLine($"Didžiausią skaičių {atsitiktinisSkaiciuSarasas.Max()}");
        Console.WriteLine($"Vidurkis {vidurkis}");

        int count = 0;
        int lyginiuSkaiciuSuma = 0;

        foreach (int skaicius in atsitiktinisSkaiciuSarasas)
        {
            if (skaicius < vidurkis)
            {
                count++;
            }
            if (skaicius % 2 == 0)
            {
                lyginiuSkaiciuSuma += skaicius;
            }
        }

        Console.WriteLine($"{count} skaičių yra žemesni už vidurkį");
        Console.WriteLine($"Lyginių skaičių sumą {lyginiuSkaiciuSuma}");

        Console.WriteLine();
        Console.WriteLine("Part No. 2");
        Console.WriteLine();

        Console.WriteLine("įveskite kiek studentų pažymių norite suvesti į sąrašą.");

        int pazSarasas = Convert.ToInt32( (string)Console.ReadLine() );

        List<int> listGrade = new List<int>();

        for (int i = 1; i <= pazSarasas; i++)
        {
            Console.WriteLine($"Iveskite {i} pazymi:");
            int addGrade = Convert.ToInt32((string)Console.ReadLine());
            listGrade.Add(addGrade);
        }

        Console.WriteLine($"Didžiausias pažymis - {listGrade.Max()}");
        Console.WriteLine($"Mažiausias pažymis - {listGrade.Min()}");

        double vidurkisFromList = 0;

        foreach (double vidPazFromList in listGrade)
        {
            vidurkisFromList += vidPazFromList;
        }

        vidurkisFromList = vidurkisFromList / listGrade.Count;

        Console.WriteLine($"Vidurkis - {Math.Round(vidurkisFromList, 2)}");
    }
}