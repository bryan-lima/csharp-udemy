using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace section3.exercises
{
    class ExercisesPart1
    {
        public static void Ex1()
        {
            //Exercício 1 - Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma mensagem explicativa

            Console.Write("\nInforme um valor inteiro: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("\nInforme outro valor inteiro: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nSOMA = {n1 + n2}");
        }

        public static void Ex2()
        {
            //Exercício 2 - Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais

            //Fórmula da área: area = π.raio2

            //Considere o valor de π = 3.14159

            Console.Write("\nInforme o valor do raio do círculo: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double PI = 3.14159;

            double area = PI * (radius * radius);

            Console.WriteLine("\nA = " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
