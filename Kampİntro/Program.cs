using System;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {

            //type safety - tip güvenligi
            // DO not repeat yourself Kendini tekrarlama
            //deger tutucu alias


            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = true;    //bool -true false
            double dolarDun = 7.55;
            double dolarBugun = 7.45;


            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azaliş butonu");

            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artiş oku ");
            }
            else
            {
                Console.WriteLine("Degişmedi butonu");
            }




            if (sistemeGirisYapmismi== true)

            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu ");
            }


            Console.WriteLine(kategoriEtiketi);



        }
    }
}
