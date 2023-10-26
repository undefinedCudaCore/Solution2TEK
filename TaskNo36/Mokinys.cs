using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskNo36
{
    internal class Mokinys
    {
        public string vardas;
        public string pavarde;
        public int amzius;
        public int klase;
        public List<int> pazymiuSarasas = new List<int>(5);

        public Mokinys(string vardas, string pavarde, int amzius, int klase, List<int> pazymiuSarasas)
        {
            this.vardas = vardas;
            this.pavarde = pavarde;
            this.amzius = amzius;
            this.klase = klase;
            this.pazymiuSarasas = pazymiuSarasas;

        }

        // Information display method
        public void isvestiInfoApieMokini()
        {
            Console.WriteLine($"Vardas: {vardas}, pavardė: {pavarde}, amžius {amzius}, klasė {klase}.");
            Console.WriteLine($"Pažymiai: {pazymiuSarasas[0]}, {pazymiuSarasas[1]}, {pazymiuSarasas[2]}, {pazymiuSarasas[3]}, {pazymiuSarasas[4]}. ");
            Console.WriteLine();
        }
        public void uzKiekMetuBaigsMokykla()
        {
            int kiekLikoMetuMokytis = 12 - klase;

            if (kiekLikoMetuMokytis == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Mokinys mokyklą baigs šiais metais.");
                Console.WriteLine();
            }
            else 
            {
                Console.WriteLine();
                Console.WriteLine($"Po {kiekLikoMetuMokytis} metų  mokinys baigs mokyklą");
                Console.WriteLine();
            }
        }
    }
}
