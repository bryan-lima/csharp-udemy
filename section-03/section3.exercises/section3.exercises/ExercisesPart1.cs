using System;
using System.Collections.Generic;
using System.Text;

namespace section3.exercises
{
    class ExercisesPart1
    {
        public static void Ex1()
        {
            //Exercício 1 - Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
            //mensagem explicativa, conforme exemplos

            Console.Write("\nInforme um valor inteiro: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("\nInforme outro valor inteiro: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nSOMA = {n1 + n2}");
        }
    }
}
