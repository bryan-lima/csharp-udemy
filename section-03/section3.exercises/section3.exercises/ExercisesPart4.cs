using System;
using System.Collections.Generic;
using System.Text;

namespace section3.exercises
{
    class ExercisesPart4
    {
        public static void Ex1()
        {
            //Leia um valor inteiro X (1 <= X <= 1000)
            //Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso

            Console.Write("\n\nInforme um valor para X: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nNúmeros ímpares entre 1 e {x}");

            for (int i = 0; i <= x; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
