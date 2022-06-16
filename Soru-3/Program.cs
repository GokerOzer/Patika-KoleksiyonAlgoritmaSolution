using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir cümle giriniz: ");
            string[] cümle = Console.ReadLine().Split(' ');
            string bosluksuzCümle = String.Join("", cümle);
            char[] harfler = bosluksuzCümle.ToCharArray();
            List<char> harflerListe = new List<char>();

            foreach (char item in harfler)
            {
                if (item == 'a' || item == 'e' || item == 'ı' || item == 'i' || item == 'o' || item == 'ö' || item == 'u' || item == 'ü')
                {
                    harflerListe.Add(item);
                }
            }


            Console.Write($"Cümledeki sesli harfler: {String.Join("", harflerListe)}");
            Console.ReadLine();
        }
    }
}
