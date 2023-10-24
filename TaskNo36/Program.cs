using TaskNo36;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        // Create first student and his information

        List<int> pazymiai1 = new List<int>() { 5, 2, 3, 8, 10 };
        Mokinys mokinys = new Mokinys("a", "b", 2, 2, pazymiai1);

        mokinys.isvestiInfoApieMokini();

        // Create second student and his information

        List<int> pazymiai2 = new List<int>() { 5, 7, 10, 8, 10 };
        Mokinys mokinysTomas = new Mokinys("Tomas", "Klaukys", 15, 9, pazymiai1);

        mokinysTomas.isvestiInfoApieMokini();

        // Create third student and his information

        List<int> pazymiai3 = new List<int>() { 10, 10, 10, 9, 10 };
        Mokinys mokinysEmilia = new Mokinys("Emilia", "Clarke", 16, 10, pazymiai1);

        mokinysEmilia.isvestiInfoApieMokini();


        // Create fourth student and his information

        List<int> pazymiai4 = new List<int>() { 10, 10, 10, 9, 10 };
        Mokinys mokinysTadas = new Mokinys("Tadas", "Blinda", 7, 1, pazymiai1);

        mokinysTadas.isvestiInfoApieMokini();

        //Show how much yers of study left for each student
        mokinys.uzKiekMetuBaigsMokykla();
        mokinysTomas.uzKiekMetuBaigsMokykla();
        mokinysEmilia.uzKiekMetuBaigsMokykla();
        mokinysTadas.uzKiekMetuBaigsMokykla();

    }
}