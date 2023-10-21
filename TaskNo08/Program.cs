internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine("Užduotis Nr. 1");
        Console.WriteLine();

        Console.WriteLine("Įveskite betkokį skaičių: ");

        var ivestasSkaicius = Console.ReadLine();
        int konvertuotasIvestasSkaicius = Convert.ToInt32(ivestasSkaicius);

        for (int i = 1; i <= 5; i++)
        {
            int multiplication = konvertuotasIvestasSkaicius * i;
            Console.WriteLine($"{konvertuotasIvestasSkaicius} * {i} = {multiplication}");
        }

        Console.WriteLine();
        Console.WriteLine("Užduotis Nr. 2");
        Console.WriteLine();

        Console.WriteLine("Įveskite tris skaičius per kablelį: ");

        var ivestiSkaiciaiVidurkiui = Console.ReadLine();

        List<int> sarasas = new List<int>();
        sarasas = ivestiSkaiciaiVidurkiui.Split(',').Select(int.Parse).ToList();
        
        double average = 0.0;
        for (int i = 0; i < sarasas.Count; i++)
        {
            Convert.ToDouble(sarasas[i]);
            average += sarasas.ElementAt(i);
        }
        average = average / sarasas.Count;
        average = Math.Round(average, 1);

        Console.WriteLine($"Jūsų įvestų skaičių vidurkis yra lygus {average}");

        Console.WriteLine();
        Console.WriteLine("Užduotis Nr. 3");
        Console.WriteLine();

        Console.WriteLine("Įveskite tris skaičius per kablelį: ");

        var ivestiSkaiciaiVidurkiuiDu = Console.ReadLine();

        List<int> sarasasDu = new List<int>();
        sarasasDu = ivestiSkaiciaiVidurkiuiDu.Split(',').Select(int.Parse).ToList();

        Console.Write("Jūsų įvesti skaičiai: ");
        //foreach (var item in sarasasDu)
        //{
        //    Console.Write($" {item} ");
        //}

        for (int i = 0; i < sarasasDu.Count; i++)
        {
            Convert.ToDouble(sarasasDu[i]);
            Console.Write($" {sarasasDu[i]} ");
        }
            Console.WriteLine();
        for (int i = 0; i < sarasasDu.Count; i++)
        {
            Console.WriteLine($"Įvesto skaičiaus {sarasasDu[i]} kvadratas: {Math.Pow(sarasasDu[i], 2)} ");
            Console.WriteLine($"Įvestas skaičius 3 laipsniu: {Math.Pow(sarasasDu[i], 3)} ");
            double padalintasIsDvieju = Convert.ToDouble(sarasasDu[i]);
            padalintasIsDvieju /= 2;
            Console.WriteLine($"Įvesti skaičius {sarasasDu[i]} padalintas iš 2jų: {padalintasIsDvieju} ");
        }
    }
}