//b) Apresentar o total da soma obtida dos cem primeiros números inteiros (1+2+3+4+...+98+99+100).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioManzano
{
    internal class ExercicioWhile02
    {
        public static void Main(string[] args)
        {
            int contadora = 0;
            int acumuladora = 0;

            while (contadora < 101)
            {
                acumuladora += contadora; //operadora de atribuição adição, é acumuladora = acumuladora + contadora
                contadora++;
                Console.WriteLine("Soma dos valores inteiros é: " + acumuladora);
            }

            
        }
    }
}
