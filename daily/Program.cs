using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daily
{
    internal class Program
    {
        class Not
        {
            public string Baslik {  get; set; }
            public string Icerik { get; set; }
            public DateTime Tarih {get; set; }
        }
        static List<Not> notlar = new List<Not>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hellooo Günlüğüne Hoş Geldin ");
                Console.WriteLine("------------------");
                Console.WriteLine("1. Yeni Not Ekle");
                Console.WriteLine("2. Notları Listele");
                Console.WriteLine("3. Çıkış");
                Console.Write("Seçiminizi giriniz: ");
                
                int secim = int.Parse(Console.ReadLine());

                if (secim==1)
                {
                    Console.WriteLine("Yeni Not Ekle");
                    Console.Write("Başlık: ");
                    string baslik = Console.ReadLine();
                    Console.Write("İçerik: ");
                    string icerik = Console.ReadLine();

                    Not yeniNot = new Not();
                    yeniNot.Tarih = DateTime.Now; 
                    yeniNot.Baslik = baslik;
                    yeniNot.Icerik = icerik;

                    notlar.Add(yeniNot);
                    Console.WriteLine("Not eklendi!");
                    Console.ReadKey(true); 
                }
                else if (secim==2)
                {
                    Console.WriteLine("Notlar");
                    if (notlar.Count == 0)
                    {
                        Console.WriteLine("Hiç not bulunamadı!");
                    }
                    else
                    {
                        foreach (Not nots in notlar)
                        {
                            Console.WriteLine($"\nTarih: {nots.Tarih.ToString("G/A/Y")}");
                            Console.WriteLine($"Başlık: {nots.Baslik}");
                            Console.WriteLine($"İçerik: {nots.Icerik}");
                            Console.WriteLine("------------------");
                        }
                    }
                    Console.ReadKey(true);


                }
                else
                {
                    Console.WriteLine("Çıkış");
                }
            }
        }
    }
}
