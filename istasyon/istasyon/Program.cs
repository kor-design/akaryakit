using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace istasyon
{
    class Program
    {
        static void Main(string[] args)
        {
        //değişken tanımlama    
            double dizel = 3.12, benzin = 3.28, lpg = 1.78;
            double dizeltank = 1000, benzintank = 1000, lpgtank = 1000;
            double satismiktari = 0;
            char anamenusecim = '0', altmenusecim = '0', akaryakitguncelle = '0', akaryakitsatistakip = '0';
        //ana menü olusturma
        MENU:
            Console.WriteLine("Akaryakıt satış takip");
            Console.WriteLine(".....................");
            Console.WriteLine("1-Birim fiyat göster");
            Console.WriteLine("2-Birim fiyatı güncelle");
            Console.WriteLine("3-Akaryakıt satışı yap");
            Console.WriteLine("4-Depo durumunu göster");
            Console.WriteLine("5-Toplam satışları göster");
            Console.WriteLine("6-çıkış");
            Console.WriteLine("Seçiminizi yapınız[1-2-3-4-5-6]");
            anamenusecim = Convert.ToChar(Console.ReadLine());
            if (anamenusecim=='1')
            {
                Console.Clear();
                Console.WriteLine("<< Seçiminiz 1 >>");
                Console.WriteLine(">> Birim fiyatlar listesi <<");
                Console.WriteLine("Dizel (D): {0}TL/Litre",dizel);
                Console.WriteLine("Benzin (B): {0}TL/Litre",benzin);
                Console.WriteLine("Lpg (L): {0}TL/Litre",lpg);
                ALTMENU:
                Console.WriteLine("1-Ana menüye dön");
                Console.WriteLine("2-Programı kapat");
                Console.WriteLine("Seçiminizi yapınız. [1-2]");
                altmenusecim = Convert.ToChar(Console.ReadLine());
                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmenusecim== '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("yanlış seçim yaptınız.tekrar deneyiniz");
                    goto ALTMENU;
                }
            }
            else if (anamenusecim=='2')
            {
                Console.Clear();
                Console.WriteLine("<< Seçiminiz 2 >>");
                Console.WriteLine(">> Birim fiyatı güncelleme <<");
                AKARYAKITSECIM:
                Console.Write("Dizel (D)");
                Console.Write(" | Benzin (B)");
                Console.WriteLine(" | Lpg (L)");
                Console.WriteLine("Güncellemek için seçiniz [D-B-L]");
                akaryakitguncelle = Convert.ToChar(Console.ReadLine());
                if (akaryakitguncelle == 'd' || akaryakitguncelle == 'D')
                {
                    Console.Clear();
                    Console.WriteLine("Dizel Fiyatı : {0}TL/Litre", dizel);
                    Console.WriteLine("Yeni Dizel Fiyatını giriniz: ");
                    dizel = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Değişiklik yapılmıştır");
                    Console.WriteLine("Yeni Dizel Fiyatı : {0}TL/Litre", dizel);
                }
                else if (akaryakitguncelle == 'b' || akaryakitguncelle == 'B') 
                {
                    Console.Clear();
                    Console.WriteLine("Benzin Fiyatı : {0}TL/Litre", benzin);
                    Console.WriteLine("Yeni Benzin Fiyatını giriniz: ");
                    benzin = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Değişiklik yapılmıştır");
                    Console.WriteLine("Yeni Benzin Fiyatı : {0}TL/Litre", benzin);
                }
                else if (akaryakitguncelle == 'l' || akaryakitguncelle == 'L')
                {
                    Console.Clear();
                    Console.WriteLine("Lpg Fiyatı : {0}TL/Litre", lpg);
                    Console.WriteLine("Yeni Lpg Fiyatını giriniz: ");
                    lpg = Convert.ToDouble(Console.ReadLine()); 
                    Console.Clear();
                    Console.WriteLine("Değişiklik yapılmıştır");
                    Console.WriteLine("Yeni Lpg Fiyatı : {0}TL/Litre", lpg);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Hatalı seçim yaptınız! Tekrar deneyiniz.");
                    goto AKARYAKITSECIM;
                }
            ALTMENU:
                Console.WriteLine("1-Ana menüye dön");
                Console.WriteLine("2-Programı kapat");
                Console.WriteLine("Seçiminizi yapınız. [1-2]");
                altmenusecim = Convert.ToChar(Console.ReadLine());
                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Hatalı seçim yaptınız.Tekrar deneyiniz");
                    goto ALTMENU;
                }
            }
        }
    }
}
