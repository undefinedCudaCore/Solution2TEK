using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("1 užduotis");
        Console.WriteLine();
        Console.WriteLine("Įveskite pirmąjį skaičių:");

        string firstNumber = Console.ReadLine();

        Console.WriteLine("Įveskite antrąjį skaičių:");

        string secondNumber = Console.ReadLine();

        int convertedFirstNumber = Convert.ToInt32(firstNumber);
        int convertedSecondNumber = Convert.ToInt32(secondNumber);
        int addition = convertedFirstNumber + convertedSecondNumber;
        int subtraction = convertedFirstNumber - convertedSecondNumber;
        int multiplication = convertedFirstNumber * convertedSecondNumber;
        int division = convertedFirstNumber / convertedSecondNumber;

        Console.WriteLine($"Įvestų skaičių suma: {firstNumber} + {secondNumber} = {addition}");
        Console.WriteLine($"Įvestų skaičių skirtumas: {firstNumber} - {secondNumber} = {subtraction}");
        Console.WriteLine($"Įvestų skaičių sandauga: {firstNumber} * {secondNumber} = {multiplication}");
        Console.WriteLine($"Įvestų skaičių dalmuo: {firstNumber} / {secondNumber} = {division}");

        Console.WriteLine();
        Console.WriteLine("2 užduotis");
        Console.WriteLine("Įveskite trečiąjį skaičių:");

        string thirdNumber = Console.ReadLine();
        double convertedThirdNumber = Convert.ToDouble(thirdNumber);
        double one = Math.Sqrt(convertedThirdNumber);
        double two = Math.Pow(convertedThirdNumber, 3);

        Console.WriteLine($"Įvesto skaičiaus kvadratinė reikšmė: {one}");
        Console.WriteLine($"Įvestas skaičiaus 3 laipsniu: {two}");

        Console.WriteLine();
        Console.WriteLine("3 užduotis");
        Console.WriteLine();

        int convertedThirdNumber2 = Convert.ToInt32(convertedThirdNumber);
        int multiplicationTwo = convertedFirstNumber * convertedSecondNumber * convertedThirdNumber2;


        Console.WriteLine($"3jų skaičių sandauga: {convertedFirstNumber} * {convertedSecondNumber} * {convertedThirdNumber2} = {multiplicationTwo}");

        Console.WriteLine();
        Console.WriteLine("4 užduotis");
        Console.WriteLine();

        double firstAnswer = -1 + 4 * 6;
        double secondAnswer = 14 + -4 * 6 / 11;
        double thirdAnswer = 2 + 15 / 6 * 1 - 7 % 2;

        Console.WriteLine($"Turite gauti: {firstAnswer}, {secondAnswer}, {thirdAnswer}");

        Console.WriteLine();
        Console.WriteLine("5 užduotis");
        Console.WriteLine();

        Console.WriteLine("Įveskite ketvirtąjį skaičių:");

        string fourthNumber = Console.ReadLine();
        int convertedFourthNumber = Convert.ToInt32(fourthNumber);

        for (int i = 0; i < 10; i++)
        {
            int multiplicationThree = convertedFourthNumber * i;
            Console.WriteLine($"{convertedFourthNumber} * {i} = {multiplicationThree}");
        }

        Console.WriteLine();
        Console.WriteLine("6 užduotis");
        Console.WriteLine();
        Console.WriteLine("Įveskite dviženklį skaičių:");

        string fifthNumber = Console.ReadLine();
        int convertedFifthNumber = Convert.ToInt32(fifthNumber);

        int firstNumberForMultiplication = convertedFifthNumber / 10;
        int secondNumberForMultiplication = convertedFifthNumber % 10;
        int multiplicationFour = firstNumberForMultiplication * secondNumberForMultiplication;

        Console.WriteLine($"Atsakymas: {firstNumberForMultiplication} * {secondNumberForMultiplication} = {multiplicationFour}");
    }
}