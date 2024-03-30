using System;

namespace _03.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int b1 = 0;
            int b2 = 0;
            int b3 = 0;
            int b4 = 0;
            int b5 = 0;



            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    b1 += 1;
                }
                else if (num < 400)
                {
                    b2 += 1;
                }
                else if (num < 600)
                {
                    b3 += 1;
                }
                else if (num < 800)
                {
                    b4 += 1;
                }
                else
                {
                    b5 += 1;
                }
            }

            int totalCount = b1 + b2 + b3 + b4 + b5;

            double p1 = (double)b1 / totalCount * 100;
            double p2 = (double)b2 / totalCount * 100;
            double p3 = (double)b3 / totalCount * 100;
            double p4 = (double)b4 / totalCount * 100;
            double p5 = (double)b5 / totalCount * 100;

            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
            Console.WriteLine($"{p4:F2}%");
            Console.WriteLine($"{p5:F2}%");

        }
    }
}
