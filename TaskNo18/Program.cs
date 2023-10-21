internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine();
        Console.WriteLine("Task No. 18");
        Console.WriteLine();

        int workHours = 18;

        Console.WriteLine("Įveskite kiek darbuotojas gali iškepti kepalų per valandą: ");
        int kepalaiPerVal = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Įveskite kiek darbuotojų turi kepykla: ");
        int kepyklosDarbuotojuSkaicius = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Įveskite vieno kepalo savikainą: ");
        double kepaloSavikaina = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("Įveskite vieno kepalo pardavimo kainą: ");
        double kepaloPardavimoKaina = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("Įveskite kiek kepykla turi tą dieną iškepti kepalų (užsakymai): ");
        int uzsakymai = Convert.ToInt32(Console.ReadLine());

        int iskeptiKepalaiPerDiena = kepyklosDarbuotojuSkaicius * kepalaiPerVal * workHours;
        Console.WriteLine();
        Console.WriteLine($"Per dieną kepykla sugeba iškepti {iskeptiKepalaiPerDiena} duonos kepalų.");

        int arSpesIskepri = iskeptiKepalaiPerDiena - uzsakymai;
        string arSpes = "";
        if (arSpesIskepri >= 0)
        {
            arSpes = "Taip";
        } else
        {
            arSpes = "Ne";
        }

        Console.WriteLine();
        Console.WriteLine($"Ar kepykla spės iškepti visus tos dienos užsakymus? {arSpes}");

        int nespejo = 0;
        if (arSpesIskepri < 0)
        {
            nespejo = arSpesIskepri * -1;
        }

        Console.WriteLine();
        Console.WriteLine($"Liko iškepti {nespejo} kepalų.");

        double pelnas = 0;
        if (arSpes == "Taip")
        {
            pelnas = (kepaloPardavimoKaina * uzsakymai) - (kepaloSavikaina * uzsakymai);
        }
        else if (arSpes == "Ne")
        {
            pelnas = (kepaloPardavimoKaina * iskeptiKepalaiPerDiena) - (kepaloSavikaina * iskeptiKepalaiPerDiena);            
        }

        Console.WriteLine();
        Console.WriteLine($"Kepykla uždirbo pelno iš visų tą dieną iškeptų duonos kepalų {pelnas} Eur.");
    }
}