using System;

namespace _06.Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string imeNaAktiora = Console.ReadLine();
            double tochkiOtAkadeniata = double.Parse(Console.ReadLine());
            int broiOceniavashti = int.Parse(Console.ReadLine());
            if (tochkiOtAkadeniata < 2.0 || tochkiOtAkadeniata > 450.5 ||
                broiOceniavashti < 1 || broiOceniavashti > 20)
            {
                Console.WriteLine("error");
                return;
            }

            double tochki = tochkiOtAkadeniata;

            for (int i = 0; i < broiOceniavashti; i++)
            {
                string imeNaoceniacashtia = Console.ReadLine();
                double tochkiNaOceniavashtia = double.Parse(Console.ReadLine());
                if (tochkiNaOceniavashtia < 1.0 || tochkiNaOceniavashtia > 50.0)
                {
                    Console.WriteLine("error");
                    return;
                }

                int broiBukvi = 0;
                foreach (char bukva in imeNaoceniacashtia.ToCharArray())
                {
                    broiBukvi += 1;
                }

                tochki += tochkiNaOceniavashtia * broiBukvi / 2;

                if (tochki > 1250.5)
                {
                    break;
                }

            }

            if (tochki > 1250.5)
            {
                Console.WriteLine($"Congratulations, {imeNaAktiora} got a nominee for leading role with {tochki:F1}!");
            }
            else
            {
                double nujniTochki = 1250.5 - tochki;
                Console.WriteLine($"Sorry, {imeNaAktiora} you need {nujniTochki:F1} more!");
            }

        }
    }
}
