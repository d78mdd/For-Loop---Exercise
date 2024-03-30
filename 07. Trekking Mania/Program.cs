using System;

namespace _07.Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int broiGrupi = int.Parse(Console.ReadLine());
            if (broiGrupi < 0 || broiGrupi > 1000)
            {
                Console.WriteLine("error");
                return;
            }

            int horaObshto = 0;

            int izkachvashtiMusala = 0;
            int izkachvashtiMonblan = 0;
            int izkachvashtiKili = 0;
            int izkachvashtiK2 = 0;
            int izkachvashtiEverest = 0;

            for (int i = 0; i < broiGrupi; i++)
            {
                int horaVGrupata = int.Parse(Console.ReadLine());
                if (horaVGrupata < 0 || horaVGrupata > 1000)
                {
                    Console.WriteLine("error");
                    return;
                }

                horaObshto += horaVGrupata;

                if (horaVGrupata <= 5) // Мусала
                {
                    izkachvashtiMusala += horaVGrupata;
                }
                else if (horaVGrupata <= 12) // Монблан
                {
                    izkachvashtiMonblan += horaVGrupata;
                }
                else if (horaVGrupata <= 25) // Килиманджаро
                {
                    izkachvashtiKili += horaVGrupata;
                }
                else if (horaVGrupata <= 40) // К2
                {
                    izkachvashtiK2 += horaVGrupata;
                }
                else // > 40 Еверест
                {
                    izkachvashtiEverest += horaVGrupata;
                }

            }

            double procentNaMusala;
            double procentNaMonblan;
            double procentNaKili;
            double procentNaK2;
            double procentNaEverest;


            procentNaMusala = (double)izkachvashtiMusala / (double)horaObshto * 100;
            procentNaMonblan = (double)izkachvashtiMonblan / (double)horaObshto * 100;
            procentNaKili = (double)izkachvashtiKili / (double)horaObshto * 100;
            procentNaK2 = (double)izkachvashtiK2 / (double)horaObshto * 100;
            procentNaEverest = (double)izkachvashtiEverest / (double)horaObshto * 100;

            Console.WriteLine($"{procentNaMusala:F2}%");
            Console.WriteLine($"{procentNaMonblan:F2}%");
            Console.WriteLine($"{procentNaKili:F2}%");
            Console.WriteLine($"{procentNaK2:F2}%");
            Console.WriteLine($"{procentNaEverest:F2}%");

        }
    }
}
