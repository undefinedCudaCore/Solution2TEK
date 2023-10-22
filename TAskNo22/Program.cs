internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine();
        Console.WriteLine("Part No. 1");
        Console.WriteLine();

        int[] weekTemperature = new int[] { 10, -8, 9, 5, -12, 20, -20 };

        Console.WriteLine($"Min. temperature is {weekTemperature.Min()}.");
        Console.WriteLine();
        Console.WriteLine($"Max. temperature is {weekTemperature.Max()}.");
        Console.WriteLine();

        double averageTemp = 0;
        for (int i = 0; i < weekTemperature.Length; i++)
        {
            averageTemp += weekTemperature[i];
        }
        Console.WriteLine($"Average temp. is {Math.Round(averageTemp / 7, 2)}.");

        Console.WriteLine();
        Console.WriteLine("Part No. 2");
        Console.WriteLine();

        int[] studentGrade = new int[] { 5, 8, 9, 5, 8, 4, 3, 2, 1, 9 };

        Console.WriteLine($"Griausias pažymis: {studentGrade.Max()}");

        int geriausiasPazymis = 0;

        for (int i = 0; i < studentGrade.Length; i++)
        {
            if (studentGrade[i] == 10)
            {
                geriausiasPazymis++;
            }
        }
        Console.WriteLine($"{geriausiasPazymis} mokinių yra gavę dešimtukus");

        int neigiamasPazymis = 0;

        for (int i = 0; i < studentGrade.Length; i++)
        {
            if (studentGrade[i] < 4)
            {
                neigiamasPazymis++;
            }
        }
        Console.WriteLine($"{neigiamasPazymis} mokinių yra gavę neigiamą pažymį (žemiau nei 4)");

        double pazymiuVidurkis = 0;

        for (int i = 0; i < studentGrade.Length; i++)
        {
            pazymiuVidurkis += studentGrade[i];
        }
        Console.WriteLine($"Pažymių vidurkis yra {Math.Round(pazymiuVidurkis / studentGrade.Length, 0)}.");
    }
}