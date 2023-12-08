namespace SORU2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] stringDizi = new string[5];

            for (int i = 0; i < stringDizi.Length; i++)
            {
                Console.Write("Lütfen {0}. elemanı girin: ", i + 1);
                stringDizi[i] = Console.ReadLine();
            }

            string enUzunEleman = "";
            int enUzunKarakterSayisi = 0;
            int enUzunElemanIndexi = 0;

            for (int i = 0; i < stringDizi.Length; i++)
            {
                if (stringDizi[i].Length > enUzunKarakterSayisi)
                {
                    enUzunEleman = stringDizi[i];
                    enUzunKarakterSayisi = stringDizi[i].Length;
                    enUzunElemanIndexi = i;
                }
            }

            Console.WriteLine("En uzun eleman: {0}", enUzunEleman);
            Console.WriteLine("Karakter sayısı: {0}", enUzunKarakterSayisi);
            Console.WriteLine("Elemanın index numarası: {0}", enUzunElemanIndexi);
        }

    }
}
