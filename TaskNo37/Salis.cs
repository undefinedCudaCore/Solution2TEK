using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskNo37
{
    internal class Salis
    {
        public string Pavadinimas;
        public string Prezidentas;
        public double Plotas;
        public int GyventojųSkaicius;
        public double VidutinisAtlyginimas;
        public List<int> Augimas = new List<int>();

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

    }
}
