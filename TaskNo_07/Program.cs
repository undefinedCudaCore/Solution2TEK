internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine("Nr. 1");
        Console.WriteLine();


        Console.WriteLine("Įveskite savo vardą:");
        string vardas = Console.ReadLine();

        Console.WriteLine("Įveskite savo amžių:");
        string amzius = Console.ReadLine();

        Console.WriteLine($"Jūsų vardas {vardas}, o amžius {amzius}.");

        Console.WriteLine("Nr. 2");
        Console.WriteLine();

        Console.WriteLine("Įveskite simbolį:");
        var simbolis = Console.ReadLine();

        char convertedSimbolis = Convert.ToChar(simbolis);

        Console.WriteLine($"Jūsų įvestas simbolis yra '{convertedSimbolis}' .");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{convertedSimbolis}");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("Nr. 3");
        Console.WriteLine();

        Console.WriteLine("Įveskite skaičių:");

        string skaiciusKvadratui = Console.ReadLine();

        int konvertuotasSkaiciusKvadratui = Convert.ToInt32(skaiciusKvadratui);

        double skaiciusKvadratu = Math.Pow(konvertuotasSkaiciusKvadratui, 2);

        Console.WriteLine($"Jūsų skaičius kvadratu: {skaiciusKvadratu}.");

        Console.WriteLine();
        Console.WriteLine("Nr. 4");
        Console.WriteLine();
        Console.WriteLine("Įveskite tris skaičius -> įveskite pirmą skaičių ir spauskite'Enter':");

        string pirmasisSkaicius = Console.ReadLine();

        Console.WriteLine("Įveskite antrą skaičių ir spauskite'Enter':");

        string antrasisSkaicius = Console.ReadLine();

        Console.WriteLine("Įveskite trečią skaičių ir spauskite'Enter':");

        string treciasisSkaicius = Console.ReadLine();

        int sum = Convert.ToInt32(pirmasisSkaicius)
            + Convert.ToInt32(antrasisSkaicius)
            + Convert.ToInt32(treciasisSkaicius);

        Console.WriteLine($"{pirmasisSkaicius} + {antrasisSkaicius} + {treciasisSkaicius} = {sum}");
    }
}