using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6uyg2
{
    class Musteri
    {
        private string ad;
        private string soyad;
        private int ındirimOrani;
        private int toplamAlisVerisFiyati;

        protected internal string Ad { get => ad; set => ad = value; }
        protected internal string Soyad { get => soyad; set => soyad = value; }
        protected internal int IndirimOrani { get => ındirimOrani; set => ındirimOrani = value; }
        protected internal int ToplamAlisVerisFiyati { get => toplamAlisVerisFiyati; set => toplamAlisVerisFiyati = value; }

        public virtual int indirimHesapla(int fiyat)
        {
            return fiyat * IndirimOrani / 100;
        }

        public static OzelMusteri operator --(Musteri musteri)
        {
            musteri.ToplamAlisVerisFiyati--;
            return (OzelMusteri)musteri;
        }
    }
}