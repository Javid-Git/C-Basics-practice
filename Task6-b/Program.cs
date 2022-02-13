using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ededi daxil edin");
            string example = Console.ReadLine();
            int eded = int.Parse(example);
            Console.WriteLine(IsPrime(eded));
        }
        static bool IsPrime(int a)
        {
            int denominator = 2;
            for (int i = a; i!=2 && i > denominator; denominator++)
            {
                if (i % denominator == 0)
                {
                    return false;
                }
            }return true;
        }
    }
}
