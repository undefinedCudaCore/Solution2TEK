using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskNo31
{
    internal class Metodai
    {
        public int SumosFunkcija(int a, int b, int c) 
        {
            int isSumos = a + b + c;
            return isSumos;
        }        
        public double DalmensFunkcija(double a, double b) 
        {
            double isDalmens = Math.Round(a / b, 2);
            return isDalmens;
        }
    }
}
