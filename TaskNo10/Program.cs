internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine("Enter number: ");

        var getNumber = Console.ReadLine();

        int convertedNumber = Convert.ToInt32(getNumber);
        double convertedNumberToDouble = Math.Pow(convertedNumber, 5);

        if (( convertedNumber % 2 ) == 0)
        {
            Console.WriteLine($"The number you entered is {getNumber} and the fifth power of the number is {convertedNumberToDouble}");
        } 
        else if ((convertedNumber % 4) != 0)
        {
            Console.WriteLine("Enter second number: ");

            var getSecondNumber = Console.ReadLine();

            int convertedSecondNumber = Convert.ToInt32(getSecondNumber);

            double sum = convertedSecondNumber + convertedNumber;
            double multiplication = convertedSecondNumber * convertedNumber;

            Console.WriteLine($"Sum of number {convertedNumber} and number {convertedSecondNumber} is {sum}");
            Console.WriteLine($"Multiplication of number {convertedNumber} and number {convertedSecondNumber} is {multiplication}");
        }
    }
}