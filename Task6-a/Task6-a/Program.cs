using System;

namespace Task6_a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sozu daxil edin");
            string array = Console.ReadLine();
            Console.WriteLine("Herfi daxil edin");
            string herf = Console.ReadLine();
            char buk = char.Parse(herf);
            Console.WriteLine(NuminWord(array, buk));

        }
        static int NuminWord(string a, char b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (b == a[i])
                {
                    return i;
                }
            }return -1;
        }
    }
}
