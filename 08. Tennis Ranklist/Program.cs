using System;

namespace _08.Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            double broiTurniri = int.Parse(Console.ReadLine());
            int nachalniTochki = int.Parse(Console.ReadLine());

            double specheleniTochki = 0;
            double specheleniTurniri = 0;

            for (int i = 0; i < broiTurniri; i++)
            {
                string dostignatEtap = Console.ReadLine();
  
                switch (dostignatEtap)
                {
                    case "W":
                        specheleniTochki += 2000;
                        specheleniTurniri += 1;
                        break;
                    case "F":
                        specheleniTochki += 1200;
                        break;
                    case "SF":
                        specheleniTochki += 720;
                        break;
                    default:
                        Console.WriteLine("error");
                        return;
                }
            }

            double tochki = specheleniTochki + nachalniTochki;

            double srednoNaTurnir = specheleniTochki / broiTurniri;

            double procentSpecheleniTurniri = specheleniTurniri / broiTurniri * 100;

            Console.WriteLine($"Final points: {tochki}");
            Console.WriteLine($"Average points: {Math.Floor(srednoNaTurnir)}");
            Console.WriteLine($"{procentSpecheleniTurniri:F2}%");

        }
    }
}
