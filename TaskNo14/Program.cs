internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine("1 - stacionarus kompiuteris");
        Console.WriteLine("2 - nešiojamas kompiuteris");
        Console.WriteLine("3 - planšetė");

        Console.Write("Enter the selection number: ");

        string getSelectionNumber = Console.ReadLine();
        int convertSelectionNumber = Convert.ToInt32(getSelectionNumber);

        switch (convertSelectionNumber)
        {
            case 1:
                Console.WriteLine("stacionariu kompiuteriu galite naudotis tik namuose arba darbo vietoje\r\n");
                break;
            case 2:
                Console.WriteLine("nešiojamuoju kompiuteriu galite naudotis visur");
                break;
            case 3:
                Console.WriteLine("planšete galite naudotis visur");
                break;
            default:
                Console.WriteLine("tokio pasirinkimo nėra");
                break;
        }
        Console.ReadKey();
    }
}