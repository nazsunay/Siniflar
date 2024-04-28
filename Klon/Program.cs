using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            { 
            string[] kelimeler = { "NEŞEM", "MÜZİK" ,"GARAJ", "MELEK","KARAR" };

            Random random = new Random();
            string arananKelime = kelimeler[random.Next(kelimeler.Length)];

            int tahminSayisi = 6;

                for (int i = 1; i <= tahminSayisi; i++)
                {
                    Console.WriteLine($"{i}. Tahmininizi Giriniz");
                    string tahminKelime = Console.ReadLine().ToUpper();

                    if (tahminKelime == arananKelime)
                    {
                        Console.WriteLine($"Tebrikler! {i}. tahminde kelimeyi buldunuz");
                    }
                    else
                    
                    {
                        string sonuc = "";
                        for (int j = 0; j <= arananKelime.Length; j++)
                        {
                            if (tahminKelime[j] == arananKelime[j])
                            {
                                Console.BackgroundColor = ConsoleColor.White;//arka plan
                                Console.ForegroundColor = ConsoleColor.Green;
                                sonuc += tahminKelime[j];
                               
                            }
                            else if (tahminKelime != arananKelime)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                sonuc += tahminKelime[j];
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine("Yo");
                                sonuc += tahminKelime[i];
                            }
                        }
                        Console.WriteLine($"Sonuç: {sonuc}");
                    }
                }    
            }
           
        }
    }
}
