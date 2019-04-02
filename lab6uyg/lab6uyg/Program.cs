using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6uyg
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elemanSayilari = new int[] { 3, 4, 2 };
            Etki ekip = new DuzEtki();
            int hesap = ekip.Degerlendir(20, 5); // hesap değeri 25 oluyor
            Console.WriteLine(hesap);

            ekip = new SinerjikEtki(); hesap = ekip.Degerlendir(5, 10); // hesap değeri 50 oluyor
            Console.WriteLine(hesap);

            hesap = (new SinerjikEtki()).Degerlendir(elemanSayilari); // hesap değeri 24 oluyor
            Console.WriteLine(hesap);

            Console.ReadKey();
        }
    }
}
