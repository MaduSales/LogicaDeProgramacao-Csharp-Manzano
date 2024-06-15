// Apresentar os resultados de uma tabuada de multiplicar (de 1 até 10) de um número qualquer.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioManzano
{
    internal class ExercicioWhile01
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número que deseja saber a tabuada");

            int numero = Convert.ToInt32(Console.ReadLine());
            int contadora = 1;
            
            while (contadora < 11)
            {
                int resultado = numero * contadora;
                Console.WriteLine(numero + " x " + contadora + " = " + resultado);
                contadora++;
            }
        }
    }
}
