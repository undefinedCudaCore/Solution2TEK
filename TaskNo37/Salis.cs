using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskNo37
{
    internal class Salis
    {
        public string Pavadinimas { get; set; }
        public string Prezidentas { get; set; }
        public double Plotas { get; set; }
        public int GyventojųSkaicius { get; set; }
        public double VidutinisAtlyginimas { get; set; }

        public List<int> Augimas = new List<int>();

        public Salis()  
        {

        }
        public Salis(string pavadinimas, string prezidentas)
        {
            Pavadinimas = pavadinimas;
            Prezidentas = prezidentas;
        }
        public Salis(double plotas, int gyventojųSkaicius)
        {
            Plotas = plotas;
            GyventojųSkaicius = gyventojųSkaicius;
        }
        public Salis(double vidutinisAtlyginimas)
        {
            VidutinisAtlyginimas = vidutinisAtlyginimas;
        }
        public Salis(List<int> augimas)
        {
            Augimas = augimas;
        }

        public void isvestiSaliesInfo()
        {
            Console.WriteLine($"Šalies info:");
            Console.WriteLine($"Pavadinimas: {Pavadinimas};");
            Console.WriteLine($"Prezidetnas: {Prezidentas};");
            Console.WriteLine($"Plotas: {Plotas};");
            Console.WriteLine($"Gyventojų skaicius: {GyventojųSkaicius};");
            Console.WriteLine($"Vidutinis atlyginimas: {VidutinisAtlyginimas};");

            Console.WriteLine($"Gimstamumo augimas:");
            for (int i = 0; i < Augimas.Count; i++)
            {
                Console.WriteLine($"202{i} metais gime {Augimas[i]}");
            }
        }
    }
}
