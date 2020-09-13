using System;
using System.IO;

namespace Лаб2_Индивидуальное_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            double a, b, c, d, e;
            double s, k;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            d = Convert.ToDouble(Console.ReadLine());
            e = Convert.ToDouble(Console.ReadLine());

            if ((a < 0) || (b < 0) || (c < 0) || (d < 0) || (e < 0) || (a > 10000) || (b > 10000) || (c > 10000) || (d > 10000) || (e > 10000))
                Console.WriteLine("ERROR");
            else
            {
                s = (a / Math.Sqrt(b)) + ( (c + Math.Sqrt(b + a - e)) / (Math.Sqrt(e)) );
                Console.WriteLine(String.Format("{0:0.000}" , s));
            }


            if ((a < 0) || (b < 0) || (c < 0) || (d < 0) || (e < 0) || (a > 10000) || (b > 10000) || (c > 10000) || (d > 10000) || (e > 10000))
                Console.WriteLine("ERROR");
            else
            {
                k = (Math.Sqrt(e - a)) / (Math.Sqrt(c - 4 * b) - e);
                    Console.WriteLine(String.Format("{0:0.000}", k));
            }



                Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
        }

    }
}
