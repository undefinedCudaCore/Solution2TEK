using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskNo37
{
    internal class Estija : Salis
    {
        public Estija()
        {
        }
        public Estija(double vidutinisAtlyginimas) : base(vidutinisAtlyginimas)
        {
            VidutinisAtlyginimas = vidutinisAtlyginimas;
        }

        public Estija(List<int> augimas) : base(augimas)
        {
            Augimas = augimas;
        }

        public Estija(string pavadinimas, string prezidentas) : base(pavadinimas, prezidentas)
        {
            Pavadinimas = pavadinimas;
            Prezidentas = prezidentas;
        }

        public Estija(double plotas, int gyventojųSkaicius) : base(plotas, gyventojųSkaicius)
        {
            Plotas = plotas;
            GyventojųSkaicius = gyventojųSkaicius;
        }
    }
}
