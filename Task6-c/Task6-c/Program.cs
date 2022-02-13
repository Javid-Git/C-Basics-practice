using System;

namespace Task6_c
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Qiymetleri daxil edin (6 dene)");
            //string[] example = Console.ReadLine().Split(',');
            //int q = int.Parse(example[0]);
            //int w = int.Parse(example[1]);
            //int e = int.Parse(example[2]);
            //int r = int.Parse(example[3]);
            //int t = int.Parse(example[4]);
            //int y = int.Parse(example[5]);
            //Console.WriteLine(MezunyaYox(q, w, e, r, t, y));
            Console.WriteLine("Qiymetleri daxil edin");
            int summ = 0;
            for (int i = 0; i < 6; i++)
            {
                string array = Console.ReadLine();
                int tema = int.Parse(array);
                summ += tema;
            }Console.WriteLine(sum(summ));
        }
        static string sum(int b)
        {
           if(b/6 > 60)
            {
                return "Mezun oldunuz";
            }return "Mezun olmadiniz";
        }

        //static string MezunyaYox(int a, int b, int c, int d, int v, int m)
        //{
        //    if ((a + b + c + d + v + m) > 60)
        //    {
        //        return "Mezun oldunuz";
        //    }return "Mezun Ola Bilmediniz";

        
    }
}
