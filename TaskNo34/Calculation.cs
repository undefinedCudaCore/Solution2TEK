using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskNo34
{
    internal class Calculation
    {
        public int Daugyba(int x, int y)
        {
            return x * y;
        }
        public double Dalyba(double x, double y)
        {
            return Math.Round((x / y), 2);
        }
    }
}
