using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6uyg2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Musteri> musteris = new List<Musteri>();

            Musteri ozM = new Musteri();
            ozM.Ad = "ali";
            ozM.Soyad = "veli";
            ozM.ToplamAlisVerisFiyati = 3030;
            musteris.Add(ozM);

            OzelMusteri ozM1 = new OzelMusteri();
            ozM1.Ad = "ayse";
            ozM1.Soyad = "fatma";
            ozM1.ToplamAlisVerisFiyati = 7600;
            musteris.Add(ozM1);

            OzelMusteri ozM2 = new OzelMusteri();
            ozM2.Ad = "zehra";
            ozM2.Soyad = "mehra";
            ozM2.ToplamAlisVerisFiyati = 5002;
            musteris.Add(ozM2);

            Musteri ozM3 = new Musteri();
            ozM3.Ad = "hayriye";
            ozM3.Soyad = "huriye";
            ozM3.ToplamAlisVerisFiyati = 5500;
            musteris.Add(ozM3);

            for (int i = 0; i < musteris.Count; i++)
            {
                if (musteris.ElementAt(i).ToplamAlisVerisFiyati < 5000)
                {
                    musteris[i]--;
                }
            }

            foreach (var element in musteris)
            {
                Console.WriteLine(element.GetType().Name);
            }

            Console.ReadKey();
        }
    }
}
