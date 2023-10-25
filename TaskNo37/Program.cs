using TaskNo37;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        List<int> augimas1 = new List<int>() { 5, 6, 9, 7, 8, 9 };

        Salis salis = new Salis("Lietuva", "Nauseda");
        salis.Plotas = 14.2;
        salis.GyventojųSkaicius = 53265;
        salis.VidutinisAtlyginimas = 500.25;
        salis.Augimas = augimas1;

        salis.isvestiSaliesInfo();
        Console.WriteLine();

        List<int> augimasEstijoje = new List<int>() { 8, 9, 56, 26, 5 };

        Estija estija = new Estija();
        estija.Pavadinimas = "Estija";
        estija.Prezidentas = "Estijos prezidentas";
        estija.Plotas = 1458956;
        estija.GyventojųSkaicius = 53265;
        estija.VidutinisAtlyginimas = 500.25;
        estija.Augimas = augimasEstijoje;

        estija.isvestiSaliesInfo();
        Console.WriteLine();

        List<int> augimasLenkijoje = new List<int>() { 88, 99, 4564, 4, 55 };

        Estija lenkija = new Estija();
        lenkija.Pavadinimas = "Lenkija";
        lenkija.Prezidentas = "Lenkijos prezidentas";
        lenkija.Plotas = 568978;
        lenkija.GyventojųSkaicius = 55548896;
        lenkija.VidutinisAtlyginimas = 1500.25;
        lenkija.Augimas = augimasLenkijoje;

        lenkija.isvestiSaliesInfo();
        Console.WriteLine();

        List<int> augimasBaltarusijoje = new List<int>() { 88, 99, 4564, 4, 55 };

        Estija baltarusija = new Estija();
        baltarusija.Pavadinimas = "Baltarusija";
        baltarusija.Prezidentas = "Baltarusijos prezidentas";
        baltarusija.Plotas = 5568978;
        baltarusija.GyventojųSkaicius = 20;
        baltarusija.VidutinisAtlyginimas = 100.25;
        baltarusija.Augimas = augimasBaltarusijoje;

        baltarusija.isvestiSaliesInfo();
        Console.WriteLine();

        List<int> augimasLatvijoje = new List<int>() { 83, 199, 24564, 44, 855 };

        Estija latvija = new Estija();
        latvija.Pavadinimas = "Latvija";
        latvija.Prezidentas = "Latvijos prezidentas";
        latvija.Plotas = 538;
        latvija.GyventojųSkaicius = 29990;
        latvija.VidutinisAtlyginimas = 15800.5214;
        latvija.Augimas = augimasLatvijoje;

        latvija.isvestiSaliesInfo();
        Console.WriteLine();
        int enterNumber = Convert.ToInt32(Console.ReadLine());
        salis.showElementFromArray(enterNumber);
    }
}