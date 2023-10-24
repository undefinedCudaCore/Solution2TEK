using TaskNo36;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        List<int> pazymiai1 = new List<int>() { 5, 2, 3, 8, 10 };
        Mokinys mokinys = new Mokinys("a", "b", 2, 2, pazymiai1);

        mokinys.isvestiInfoApieMokini();

        List<int> pazymiai2 = new List<int>() { 5, 7, 10, 8, 10 };
        Mokinys mokinysTomas = new Mokinys("Tomas", "Klaukys", 15, 9, pazymiai1);

        mokinysTomas.isvestiInfoApieMokini();

    }
}