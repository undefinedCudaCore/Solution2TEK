using TaskNo32;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine();
        Console.WriteLine("Part No. 1");
        Console.WriteLine();

        Console.Write("Enter User name: ");
        string userName = Console.ReadLine();

        User userPhrase = new User();

        Console.WriteLine(userPhrase.UserName(userName));
    }
}