internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine();
        Console.WriteLine("Part No. 1");
        Console.WriteLine();

        int count = 0;
        for (int i = 1; i < 1000; i++)
        {
            if (i % 16 == 0)
            {
                count++;
            }
        }
        Console.WriteLine(count);

        Console.WriteLine();
        Console.WriteLine("Part No. 2");
        Console.WriteLine();

        Console.WriteLine("Enter positive number: ");

        int getPositiveNumberForTaskNoNinetten = Convert.ToInt32(Console.ReadLine());
        double showPositiveNumberForTaskNoNinettenAfterMathPow = 0;
        int j = 1;

        while (showPositiveNumberForTaskNoNinettenAfterMathPow < 1500)
        {

            showPositiveNumberForTaskNoNinettenAfterMathPow = Math.Pow(getPositiveNumberForTaskNoNinetten, j);
            j++;

            if (showPositiveNumberForTaskNoNinettenAfterMathPow <= 1500)
            {                
                Console.WriteLine(showPositiveNumberForTaskNoNinettenAfterMathPow);
            }
        }
    }
}