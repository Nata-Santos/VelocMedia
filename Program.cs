using System;

namespace VelocMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, s ;
           int v;

           Console.WriteLine("Digite a distância andada, e o tempo gasto para chegar ao destino.");
           Console.WriteLine("---------------------------");

           Console.WriteLine("Distância percorrida (m): ");
           m = Convert.ToInt16(Console.ReadLine());

           Console.WriteLine("Tempo gasto (s): ");
           s = Convert.ToInt16(Console.ReadLine());

           v = m/s ;
           Console.WriteLine($"\nA velocidade média é ►► {v} m/s ");

        }
    }
}
