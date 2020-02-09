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
            double dizel = 3.12, benzin = 3.28, lpg = 1.78;
            double dizeltank = 1000, benzintank = 1000, lpgtank = 1000;
            char anamenusecim = '0', altmenusecim = '0', akaryakitguncelle = '0', akaryakitsatistakip = '0';
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
            if (anamenusecim == '1')
            {
                Console.Clear();
                Console.WriteLine("<< Seçiminiz 1 >>");
                Console.WriteLine(">> Birim fiyatlar listesi <<");
                Console.WriteLine("Dizel (D): {0}TL/Litre", dizel);
                Console.WriteLine("Benzin (B): {0}TL/Litre", benzin);
                Console.WriteLine("Lpg (L): {0}TL/Litre", lpg);
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
                    Console.WriteLine("yanlış seçim yaptınız.tekrar deneyiniz");
                    goto ALTMENU;
                }
            }
            if (anamenusecim == '2')
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
            else if (anamenusecim == '3')
            {
                Console.Clear();
            SATIS_SECIM:
                Console.WriteLine("<< Seçiminiz 3 >>");
                Console.WriteLine(">> Akaryakıt satışı yap <<");
                Console.Write("Dizel (D)");
                Console.Write(" | Benzin (B)");
                Console.WriteLine(" | Lpg (L)");
                Console.WriteLine("Satış yapmak için seçiniz [D-B-L]");
                akaryakitsatistakip = Convert.ToChar(Console.ReadLine());

                if (akaryakitsatistakip == 'D' || akaryakitsatistakip == 'd')
                {
                    if (dizeltank == 0)
                    {
                        Console.WriteLine("Depoda 0 litre kalmıştır yeterli stok bulunmamaktadır.");
                        goto SATIS_SECIM;
                    }
                    else
                    {
                        Console.WriteLine("Fiyat {0} TL", dizel);
                        Console.WriteLine("Depo {0} Litre", dizeltank);
                        Console.WriteLine("Satılan miktarı Litre olarak giriniz");
                        double satilan_miktar = Convert.ToDouble(Console.ReadLine());
                        if (satilan_miktar <= dizeltank)
                        {
                            double tutar = satilan_miktar * dizel;
                        SECIM_ONAY:
                            Console.WriteLine("fiyatı {0} TL", tutar);
                            Console.WriteLine("Satışı onaylıyor musunuz ? (E/H)");
                            char satis_secim = Convert.ToChar(Console.ReadLine());
                            if (satis_secim == 'E' || satis_secim == 'e')
                            {
                                dizeltank = dizeltank - satilan_miktar;
                                Console.WriteLine("Depo kalan {0} Litre", dizeltank);
                                Console.WriteLine("Satış Başarıyla gerçekleşmiştir");
                            }
                            else if (satis_secim == 'H' || satis_secim == 'h')
                            {
                                goto MENU;
                            }
                            else
                            {
                                Console.WriteLine("hatalı tuşlama yaptınız, tekrar deneyiniz");
                                goto SECIM_ONAY;
                            }
                        ALTMENU2:
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
                                goto ALTMENU2;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Yeterli stok mevcut değil");
                            goto MENU;
                        }
                    }

                }
                if (akaryakitsatistakip == 'B' || akaryakitsatistakip == 'b')
                {
                    if (benzintank == 0)
                    {
                        Console.WriteLine("Depoda 0 litre kalmıştır yeterli stok bulunmamaktadır.");
                        goto SATIS_SECIM;
                    }
                    else
                    {
                        Console.WriteLine("Fiyat {0} TL", benzin);
                        Console.WriteLine("Depo {0} Litre", benzintank);
                        Console.WriteLine("Satılan miktarı Litre olarak giriniz");
                        double satilan_miktar = Convert.ToDouble(Console.ReadLine());
                        if (satilan_miktar <= benzintank)
                        {
                            double tutar = satilan_miktar * benzin;
                        SECIM_ONAY:
                            Console.WriteLine("fiyatı {0} TL", tutar);
                            Console.WriteLine("Satışı onaylıyor musunuz ? (E/H)");
                            char satis_secim = Convert.ToChar(Console.ReadLine());
                            if (satis_secim == 'E' || satis_secim == 'e')
                            {
                                benzintank = benzintank - satilan_miktar;
                                Console.WriteLine("Depo kalan {0} Litre", benzintank);
                                Console.WriteLine("Satış Başarıyla gerçekleşmiştir");
                            }
                            else if (satis_secim == 'H' || satis_secim == 'h')
                            {
                                goto MENU;
                            }
                            else
                            {
                                Console.WriteLine("hatalı tuşlama yaptınız, tekrar deneyiniz");
                                goto SECIM_ONAY;
                            }
                        ALTMENU2:
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
                                goto ALTMENU2;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Yeterli stok mevcut değil");
                            goto MENU;
                        }
                    }

                }
                if (akaryakitsatistakip == 'L' || akaryakitsatistakip == 'l')
                {
                    if (lpgtank == 0)
                    {
                        Console.WriteLine("Depoda 0 litre kalmıştır yeterli stok bulunmamaktadır.");
                        goto SATIS_SECIM;
                    }
                    else
                    {
                        Console.WriteLine("Fiyat {0} TL", lpg);
                        Console.WriteLine("Depo {0} Litre", lpgtank);
                        Console.WriteLine("Satılan miktarı Litre olarak giriniz");
                        double satilan_miktar = Convert.ToDouble(Console.ReadLine());
                        if (satilan_miktar <= lpgtank)
                        {
                            double tutar = satilan_miktar * lpg;
                        SECIM_ONAY:
                            Console.WriteLine("fiyatı {0} TL", tutar);
                            Console.WriteLine("Satışı onaylıyor musunuz ? (E/H)");
                            char satis_secim = Convert.ToChar(Console.ReadLine());
                            if (satis_secim == 'E' || satis_secim == 'e')
                            {
                                lpgtank = lpgtank - satilan_miktar;
                                Console.WriteLine("Depo kalan {0} Litre", lpgtank);
                                Console.WriteLine("Satış Başarıyla gerçekleşmiştir");
                            }
                            else if (satis_secim == 'H' || satis_secim == 'h')
                            {
                                goto MENU;
                            }
                            else
                            {
                                Console.WriteLine("hatalı tuşlama yaptınız, tekrar deneyiniz");
                                goto SECIM_ONAY;
                            }
                        ALTMENU2:
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
                                goto ALTMENU2;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Yeterli stok mevcut değil");
                            goto MENU;
                        }
                    }

                }
            }

            else if (anamenusecim == '4')
            {
                Console.Clear();
                Console.WriteLine("<< Seçiminiz 4 >>");
                Console.WriteLine(">> Depo durumunu göster <<");
                Console.WriteLine("Depoda {0} Litre Dizel Yakıt Bulunmaktadır. %{1}", dizeltank,(dizeltank/10));
                Console.WriteLine("Depoda {0} Litre Benzin Yakıt Bulunmaktadır. %{1}", benzintank,(benzintank/10));
                Console.WriteLine("Depoda {0} Litre Lpg Yakıt Bulunmaktadır. %{1}", lpgtank,(lpgtank/10));
            ALTMENU2:
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
                    goto ALTMENU2;
                }
            }
            else if (anamenusecim == '5')
            {
                Console.Clear();
                Console.WriteLine("<< Seçiminiz 5 >>");
                Console.WriteLine(">> Toplam satışları göster <<");
                Console.WriteLine("Satılan toplam dizel {0} Litredir. Getirisi {1} TL dir.", (1000 - dizeltank),((1000-dizeltank)*dizel));
                Console.WriteLine("Satılan toplam benzin {0} Litredir. Getirisi {1} TL dir.", (1000 - benzintank), ((1000 - benzintank) * benzin));
                Console.WriteLine("Satılan toplam lpg {0} Litredir. Getirisi {1} TL dir.", (1000 - lpgtank), ((1000 - lpgtank) * lpg));
                Console.WriteLine("TOPLAM KAZANÇ {0} TL DIR", ((1000 - dizeltank) * dizel) + ((1000 - benzintank) * benzin) + ((1000 - lpgtank) * lpg));
            ALTMENU2:
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
                    goto ALTMENU2;
                }
            }
                if (anamenusecim == '6')
                {
                    Environment.Exit(0);
                }
                Console.ReadKey();
            
        }
    }
}
