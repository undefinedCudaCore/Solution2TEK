internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine();
        Console.WriteLine("Part No. 1");
        Console.WriteLine();

        List<string> zodis = new List<string>();
        zodis.Add("suo");
        zodis.Add("kate");
        zodis.Add("multivanas");

        foreach (string zodisSarase in zodis)
        {
            Console.WriteLine($"Sudarytas iš {zodisSarase.Length} raidzių.");
            
        }
    }
}