using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sayilar = { };
            do
            {
                Console.Write("Lütfen 20 adet sayıyı aralarında boşluk olacak şekilde giriniz: ");
                sayilar = Console.ReadLine().Split(' ');
            }
            while (sayilar.Length != 20);


            int[] intSayilar = Array.ConvertAll(sayilar, Convert.ToInt32);
            Array.Sort(intSayilar);

            double enBuyukUcOrtalama = (intSayilar[19] + intSayilar[18] + intSayilar[17]) / 3;
            double enKucukUcOrtalama = (intSayilar[0] + intSayilar[1] + intSayilar[2]) / 3;

            Console.WriteLine($"En büyük 3 sayının ortalaması: {enBuyukUcOrtalama}");
            Console.WriteLine($"En küçük 3 sayının ortalaması:{enKucukUcOrtalama}");
            Console.WriteLine($"Ortalamaların toplamı: {(enKucukUcOrtalama + enBuyukUcOrtalama) / 2}");


            Console.ReadLine();

        }
    }
}
