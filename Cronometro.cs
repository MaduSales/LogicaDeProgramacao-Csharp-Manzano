using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExercicioManzano
{
    internal class Cronometro
    {
        public static void Main(string[] args)
        {
            int segundos = 00;
            int minutos = 00;

            while (segundos < 60)
            {
                while (minutos < 60)
                {
                    Console.WriteLine($"Temporizador: {minutos}:{segundos}");
                    segundos++;
                }
                segundos = 0;
                minutos++;

            }
        }
    }
}
