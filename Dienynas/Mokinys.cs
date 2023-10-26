using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dienynas
{
    internal class Mokinys
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public List<PamokosPazymiai> PazymiaiA = new List<PamokosPazymiai>();

        public Mokinys(string vardas, string pavarde)
        {
            Vardas = vardas;
            Pavarde = pavarde;

            PazymiaiA = new List<PamokosPazymiai>();

        }
    }
}
