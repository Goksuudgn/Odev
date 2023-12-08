namespace SORU5
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen birinci sayıyı ondalıklı giriniz");
            decimal number1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci sayıyı ondalıklı giriniz");
            decimal number2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Lütfen üçüncü sayıyı ondalıklı giriniz");
            decimal number3 = Convert.ToDecimal(Console.ReadLine());

            decimal maxNumber = FindMaxNumber(number1, number2, number3);          

            Console.WriteLine("En büyük sayı : " + maxNumber);
        }

        static decimal FindMaxNumber(decimal num1, decimal num2, decimal num3)
        {
            decimal max = num1;

            if (num2 > max)
                max = num2;

            if (num3 > max)
                max = num3;

            return max;
        }
    }
}

