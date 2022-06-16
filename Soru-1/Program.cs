using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sayilar = { };
            do
            {
                Console.Write("Lütfen 20 adet pozitif sayıyı aralarında boşluk olacak şekilde giriniz: ");
                sayilar = Console.ReadLine().Split(' ');

            } while (sayilar.Length != 20 );


            bool valid = false;
            for (int i = 0; i < sayilar.Length; i++)
            {
                bool isNumber = int.TryParse(sayilar[i], out int numericValue);
                if (!isNumber || Convert.ToInt32(sayilar[i]) < 0)
                {
                    Console.Write("Lütfen 20 adet pozitif sayıyı aralarında boşluk olacak şekilde giriniz: ");
                    break;
                }
                else
                    valid = true;

            }

            if (valid)
            {
                int[] ints = Array.ConvertAll(sayilar, Convert.ToInt32);
                List<int> asalSayilar = new List<int>();
                List<int> asalOlmayanSayilar = new List<int>();
                foreach (int item in ints)
                {

                    if (item == 2 || item == 3 || item == 5)
                        asalSayilar.Add(item);
                    else if (item == 1 || item % 2 == 0 || item % 3 == 0 || item % 5 == 0)
                        asalOlmayanSayilar.Add(item);
                    else
                        asalSayilar.Add(item);

                }

                asalSayilar.Sort();
                asalSayilar.Reverse();
                asalOlmayanSayilar.Sort();
                asalOlmayanSayilar.Reverse();

                Console.WriteLine($"Büyükten küçüğe asal sayılar: {String.Join(" ", asalSayilar)}");
                Console.WriteLine($"Büyükten küçüğe asal olmayan sayılar: {String.Join(" ", asalOlmayanSayilar)}");

                double asalOrtalama = asalSayilar.Average();
                double asalOlmayanOrtalama = asalOlmayanSayilar.Average();

                Console.WriteLine($"Asal sayıların ortalaması: {asalOrtalama}, Asal sayı adeti: {asalSayilar.Count}");
                Console.WriteLine($"Asal olmayan sayıların ortalaması: {asalOlmayanOrtalama}, Asal olmayan sayı adeti: {asalOlmayanSayilar.Count}");


            }


            Console.ReadLine();



        }
    }
}
