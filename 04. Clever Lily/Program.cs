using System;

namespace _04.Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int vazrastNaLili = int.Parse(Console.ReadLine());
            double cenaNaPeralniata = double.Parse(Console.ReadLine());
            int cenaNaIgrachka = int.Parse(Console.ReadLine());

            int igrachki = 0;
            double pari = 0.0;

            for (int i = 1; i <= vazrastNaLili; i++)
            {
                if (i % 2 != 0)  // necheten
                {
                    igrachki += 1;
                }
                else  // cheten
                {
                    pari += i * 5;
                    pari -= 1;
                }
            }

            pari += igrachki * cenaNaIgrachka;


            if (pari >= cenaNaPeralniata)
            {
                double N = pari - cenaNaPeralniata;
                Console.WriteLine($"Yes! {N:F2}");
            }
            else
            {
                double M = cenaNaPeralniata - pari;
                Console.WriteLine($"No! {M:F2}");
            }

        }
    }
}
