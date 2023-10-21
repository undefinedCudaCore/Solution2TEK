internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine();
        Console.WriteLine("Part No. 1");
        Console.WriteLine();

        Console.Write("Enter first number: ");

        string getFirstNumber = Console.ReadLine();
        int convertedFirstNumber = Convert.ToInt32(getFirstNumber);

        Console.Write("Enter second number: ");

        string getSecondNumber = Console.ReadLine();
        int convertedSecondNumber = Convert.ToInt32(getSecondNumber);

        Console.Write("Enter third number: ");

        string getThirdNumber = Console.ReadLine();
        int convertedThirdNumber = Convert.ToInt32(getThirdNumber);

        switch (convertedFirstNumber)
        {
            case 1:
                int sum = convertedFirstNumber + convertedSecondNumber + convertedThirdNumber;
                Console.WriteLine(sum);
                break;

            case 2:
                int substract = convertedFirstNumber - convertedThirdNumber;
                Console.WriteLine(substract);
                break;

            case 3:
                int multiplication = convertedSecondNumber * convertedThirdNumber;
                Console.WriteLine(multiplication);
                break;

            default:
                Console.WriteLine("You must enter number from 1 to 3.");
                break;
        }

        Console.WriteLine();
        Console.WriteLine("Part No. 2");
        Console.WriteLine();

        Console.Write("Enter the type of animal: ");

        string getTypeOfAnimal = Console.ReadLine();

        switch (getTypeOfAnimal)
        {
            case "dog":
                Console.WriteLine("1. ar įvestas gyvūnas yra šuo");
                break;

            case "cat":
                Console.WriteLine("2. ar įvestas gyvūnas yra katė");
                break;

            case "hamster":
                Console.WriteLine("3. ar įvestas gyvūnas yra žiurkėnas.");
                break;

            default:
                Console.WriteLine("You entered wrong type of animal");
                break;
        }
        Console.ReadKey();
    }
}