using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Hesap Makinesi");
            Console.WriteLine("1. Toplama");
            Console.WriteLine("2. Çıkarma");
            Console.WriteLine("3. Çarpma");
            Console.WriteLine("4. Bölme");
            Console.WriteLine("5. Çıkış");
            Console.Write("Seçiminiz: ");

            int secim;
            if (!int.TryParse(Console.ReadLine(), out secim))
            {
                Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                continue;
            }

            if (secim == 5)
            {
                Console.WriteLine("Programdan çıkılıyor...");
                break;
            }

            Console.Write("İlk sayıyı girin: ");
            double sayi1;
            if (!double.TryParse(Console.ReadLine(), out sayi1))
            {
                Console.WriteLine("Geçersiz sayı. Lütfen tekrar deneyin.");
                continue;
            }

            Console.Write("İkinci sayıyı girin: ");
            double sayi2;
            if (!double.TryParse(Console.ReadLine(), out sayi2))
            {
                Console.WriteLine("Geçersiz sayı. Lütfen tekrar deneyin.");
                continue;
            }

            double sonuc = 0;
            switch (secim)
            {
                case 1:
                    sonuc = sayi1 + sayi2;
                    break;
                case 2:
                    sonuc = sayi1 - sayi2;
                    break;
                case 3:
                    sonuc = sayi1 * sayi2;
                    break;
                case 4:
                    if (sayi2 == 0)
                    {
                        Console.WriteLine("Bir sayıyı sıfıra bölemezsiniz.");
                        continue;
                    }
                    sonuc = sayi1 / sayi2;
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                    continue;
            }

            Console.WriteLine("Sonuç: " + sonuc);
        }
    }
}
