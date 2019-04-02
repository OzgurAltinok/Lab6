using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6uyg
{
    class SinerjikEtki : Etki
    {
        public override int Degerlendir(int a, int b)
        {
            return a * b;
        }

        public int Degerlendir(int[] dizi)
        {
            int result = 1;
            foreach (var element in dizi)
            {
                result *= element;
            }
            return result;
        }
    }
}
