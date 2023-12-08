namespace SORU7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ÖRNEK 1 : Kullanıcının girdiği sayının pozitif, negatif veya sıfır olduğunu bulma
            Console.WriteLine("Bir sayı girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi > 0)
            {
                Console.WriteLine("Girilen sayı pozitiftir.");
            }
            else if (sayi < 0)
            {
                Console.WriteLine("Girilen sayı negatiftir.");
            }
            else
            {
                Console.WriteLine("Girilen sayı sıfırdır.");
            }

            // ÖRNEK 2 : Bir dizideki sayıların toplamını bulma
            int[] sayilar = { 10, 20, 30, 40, 50 };
            int toplam = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }

            Console.WriteLine("Dizideki sayıların toplamı: " + toplam);


            //ÖRNEK 3 : switch-case

            string mevsim = "yaz";

            switch (mevsim)
            {
                case "kış":
                    Console.WriteLine("Hava soğuktur!");
                    break;
                case "yaz":
                    Console.WriteLine("Hava sıcaktır!");
                    break;
                case "ilkbahar":
                case "sonbahar":
                    Console.WriteLine("Hava ılımandır!");
                    break;
                default:
                    Console.WriteLine("Geçersiz mevsim!");
                    break;
            }


            //ÖRNEK 4 : FOR

            Console.WriteLine("Bir sayı girin: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            int faktoriyel = 1;

            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel *= i;
            }

            Console.WriteLine("Sayının faktöriyeli: " + faktoriyel);


            //ÖRNEK 5 : DİZİ

            List<int> sayilar1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> ciftSayilar = new List<int>();

            foreach (int sayi2 in sayilar)
            {
                if (sayi2 % 2 == 0)
                {
                    ciftSayilar.Add(sayi);
                }
            }

            Console.Write("Çift sayılar: ");
            foreach (int sayi2 in ciftSayilar)
            {
                Console.Write(sayi2 + " ");
            }
        }
    }
}
