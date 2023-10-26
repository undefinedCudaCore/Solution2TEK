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

        public int[] values = {55, 555, 35, 478};
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
        public void showElementFromArray(int arrayElementPosition)
        {
            int showValue1 = 0;
            int showValue2 = 0;
            for (int i = 0; i < values.Length; i++)
            {
                showValue1 = values[arrayElementPosition];
                showValue2 = values[1 + arrayElementPosition];
            }
            Console.WriteLine(showValue1);
            if (showValue1 > showValue2)
            {
                Console.WriteLine(showValue2);
            }
        }
    }
}
