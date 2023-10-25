using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskNo37
{
    internal class Lenkija : Salis
    {
        public Lenkija()
        {
        }
        public Lenkija(double vidutinisAtlyginimas) : base(vidutinisAtlyginimas)
        {
            VidutinisAtlyginimas = vidutinisAtlyginimas;
             
        }

        public Lenkija(List<int> augimas) : base(augimas)
        {
            Augimas = augimas;
        }

        public Lenkija(string pavadinimas, string prezidentas) : base(pavadinimas, prezidentas)
        {
            Pavadinimas = pavadinimas;
            Prezidentas = prezidentas;
        }

        public Lenkija(double plotas, int gyventojųSkaicius) : base(plotas, gyventojųSkaicius)
        {
            Plotas = plotas;
            GyventojųSkaicius = gyventojųSkaicius;
        }
    }
}
