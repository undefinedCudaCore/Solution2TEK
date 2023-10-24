using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskNo36
{
    internal class Tadas : Mokinys
    {
        public Tadas(string vardas, string pavarde, int amzius, int klase, List<int> pazymiuSarasas) : base(vardas, pavarde, amzius, klase, pazymiuSarasas)
        {
            this.vardas = vardas;
            this.pavarde = pavarde;
            this.amzius = amzius;
            this.klase = klase;
            this.pazymiuSarasas = pazymiuSarasas;
        }
    }
}
