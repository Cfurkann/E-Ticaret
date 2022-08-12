using System;

namespace E_Ticaret
{
    class Program
    {
        static void Main(string[] args)
        {
            urunOzell urun1 = new urunOzell();
            urun1.urunAdi = "T-shirt";
            urun1.urunFiyati = 90;
            urun1.stokAdedi = 10000;
            urun1.marka = "Mavi";

            urunOzell urun2 = new urunOzell();
            urun2.urunAdi = "Pantolon";
            urun2.urunFiyati = 300;
            urun2.stokAdedi = 10000;
            urun2.marka = "Koton";

            urunOzell urun3 = new urunOzell();
            urun3.urunAdi = "Ayakkabı";
            urun3.urunFiyati = 900;
            urun3.stokAdedi = 10000;
            urun3.marka = "Nike";

            urunOzell[] urunler = new urunOzell[] { urun1, urun2, urun3 };


            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine("Urun Adı:"+"  "+urunler[i].urunAdi);
                Console.WriteLine("Urun Fiyatı:" + "  " + urunler[i].urunFiyati);
                Console.WriteLine("Stok Adedi:" + "  " + urunler[i].stokAdedi);
                Console.WriteLine("---------");
            }

            int a = 0;
            while (a<3)
            {
                Console.WriteLine("Urun Adı:" + "  " + urunler[a].urunAdi);
                Console.WriteLine("Urun Fiyatı:" + "  " + urunler[a].urunFiyati);
                Console.WriteLine("Stok Adedi:" + "  " + urunler[a].stokAdedi);
                Console.WriteLine("---------");
                a++;
            }

            foreach (urunOzell urun in urunler)
            {
                Console.WriteLine("Urun Adı:" + "  " + urun.urunAdi);
                Console.WriteLine("Urun Fiyatı:" + "  " + urun.urunFiyati);
                Console.WriteLine("Stok Adedi:" + "  " + urun.stokAdedi);
                Console.WriteLine("----------");
            }
        }

        class urunOzell
        {
            public string urunAdi { get; set; }
            public int urunFiyati { get; set; }
            public int stokAdedi { get; set; }
            public string marka { get; set; }
        }
    }
}
