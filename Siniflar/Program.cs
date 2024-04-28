using System.Collections.Generic;
using System;
using System.Diagnostics.Eventing.Reader;

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

        static void Main(string[] args)
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hoş geldiniz");
                Console.WriteLine("1 - Öğrencileri Listele");
                Console.WriteLine("2 - Öğrenci Ekle");
                Console.WriteLine("3- Öğrenci Ara");
                Console.WriteLine("3- Çıkış");

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

                

                else if (inputSecim==3)
                {
                    Console.Clear();
                    Console.WriteLine("Aranan Öğrenci");
                    string inputAranan = Sor("Adı: ");
                    Ogrenci arananOgrenci = null;

                    foreach (var ogrenci in ogrenciler)
                    {
                        if (ogrenci.Ad == inputAranan)
                        {
                            arananOgrenci= ogrenci;
                            break;
                        }
                    }
                    if (arananOgrenci!=  null)
                    {
                        Console.WriteLine("Öğrenciyi buldum");
                        Console.WriteLine($"{arananOgrenci.Ad} {arananOgrenci.Soyad} {arananOgrenci.Yas}");
                    }
                    Console.WriteLine("Devam etmek için tuşa basın");
                    Console.ReadKey();
                    
                   
                }
                else 
                {
                    Console.Clear();
                   
                    break;
                }


            }
            
        }
    }
}