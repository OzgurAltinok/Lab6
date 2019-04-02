using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6uyg2
{
    class OzelMusteri : Musteri
    {
        public OzelMusteri()
        {
            this.IndirimOrani = IndirimOrani * 3 / 2;
        }

        public override int indirimHesapla(int fiyat)
        {
            return fiyat * IndirimOrani / 100;
        }
    }
}
