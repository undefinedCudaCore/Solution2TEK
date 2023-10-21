internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine();
        Console.WriteLine("Part No. 1");
        Console.WriteLine();

        Console.Write("Enter 3 digit number: ");

        string getNumber = Console.ReadLine();
        int convertedNumber = Convert.ToInt32(getNumber);

        int firstNumber = convertedNumber / 100;
        int secondNumber = convertedNumber / 10 % 10;
        int thirdNumber = convertedNumber % 100 % 10;

        Console.Write("The biggest number is ");
        Console.Write(Math.Max(Math.Max(firstNumber, secondNumber), thirdNumber));
        Console.Write(".");

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Part No. 2");
        Console.WriteLine();

        Console.WriteLine("Enter exam result:");

        string getExamResult = Console.ReadLine();
        int convertedExamResult =   Convert.ToInt32(getExamResult);

        if (convertedExamResult < 5)
        {
            Console.WriteLine("gautas rezultatas yra < 5");  
        }
        else if (convertedExamResult > 5 && convertedExamResult <= 8)
        {
            Console.WriteLine("gautas rezultatas yra [5-8]");
            if (convertedExamResult == 8)
            {
                Console.WriteLine("gautas rezultatas yra [8-10]");
            }
        }
        else if (convertedExamResult > 8 || convertedExamResult < 10)
        {
            Console.WriteLine("gautas rezultatas yra [8-10]");
        }

        Console.WriteLine();
        Console.WriteLine("Part No. 3");
        Console.WriteLine();

        Console.Write("Enter first number: ");
        
        string getFirstNumber = Console.ReadLine();
        int convertFirstNuber = Convert.ToInt32(getFirstNumber);

        Console.Write("Enter second number: ");

        string getSecondNumber = Console.ReadLine();
        int convertSecondNumber = Convert.ToInt32(getSecondNumber);

        if (convertFirstNuber > convertSecondNumber || convertFirstNuber == 0)
        {
            Console.WriteLine("1. ar pirmas skaičius yra didesnis už antrąjį, arba yra lygus 0;");
        }
        if (convertSecondNumber > convertFirstNuber || convertSecondNumber == 5)
        {
            Console.WriteLine("2. ar antras skaičius yra didesnis už pirmąjį, arba yra lygus 5;");
        }
        if (convertFirstNuber > convertSecondNumber && convertFirstNuber == 20)
        {
            Console.WriteLine("3. ar pirmas skaičius yra didesnis už antrąjį ir yra lygus 20;");
        }
        if (convertSecondNumber > convertFirstNuber && convertSecondNumber < 100)
        {
            Console.WriteLine("4. ar antras skaičius yra didesnis už pirmąjį ir yra mažesnis už 100.");
        }

        Console.ReadKey();
    }
}