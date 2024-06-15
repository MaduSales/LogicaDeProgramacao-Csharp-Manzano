// b) Elaborar um programa que apresente no final o somatório dos valores
// pares existentes na faixa de 1 até 500.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioManzano
{
    internal class ExercicioDoWhile02
    {
        public static void Main(string[] args)
        {
            int contadora = 0;
            int acumuladora = 0;

            do
            {
                if (contadora % 2 == 0)
                {
                    acumuladora += contadora;
                }
            }
            while (contadora < 501);
            Console.WriteLine("A soma dos números inteiros é: " + acumuladora);
            
        }
    }
}
