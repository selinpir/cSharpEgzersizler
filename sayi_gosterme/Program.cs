namespace sayi_gosterme
{
    internal class Program
    {
        static void Main(string[] args)
            {
                Console.Write("Bir sayı girin: ");
                int sayi = Convert.ToInt32(Console.ReadLine());

                sayilar(sayi);

                Console.ReadLine();
            }

        static void sayilar(int sayi)
            {
            int sayac = 1;
            for (int i = 1; i <= sayi; i++)
                {
                    for (int j = 0; j < sayac; j++)
                    {
                        Console.Write(i + " ");
                    }
                    sayac++;
                }
            }
        }
    }
