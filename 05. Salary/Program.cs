using System;

namespace _05.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int broiOtvoreniTabove = int.Parse(Console.ReadLine());
            int zaplata = int.Parse(Console.ReadLine());

            for (int i = 0; i < broiOtvoreniTabove; i++)
            {
                string tab = Console.ReadLine();

                int globa;
                switch (tab)
                {
                    case "Facebook":
                        globa = 150;
                        break;
                    case "Instagram":
                        globa = 100;
                        break;
                    case "Reddit":
                        globa = 50;
                        break;
                    default:
                        globa = 0;
                        break;
                }

                if (zaplata - globa <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
                else
                {
                    zaplata = zaplata - globa;
                }
            }

            Console.WriteLine(zaplata);

        }
    }
}
