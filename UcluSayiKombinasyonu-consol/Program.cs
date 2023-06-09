namespace UcluSayiKombinasyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int carpim = 30;
            int toplam = 10;

            Console.WriteLine("Üçlü sayıların kombinasyonları:");
            uclusayi(carpim, toplam);

            Console.ReadLine();
        }
        static void uclusayi(int carpim, int toplam)
        {
            for (int i = 1; i <= carpim; i++)
            {
                for (int j = 1; j <= carpim; j++)
                {
                    for (int k = 1; k <= carpim; k++)
                    {
                        if (i * j * k == carpim && i + j + k == toplam)
                        {
                            Console.WriteLine(i + " * " + j + " * " + k + " = " + carpim + ", " + i + " + " + j + " + " + k + " = " + toplam);
                        }
                    }
                }
            }
        }
    }
}
    