using System;

using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Kelime listesi (5 harfli kelimeler)
        string[] kelimeler = { "ELMA", "ARABA", "KEDİ", "EV", "KİTAP" };

        // Hedef kelime seçimi
        Random rastgele = new Random();
        string hedefKelime = kelimeler[rastgele.Next(kelimeler.Length)];

        // Tahmin sayısı
        const int tahminSayisi = 6;

        for (int tahmin = 1; tahmin <= tahminSayisi; tahmin++)
        {
            // Kullanıcıdan tahmin alma
            Console.Write($"{tahmin}. Tahmininizi girin: ");
            string tahminKelime = Console.ReadLine().ToUpper();

            // Tahmin kontrolü
            if (tahminKelime == hedefKelime)
            {
                Console.WriteLine($"Tebrikler! {tahmin}. tahminde kelimeyi buldunuz!");
                break;
            }
            else
            {
                // Harflerin karşılaştırılması ve renk kodlama
                string sonuc = "";
                for (int i = 0; i < hedefKelime.Length; i++)
                {
                    if (tahminKelime[i] == hedefKelime[i])
                    {
                        // Doğru harf (yeşil)
                        Console.ForegroundColor = ConsoleColor.Green;
                        sonuc += tahminKelime[i];
                        Console.ResetColor();
                    }
                    else if (hedefKelime.Contains(tahminKelime[i]))
                    {
                        // Yanlış harf, doğru konumda değil (sarı)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        sonuc += tahminKelime[i];
                        Console.ResetColor();
                    }
                    else
                    {
                        // Yanlış harf (gri)
                        sonuc += tahminKelime[i];
                    }
                }

                // Sonucu sadece tahmin kelime hedef kelimeyle eşleşmediğinde yazdır
                if (tahminKelime != hedefKelime)
                {
                    Console.WriteLine($"Sonuç: {sonuc}");
                }
            }
        }

        // Oyun bitti mesajı
        if (hedefKelime.Equals(Console.ReadLine().ToUpper()))
        {
            Console.WriteLine($"Tebrikler! {tahminSayisi}. tahminde kelimeyi buldunuz!");
        }
        else
        {
            Console.WriteLine($"Maalesef, kelimeyi bulamadınız. Hedef kelime: {hedefKelime}");
        }
    }
}
