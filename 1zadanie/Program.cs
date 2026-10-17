using System;
namespace number
{
    class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        static void Main()
        {
            int a = 5;
            int b = 10;
            Swap(ref a, ref b);
            Console.WriteLine($"После замены: a = {a}, b = {b}");
        }
    }
}