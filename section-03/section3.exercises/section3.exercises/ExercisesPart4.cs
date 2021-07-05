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

        public static void Ex2()
        {
            //Leia um valor inteiro N
            //Este valor será a quantidade de valores inteiros X que serão lidos em seguida
            //Mostre quantos destes valores X estão dentro do intervalo [10, 20] e quantos estão fora do intervalo, mostrando essas informações conforme exemplo (use a palavra "in" para dentro do intervalo,
            //e "out" para fora do intervalo)

            Console.Write("Quantos números deseja informar?: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            int IN = 0;
            int OUT = 0;

            for (int i = 1; i <= n;  i++)
            {
                Console.Write(">> ");
                int x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                {
                    IN += 1;
                }
                else
                {
                    OUT += 1;
                }
            }

            Console.WriteLine($"\n{IN} in");
            Console.WriteLine($"{OUT} out");
        }
    }
}
