using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskNo37
{
    internal class Latvija : Salis
    {
        public Latvija()
        {
        }
        public Latvija(double vidutinisAtlyginimas) : base(vidutinisAtlyginimas)
        {
            VidutinisAtlyginimas  = vidutinisAtlyginimas;
        }

        public Latvija(List<int> augimas) : base(augimas)
        {
            Augimas = augimas;
        }

        public Latvija(string pavadinimas, string prezidentas) : base(pavadinimas, prezidentas)
        {
            Pavadinimas = pavadinimas;
            Prezidentas = prezidentas;
        }

        public Latvija(double plotas, int gyventojųSkaicius) : base(plotas, gyventojųSkaicius)
        {
            Plotas = plotas;
            GyventojųSkaicius = gyventojųSkaicius;
        }
    }
}
