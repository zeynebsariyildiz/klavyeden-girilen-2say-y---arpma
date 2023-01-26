using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klavyeden_girilen_2sayıyı_çarpma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, carpim;

            Console.WriteLine("Lütfen Birinci Sayıyı Giriniz");
            sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen İkinci Sayıyı Giriniz");
            sayi2 = int.Parse(Console.ReadLine());

            carpim = sayi1 * sayi2;

            Console.WriteLine("Sayıların Çarpımı =" + carpim);
            Console.ReadLine();

            //gayet güzel olmuş :)))
        }
    }
}
