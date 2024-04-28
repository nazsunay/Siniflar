using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daily
{
    internal class Program
    {
        static string Sor(string soru)
        {
            Console.Write(soru);
            return Console.ReadLine();
        }
        class Not
        {
            public string Baslik { get; set; }
            public string Icerik { get; set; }
            public DateTime Tarih { get; set; }
        }
        static List<Not> notlar = new List<Not>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hellooo Günlüğüne Hoş Geldin ");
                Console.WriteLine("------------------");
                Console.WriteLine("1. Notları Listele");
                Console.WriteLine("2. Yeni Not Ekle"); 
                Console.WriteLine("3. Çıkış");
                

                int secim = int.Parse(Sor("Seçiminiz: "));
                if (secim==1)
                {
                    Console.WriteLine("Notlarım");
                    foreach (Not not in notlar)
                    {
                        Console.WriteLine($"{not.Tarih}\n{not.Baslik}\n{not.Icerik} ");
                    }
                    Console.ReadKey();
                }
                else if (secim==2)
                {
                    Console.WriteLine("Yeni Not Ekle");
                    Not yeninot = new Not();
                    yeninot.Baslik = Sor("Başlık: ");
                    yeninot.Icerik = Sor("İçerik: ");
                    yeninot.Tarih= DateTime.Now;
                    notlar.Add(yeninot);
                    
                }
                else
                {
                    Console.WriteLine("Çıkış");
                }
            }
        }
 
    }
}
