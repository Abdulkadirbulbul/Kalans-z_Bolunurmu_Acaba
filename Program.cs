using System;

namespace odev_3hafta_uygulama3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Girilen 2 sayının biri birine tam bölünüp bölünemedğini bulan programı yazınız.
            Console.WriteLine("İlk sayıyı giriniz.");
            int ilk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz.");
            int iki = Convert.ToInt32(Console.ReadLine());
            int sonuc = 0;
            if (ilk > iki)
            {
                sonuc = ilk % iki;
            }
            else if (iki < ilk)
            {
                sonuc = iki % ilk;
            }
            else
            {
                sonuc = 0;
            }
            if (sonuc == 0)
            {
                Console.WriteLine("Birbirine kalansız ve tam bölünür.");
            } else Console.WriteLine("Birbirine tam bölünemez ve kalan= "+sonuc+"  olur.");
            Console.ReadKey();
        }
    }
}
