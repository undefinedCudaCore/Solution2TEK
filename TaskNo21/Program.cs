internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine();
        Console.WriteLine("Part No. 1");
        Console.WriteLine();

        int[] studentuPazymiai = {1, 2, 3, 4, 5, 6, 7, 8, 9, };

        string[] autoMarkes = new string[5];
        autoMarkes[0] = "Audi";
        autoMarkes[1] = "Honda";
        autoMarkes[2] = "Toyota";
        autoMarkes[3] = "Subaru";
        autoMarkes[4] = "Dodge";

        Console.WriteLine();

        foreach (int pazymiai in studentuPazymiai)
        {
            Console.WriteLine(pazymiai);
        }

        Console.WriteLine();

        foreach (string markes in autoMarkes)
        {
            Console.WriteLine(markes);
        }

        Console.WriteLine();
        Console.WriteLine("Part No. 2");
        Console.WriteLine();

        Console.WriteLine(studentuPazymiai.First());
        Console.WriteLine();
        Console.WriteLine(autoMarkes[autoMarkes.Length - 1]);
    }
}