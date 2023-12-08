namespace SORU6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen birinci sayıyı giriniz");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci sayıyı giriniz");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen üçüncü sayıyı ondalıklı giriniz");
            decimal sayi3 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Lütfen dördüncü sayıyı ondalıklı giriniz");
            decimal sayi4 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Lütfen beşinci sayıyı ondalıklı giriniz");
            decimal sayi5 = Convert.ToDecimal(Console.ReadLine());

            Topla(sayi1, sayi2, out int result1);
            Console.WriteLine(result1);

            Topla(sayi3, sayi4, sayi5, out decimal result2);
            Console.WriteLine(result2);
        }

        static void Topla(int sayi1, int sayi2, out int result)
        {
            result = sayi1 + sayi2;
        }

        static void Topla(decimal sayi1, decimal sayi2, decimal sayi3, out decimal result)
        {
            result = sayi1 + sayi2 + sayi3;
        }
    }
}
