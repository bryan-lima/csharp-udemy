using System;
using System.Collections.Generic;
using System.Text;

namespace section3.exercises
{
    class ExercisesPart2
    {
        public static void Ex1()
        {
            //Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não

            Console.WriteLine("\nVERIFICADOR DE NÚMERO - NEGATIVO OU NÃO?");
            Console.WriteLine("-------------------------------------------");
            Console.Write("\nInforme um número inteiro: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------");

            if (number < 0)
            {
                Console.WriteLine("\nNEGATIVO");
            }
            else
            {
                Console.WriteLine("\nNÃO NEGATIVO");
            }
        }
    }
}
