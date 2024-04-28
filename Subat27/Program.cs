using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat27
{
    internal class Program
    {
        static void Yaz(string metin, bool satirYaz=false, ConsoleColor arkaPlan=ConsoleColor.DarkGray, ConsoleColor renk = ConsoleColor.White)
        {
            Console.BackgroundColor = arkaPlan;
            Console.ForegroundColor = renk;

            Console.WriteLine(metin.ToUpper());
            Console.ResetColor();
            if (satirYaz)
            {
                Console.WriteLine(metin.ToUpper());
            }
            else
            {
                Console.Write(metin.ToUpper());
            }
        }
        static void Main(string[] args)
        {
            var kelimeler = new string[] { "Kelime" };

            Random rastgeleSayi= new Random();
            string rastgeleKelime= kelimeler[ rastgeleSayi.Next(kelimeler.Length)].ToUpper();


            Yaz("Tahmin: ", true);
            string inputTahmin =Console.ReadLine().ToUpper();

            //tahmin ile rastgele aynı mı ?
            //tahmin edilen kelime tutuyor mu 
            //harfler dogru indxtemi

            if (rastgeleKelime== inputTahmin)
            {

                Yaz("Tebrikler",arkaPlan: ConsoleColor.Green );
            }
            for (int i = 0; i < inputTahmin.Length; i++)
            {
                if (inputTahmin[i] == rastgeleKelime[i])
                {
                    Yaz(inputTahmin[i].ToString(),true,arkaPlan:ConsoleColor.DarkGreen,renk:ConsoleColor.White);
                }
                //Conteins araştır !!
                else if (rastgeleKelime.Contains(inputTahmin[i]) )
                {
                    Yaz(inputTahmin[i].ToString(), true, arkaPlan: ConsoleColor.Yellow);
                }
                else
                {
                    Yaz(inputTahmin[i],true);
                }
            }



            Yaz(rastgeleKelime);
        }





        //static void RenkliYaz(string metin)
        //{
        //    Console.BackgroundColor = ConsoleColor.Red;
        //    Console.WriteLine(metin.ToUpper());
        //    Console.ResetColor();



        //}

        //static void Main(string[] args)
        //{

        //    RenkliYaz("merhaba");
        //    RenkliYaz("Selamlar",ConsoleColor.Red);
        //    //RenkliYaz(renk:ConsoleColor.Gray,metin:"Orhan");
        //}
    }
}
