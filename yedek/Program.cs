using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OgrenciYönetim
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

            public string Yas { get; set; }
            public int No { get; set; }
            public string Cinsiyet { get; set; }
            public DateTime DogumTarihi { get; set; }
        }

        static List<Ogrenci> ogrenciler = new List<Ogrenci>();

        static Ogrenci OgrenciBul(string arananAd,int arananNo)
        {

            Console.WriteLine("Öğrenci Bul");
            Console.WriteLine("1. Numara ile Bul");
            Console.WriteLine("2. İsme Göre Bul");
            Console.Write("Seçiminizi giriniz: ");

            int secim = int.Parse(Console.ReadLine());

            if (secim == 1)
            {
                Console.Write("Öğrenci numarası giriniz: ");
                int numara = int.Parse(Console.ReadLine());
            }
            else if (secim == 2)
            {
                Console.Write("Öğrenci ismi giriniz: ");
                string isim = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Geçersiz seçim!");
            }
            Ogrenci bulunanOgrenci = null;
            foreach (Ogrenci ogrenci in ogrenciler)
            {
                if (arananAd == ogrenci.Ad)
                {
                    bulunanOgrenci = ogrenci;
                    break;
                }
            }
            return bulunanOgrenci;
        }
        static Ogrenci OgrenciSil(string silinenAd)
        {
            Ogrenci silinenOgrenci = null;
            foreach (Ogrenci ogrenci in ogrenciler)
            {
                if (silinenAd == ogrenci.Ad)
                {
                    silinenOgrenci = ogrenci;
                }
            }
            return silinenOgrenci;
        }
        static Ogrenci OgrenciDüzenle(string DüzenlenAd)
        {
            Ogrenci düzenlenenOgrenci = null;
            foreach (Ogrenci ogrenci in ogrenciler)
            {
                if (DüzenlenAd == ogrenci.Ad)
                {
                    düzenlenenOgrenci = ogrenci;
                }
            }
            return düzenlenenOgrenci;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Ögrenci Listesi");
                Console.WriteLine("2. Öğrenci Ekle");
                Console.WriteLine("3. Ögrenci Bul");
                Console.WriteLine("4. Ögrenci Sil");
                Console.WriteLine("5. Ögrenci Düzenle");
                Console.WriteLine("6. Çıkış");

                int inputSecim = int.Parse(Sor("Seçiminiz:"));

                if (inputSecim == 1)
                {
                    Console.WriteLine("Öğrenci Listesi");
                    foreach (Ogrenci ogrenci in ogrenciler)
                    {
                        Console.Write($"{ogrenci.Ad} {ogrenci.Soyad}-{ogrenci.Yas}-{ogrenci.No}-{ogrenci.Cinsiyet}-{ogrenci.DogumTarihi}");
                    }
                    Console.ReadKey();
                }
                else if (inputSecim == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Öğrenci Ekle");
                    Ogrenci ogrenci = new Ogrenci();
                    ogrenci.Ad = Sor("Adınız: ");
                    ogrenci.Soyad = Sor("Soyadınız: ");
                    ogrenci.Yas = Sor("Yaşınız: ");
                    ogrenci.Cinsiyet = Sor("Cinsiyetiniz: ");
                    ogrenci.No = int.Parse(Sor("Numaranız: "));
                    ogrenci.DogumTarihi = DateTime.Parse(Sor("Doğum tarihiniz: "));

                    ogrenciler.Add(ogrenci);
                }
                else if (inputSecim == 3)
                {
                    Console.WriteLine("Öğrenci Ara");
                    string inputArananOgrenci = Sor("Adı: ");
                    int inputarananNo = int.Parse(Sor("Numarası"));
                    Ogrenci arananOgrenci = OgrenciBul(inputArananOgrenci,inputarananNo);
                    if (arananOgrenci != null)
                    {
                        Console.WriteLine("Ogrenci Bulundu");
                        Console.WriteLine($"{arananOgrenci.Ad} {arananOgrenci.Soyad}-{arananOgrenci.Yas}-{arananOgrenci.No}-{arananOgrenci.Cinsiyet}-{arananOgrenci.DogumTarihi}");
                    }
                    else
                    {
                        Console.WriteLine("Böyle bir öğrenci yok");
                    }
                    Console.WriteLine("Devam etmek için bir tuşa basın");
                    Console.ReadKey();
                }
                else if (inputSecim == 4)
                {
                    Console.WriteLine("Ogrenci Sİl");
                    string inputSilinenOgrenci = Sor("Ad: ");
                    Ogrenci silinenOgrenci = OgrenciSil(inputSilinenOgrenci);
                    if (silinenOgrenci != null)
                    {
                        Console.WriteLine("silmek istediğiniz Öğrenciyi buldum");
                        Console.WriteLine($"{silinenOgrenci.Ad} {silinenOgrenci.Soyad}-{silinenOgrenci.Yas}-{silinenOgrenci.No}-{silinenOgrenci.Cinsiyet}-{silinenOgrenci.DogumTarihi}");
                        ogrenciler.Remove(silinenOgrenci);
                    }
                    else
                    {
                        Console.WriteLine("böyle bir öğrenci yok");
                    }
                    Console.WriteLine("\nDevam etmek için bir tuşa basın");
                    Console.ReadKey();
                }
                else if (inputSecim == 5)
                {
                    Console.WriteLine("Öğrenciyi Düzenle");
                    string inputDüzenlenOgrenci = Sor("Ad: ");
                    Ogrenci düzenlenenOgrenci = OgrenciDüzenle(inputDüzenlenOgrenci);
                    Console.WriteLine($"{düzenlenenOgrenci.Ad} {düzenlenenOgrenci.Soyad}-{düzenlenenOgrenci.Yas}-{düzenlenenOgrenci.No}-{düzenlenenOgrenci.Cinsiyet}-{düzenlenenOgrenci.DogumTarihi}");

                    if (düzenlenenOgrenci != null)
                    {
                        Console.WriteLine($"{düzenlenenOgrenci.Ad} {düzenlenenOgrenci.Soyad}-{düzenlenenOgrenci.Yas}-{düzenlenenOgrenci.No}-{düzenlenenOgrenci.Cinsiyet}-{düzenlenenOgrenci.DogumTarihi}");

                        Console.WriteLine("Düzenlenmiş durumunu yazınız: ");
                        string duzenle = Console.ReadLine();
                        Console.WriteLine(duzenle);
                    }
                    else
                    {
                        Console.WriteLine("Düzenlenecek Öğrenci bulunamadı");
                    }
                    Console.ReadKey();

                }
            }

        }
    }
}

