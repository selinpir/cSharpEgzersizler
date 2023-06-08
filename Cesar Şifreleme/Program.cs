namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Metni girin: ");
            string metin = Console.ReadLine();
            
            Console.Write("Kaydırma miktarını girin: ");
            int kaydirmaMiktari = Convert.ToInt32(Console.ReadLine());
            
            string sifreliMetin = CesarSifrele(metin, kaydirmaMiktari);
            
            Console.WriteLine("Şifreli Metin: " + sifreliMetin);
            
            Console.ReadLine();
        }
        static string CesarSifrele(string metin, int kaydirmaMiktari)
    {
            string sifreliMetin = "";
            
            foreach (char karakter in metin)
            {
                if (char.IsLetter(karakter))
                {
                    char sifreliKarakter = (char)(karakter + kaydirmaMiktari);
                    
                    if (char.IsUpper(karakter))
                    {
                        if (sifreliKarakter > 'Z')
                            sifreliKarakter = (char)(sifreliKarakter - 26);
                        else if (sifreliKarakter < 'A')
                            sifreliKarakter = (char)(sifreliKarakter + 26);
                    }
                    else if (char.IsLower(karakter))
                    {
                        if (sifreliKarakter > 'z')
                            sifreliKarakter = (char)(sifreliKarakter - 26);
                        else if (sifreliKarakter < 'a')
                            sifreliKarakter = (char)(sifreliKarakter + 26);
                    }
                    
                    sifreliMetin += sifreliKarakter;
                }
                else
                {
                    sifreliMetin += karakter;
                }
            }
            
            return sifreliMetin;
        }
            
            
            }
}