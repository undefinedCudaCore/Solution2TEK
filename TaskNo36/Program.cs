using TaskNo36;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        // Create first student and his information

        List<int> pazymiai1 = new List<int>() { 5, 2, 3, 8, 7 };
        Mokinys mokinys = new Mokinys("a", "b", 2, 2, pazymiai1);

        mokinys.isvestiInfoApieMokini();

        // Create second student and his information

        List<int> pazymiai2 = new List<int>() { 5, 7, 10, 8, 10 };
        Mokinys mokinysTomas = new Mokinys("Tomas", "Klaukys", 15, 9, pazymiai2);

        mokinysTomas.isvestiInfoApieMokini();

        // Create third student and his information

        List<int> pazymiai3 = new List<int>() { 10, 10, 8, 9, 10 };
        Mokinys mokinysEmilia = new Mokinys("Emilia", "Clarke", 16, 10, pazymiai3);

        mokinysEmilia.isvestiInfoApieMokini();


        // Create fourth student and his information

        List<int> pazymiai4 = new List<int>() { 1, 1, 1, 5, 1 };
        Mokinys mokinysTadas = new Mokinys("Tadas", "Blinda", 7, 1, pazymiai4);

        mokinysTadas.isvestiInfoApieMokini();

        //Show how much yers of study left for each student
        mokinys.uzKiekMetuBaigsMokykla();
        mokinysTomas.uzKiekMetuBaigsMokykla();
        mokinysEmilia.uzKiekMetuBaigsMokykla();
        mokinysTadas.uzKiekMetuBaigsMokykla();

        //Show student best and worst grade
        Console.WriteLine();

        Console.WriteLine($"Geriausias mokinio {mokinys.vardas} pažimys yra {mokinys.pazymiuSarasas.Max()}, o blogiausias yra {mokinys.pazymiuSarasas.Min()}");
        Console.WriteLine($"Geriausias mokinio {mokinysEmilia.vardas} pažimys yra {mokinysEmilia.pazymiuSarasas.Max()}, o blogiausias yra {mokinysEmilia.pazymiuSarasas.Min()}");
        Console.WriteLine($"Geriausias mokinio {mokinysTadas.vardas} pažimys yra {mokinysTadas.pazymiuSarasas.Max()}, o blogiausias yra {mokinysTadas.pazymiuSarasas.Min()}");
        Console.WriteLine($"Geriausias mokinio {mokinysTomas.vardas} pažimys yra {mokinysTomas.pazymiuSarasas.Max()}, o blogiausias yra {mokinysTomas.pazymiuSarasas.Min()}");


    }
}