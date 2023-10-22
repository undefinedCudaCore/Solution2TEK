internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine();
        Console.WriteLine("Part No. 1");
        Console.WriteLine();

        FormatuotasTEkstas();
    }

    private static void FormatuotasTEkstas()
    {
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32((string)Console.ReadLine());

        Console.WriteLine("Enter your hobby:");
        string hobby = Console.ReadLine();

        Console.WriteLine($"Hello {name}({age} years old). Your hobby is {hobby}.");
    } 
}