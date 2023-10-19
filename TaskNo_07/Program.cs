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

        Console.WriteLine($"Jūsų varda {vardas}, o amžius {amzius}.");

        Console.WriteLine("Nr. 2");
        Console.WriteLine();

        Console.WriteLine("Įveskite simbolį:");
        string simbolis = Console.ReadLine();

        int convertedSimbolis = Convert.ToInt64(simbolis);

        int valueForWhileLoop = convertedSimbolis.MinValue;
        while (true)
        {
            
        }
    }
}