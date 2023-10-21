internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine();
        Console.WriteLine("Task No. 1");
        Console.WriteLine();

        Console.Write("Enter your age: ");

        string age = Console.ReadLine();
        int convertedAge = Convert.ToInt32(age);
        
        if (convertedAge >= 18)
        {
            Console.WriteLine("You can vote!");
        }
        else
        {
            Console.WriteLine("Don't vote, go home!");
        }

        Console.WriteLine();
        Console.WriteLine("Task No. 2");
        Console.WriteLine();

        Console.Write("Enter number: ");

        string number = Console.ReadLine();
        int convertedNumber = Convert.ToInt32(number);

        if (convertedNumber < 0)
        { 
            Console.WriteLine("Why you number is negative?! ☔"); 
        } 
        if (convertedNumber > 0)
        {           
            Console.WriteLine("Congrats! ☝"); 
        }
       if ((convertedNumber % 2) == 0)
        {
            Console.WriteLine("taip, skaičius yra lyginis");
        }
        if ((convertedNumber % 4) == 0)
        {
            Console.WriteLine("taip, dalinasi iš 4");
        }
        if (convertedNumber > 10)
        {
            Console.WriteLine("taip, skaičius yra didesnis už 10");
        }

        Console.WriteLine();
        Console.WriteLine("Task No. 3");
        Console.WriteLine();

        Console.WriteLine("Įveskite du skaičius per kablelį: ");

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

        if (average >= 5)
        {
            Console.WriteLine("Valio!!!");
        }
    }
}