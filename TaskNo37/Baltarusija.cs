using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskNo37
{
    internal class Baltarusija : Salis
    {
        public Baltarusija()
        {
        }
        public Baltarusija(double vidutinisAtlyginimas) : base(vidutinisAtlyginimas)
        {
            VidutinisAtlyginimas = vidutinisAtlyginimas;

        }

        public Baltarusija(List<int> augimas) : base(augimas)
        {
            Augimas = augimas;
        }

        public Baltarusija(string pavadinimas, string prezidentas) : base(pavadinimas, prezidentas)
        {
            Pavadinimas = pavadinimas;
            Prezidentas = prezidentas;
        }

        public Baltarusija(double plotas, int gyventojųSkaicius) : base(plotas, gyventojųSkaicius)
        {
            Plotas = plotas;
            GyventojųSkaicius = gyventojųSkaicius;
        }
    }
}
