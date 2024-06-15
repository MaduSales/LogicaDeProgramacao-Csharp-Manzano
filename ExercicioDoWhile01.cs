// a) Apresentar os quadrados dos números inteiros de 15 a 200.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioManzano
{
    internal class ExercicioDoWhile01
    {
        public static void Main(string[] args)
        {
            int contadora = 15;

            do
            {
                Console.WriteLine("O quadrado de " + contadora + " é: " + contadora * contadora);
                contadora++;
            }
            while (contadora < 201);
        }
    }
}
