using System.Collections.Generic;
using System;

namespace Listeler
{
    internal class Program
    {
        static string Sor(string soru)
        {
            Console.Write(soru);
            return Console.ReadLine();
        }

        class Ogrenci
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public int Yas { get; set; }
        }

        static List<Ogrenci> ogrenciler = new List<Ogrenci>();

        static Ogrenci OgrenciBul(string arananAd)
        {
            Ogrenci bulunanOgrenci = null;

            foreach (var ogrenci in ogrenciler)
            {
                if (arananAd == ogrenci.Ad)
                {
                    bulunanOgrenci = ogrenci;
                    break;
                }
            }

            return bulunanOgrenci;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hoş geldiniz");
                Console.WriteLine("1 - Öğrencileri Listele");
                Console.WriteLine("2 - Öğrenci Ekle");
                Console.WriteLine("3 - Öğrenci Ara");
                Console.WriteLine("4 - Çıkış");

                int inputSecim = int.Parse(Sor("Seçiminiz: "));

                if (inputSecim == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Öğrenci Listesi");
                    foreach (Ogrenci ogrenci in ogrenciler)
                    {
                        Console.WriteLine($"{ogrenci.Ad} {ogrenci.Soyad} - {ogrenci.Yas}");
                    }

                    Console.WriteLine("\nDevam etmek için bir tuşa basın");
                    Console.ReadKey();
                }
                else if (inputSecim == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Öğrenci Ekle");
                    Ogrenci ogrenci = new Ogrenci();
                    ogrenci.Ad = Sor("Ad: ");
                    ogrenci.Soyad = Sor("Soyad: ");
                    ogrenci.Yas = int.Parse(Sor("Yaş: "));

                    ogrenciler.Add(ogrenci);
                }
                else if (inputSecim == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Öğrenci Ara");
                    string inputArananOgrenci = Sor("Adı: ");

                    Ogrenci arananOgrenci = OgrenciBul(inputArananOgrenci);

                    if (arananOgrenci != null)
                    {
                        // ogrenciler.Remove(arananOgrenci); silmek istiyorsam bu alanda bu kodu kullanmalıyım
                        Console.WriteLine("Öğrenciyi buldum!");
                        Console.WriteLine($"{arananOgrenci.Ad} {arananOgrenci.Soyad} {arananOgrenci.Yas}");
                    }
                    else
                    {
                        Console.WriteLine("Böyle bir öğrenci yok!");
                    }

                    Console.WriteLine("\nDevam etmek için bir tuşa basın");
                    Console.ReadKey();

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Hoşçakalın");
                    break;
                }

                //Denenecek
                //static Ogrenci OgrenciDüzenle(string DüzenlenAd, int DüzenlenenNumara)
                //{
                //    Ogrenci düzenlenenOgrenci = null;
                //    foreach (Ogrenci ogrenci in ogrenciler)
                //    {
                //        if (DüzenlenAd == ogrenci.Ad || )
                //        {

                //        }
                //    }
                //    return;
                //}
            }
           

        }
    }
}