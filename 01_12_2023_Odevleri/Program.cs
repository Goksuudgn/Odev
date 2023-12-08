using System.ComponentModel;
using System.Text;
using System.Text.RegularExpressions;

namespace _01_12_2023_Odevleri
{
    internal class Program
    {
        static void Main(string[] args)      
        {
            Console.WriteLine("Lütfen bir sayı giriniz...");
            Soru1();
            Console.WriteLine("\n********************************\n");

            Console.Write("Bir kelime girin: ");
            Soru3();
            Console.WriteLine("\n********************************\n");

            Console.WriteLine("Lütfen bir metin giriniz... ");
            Soru4();
            Console.WriteLine("\n********************************\n");


            Console.Write("Kelime veya cümle girin: ");
            Soru8();
            Console.WriteLine("\n********************************\n");


            Console.WriteLine("\n********************************\n");
            Console.Write("Lütfen Cümlenizi girin ve slug şejlini gösterelim : ");
            string cumle = Console.ReadLine();

            string slug = Soru9(cumle);

            Console.WriteLine("Slug: " + slug);
            Console.WriteLine("\n********************************\n");


            Console.WriteLine("Lütfen adınızı soyadınız giriniz...");
            Soru10();
            Console.WriteLine("\n********************************\n");
        }

        static void Soru1()
        {
            int girilenSayi = Convert.ToInt32(Console.ReadLine());
            List<int> tekSayilar = new List<int>();
            List<int> ciftSayilar = new List<int>();

            for (int i = 0; i < girilenSayi; i++)
            {
                if (i % 2 == 0)
                {
                    ciftSayilar.Add(i);
                }
                else
                {
                    tekSayilar.Add(i);
                }
            }

            ciftSayilar.Reverse();
            tekSayilar.Reverse();

            Console.WriteLine("Çift Sayılar:");
            foreach (int sayi in ciftSayilar)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("Tek Sayılar:");
            foreach (int sayi in tekSayilar)
            {
                Console.WriteLine(sayi);
            }


        }
        static void Soru3()
        {

            string kelime = Console.ReadLine();

            string tersKelime = "";
            for (int i = kelime.Length - 1; i >= 0; i--)
            {
                tersKelime += kelime[i];
            }

            Console.WriteLine("Kelimenin tersi: " + tersKelime);
        }
        static void Soru4()
        {
            string metin = Console.ReadLine();

            List<char> harfler = new List<char>();
            List<char> sayilar = new List<char>();

            HashSet<char> harfSet = new HashSet<char>();
            HashSet<char> sayiSet = new HashSet<char>();

            foreach (char karakter in metin)
            {
                if (char.IsLetter(karakter) && !harfSet.Contains(char.ToLower(karakter)))
                {
                    harfler.Add(char.ToLower(karakter));
                    harfSet.Add(char.ToLower(karakter));
                }
                else if (char.IsDigit(karakter) && !sayiSet.Contains(karakter))
                {
                    sayilar.Add(karakter);
                    sayiSet.Add(karakter);
                }
            }

            harfler.Sort();
            sayilar.Sort();

            Console.WriteLine("Harfler: " + string.Join(", ", harfler));
            Console.WriteLine("Sayılar: " + string.Join(", ", sayilar));
        }       
        static void Soru8()
        {

            string metin = Console.ReadLine();

            metin = metin.Replace("ı", "i")
                         .Replace("ö", "o")
                         .Replace("ü", "u")
                         .Replace("ç", "c")
                         .Replace("ş", "s")
                         .Replace("ğ", "g");

            Console.WriteLine("Dönüştürülen metin: " + metin);
        }
        static string Soru9(string cumle)
        {
            cumle = cumle.ToLower();
            cumle = cumle.Replace("ü", "u")
                         .Replace("ı", "i")
                         .Replace("ö", "o")
                         .Replace("ç", "c")
                         .Replace("ş", "s")
                         .Replace("ğ", "g")
                         .Replace(" ", "-");


            cumle = Regex.Replace(cumle, "[^a-z0-9-_]", "");


            cumle = Regex.Replace(cumle, "[-_]+", "-");

            return cumle;
        }
        static void Soru10()
        {

            string adSoyad = Console.ReadLine();
            string siparisTarihi = "01.12.2023";
            string siparisNumarasi = "SP0000123";

            string mailIcerik = string.Format("Sayın {0}, {1} tarihinde almış olduğunuz ürünlere ait sipariş numaranız {2} şeklindedir. Bu numara ile siparişinizi web sitemiz üzerinden takip edebilirsiniz.", adSoyad, siparisTarihi, siparisNumarasi);
            Console.WriteLine(mailIcerik);
        }

    }
}
