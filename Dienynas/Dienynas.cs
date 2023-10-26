using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dienynas
{
    internal class Dienynas
    {
        public List<Mokinys> Mokiniai = new List<Mokinys>();

        public Dienynas(List<Mokinys> mokiniai) 
        {
            Mokiniai = mokiniai;
        }

        public void IvestiPazymius(string pamoka, Mokinys mokinys, List<double> pazymiai)
        {

            for (int i = 0; i < Mokiniai[i].PazymiaiA.Count; i++)
            {
                if (Mokiniai[i].Vardas != mokinys.Vardas)
                {
                    Console.WriteLine("Tokio mokynio nera!");
                    return;
                } else
                {
                    if (pamoka == Mokiniai[i].PazymiaiA[i].Pamoka)
                    {
                        mokinys.PazymiaiA[i].PazymiaiB.AddRange(pazymiai);
                        return;
                    }
                    else if (pamoka != Mokiniai[i].PazymiaiA[i].Pamoka)
                    {
                        PamokosPazymiai papildomiPamokaPazymiai = new PamokosPazymiai(pamoka, pazymiai);
                        mokinys.PazymiaiA.Add(papildomiPamokaPazymiai);
                        return;
                    }

                }
            }

        }
    }
}
