using System.Runtime.ConstrainedExecution;
using System;

namespace uygulama1
{
    class Program
    { 
            /*Dışarıdan 10 adet sayı girilsin sayılar 1 ile 100 arasında olacak ve her sayının binary(ikili sistem) karşılıkları bulunacak.
              her sayının binary karşılığındaki 1 ve 0'lar sayılarak, kaç adet 1'ler fazla ise, kaçında 0'lar fazla ise kaçında 1 ve 0'lar eşit ise
              sayılar ile beraber yazdırılacak, hata kontrollerini yapınız.*/

        
       public static string binarydon(int sayi)
        {
            string binary = Convert.ToString(sayi, 2);
            return binary;
        }

        public static void SayiAnalizi(int[] sayilar)
        {
            int toplam1 = 0;
            int toplam0 = 0;
            int esit = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                string binaryKarsilik = binarydon(sayilar[i]);
                int birler = 0;
                int sifirler = 0;

                foreach (char c in binaryKarsilik)
                {
                    if (c == '1')
                        birler++;
                    else if (c == '0')
                        sifirler++;
                }

                toplam1 += birler;
                toplam0 += sifirler;

                if (birler > sifirler)
                    Console.WriteLine(sayilar[i] + ": 1'ler fazla");
                else if (sifirler > birler)
                    Console.WriteLine(sayilar[i] + ": 0'lar fazla");
                else
                    Console.WriteLine(sayilar[i] + ": 1'ler ve 0'lar eşit");

            }
            if (toplam1 > toplam0)
                Console.WriteLine("Toplamda 1'ler fazla: " + (toplam1 - toplam0));
            else if (toplam0 > toplam1)
                Console.WriteLine("Toplamda 0'lar fazla: " + (toplam0 - toplam1));
            else
                Console.WriteLine("Toplamda 1'ler ve 0'lar eşit");
        }

       public static void Main (string[] args)
        {
            try
            {
                int[] sayilar = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    Console.Write((i + 1) + ". sayıyı girin (1 ile 100 arasında): ");
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    if (sayi < 1 || sayi > 100)
                    {
                        Console.WriteLine("Hata: Sayı 1 ile 100 arasında olmalı!");
                        break;
                    }
                    sayilar[i] = sayi;
                }

                SayiAnalizi(sayilar);
            }
            catch (FormatException)
            {
                Console.WriteLine("Hata: Geçersiz sayı girişi!");
            }
        }
    }
}