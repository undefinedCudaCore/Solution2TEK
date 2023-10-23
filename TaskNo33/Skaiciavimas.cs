using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskNo33
{
    internal class Skaiciavimas
    {
        public int Sudetis(int a, int b)
        {
            return a + b;
        }
        public int Atimtis(int a, int b)
        {
            return a - b;
        }
        public double KetvirtuLaipsniu(int a, int b)
        {
            double pow = Math.Pow(a + b, 4);
            return pow;
        }
        public double Saknis(int a, int b)
        {
            double sqrt = Math.Sqrt(a + b);
            return sqrt;
        }
    }
}
