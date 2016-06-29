using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{

    /// <summary>
    /// Fazer um programa que leia três valores numéricos, 
    /// determine e imprima o menor deles.
    /// </summary>

    public class Ex01
    {
        static void Main(string[] args)
        {
        }

        public int Calcular (int a, int b, int c)
        {
            int menor = a;

            if (b < menor)
                menor = b;
            if (c < menor)
                menor = c;

            return menor;


        }

    }
}
