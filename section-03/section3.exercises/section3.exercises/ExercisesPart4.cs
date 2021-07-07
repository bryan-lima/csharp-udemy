using System;
using System.Collections.Generic;
using System.Globalization;
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

            for (int i = 1; i <= n; i++)
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

        public static void Ex3()
        {
            //Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir
            //Cada caso de teste consiste de 3 valores reais, cada um deles com uma casa decimal
            //Apresente a média ponderada para cada um destes conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5

            Console.Write("\nInforme a quantidade de casos de testes que deseja: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("\nAgora informe 3 números decimais (0.0) separados por espaço, para cada caso de teste:");

            List<string> cases = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                Console.Write(">> ");
                string x = Console.ReadLine();
                cases.Add(x);
            }

            Console.WriteLine();
            int counter = 1;

            foreach (string c in cases)
            {
                string[] cSplited = c.Split(' ');
                double n1 = double.Parse(cSplited[0], CultureInfo.InvariantCulture);
                double n2 = double.Parse(cSplited[1], CultureInfo.InvariantCulture);
                double n3 = double.Parse(cSplited[2], CultureInfo.InvariantCulture);

                double total = (n1 * 0.2) + (n2 * 0.3) + (n3 * 0.5);

                Console.WriteLine("Média ponderada do " + counter + "º caso: " + total.ToString("F1", CultureInfo.InvariantCulture));
                
                counter++;
            }
        }

        public static void Ex4()
        {
            //Fazer um programa para ler um número N
            //Depois leia N pares de números e mostre a divisão do primeiro pelo segundo
            //Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel"

            Console.Write("\nDigite um número: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("\nAgora informe 2 números inteiros separados por espaço, para cada entrada:");

            List<string> intNumbers = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                Console.Write(">> ");
                string x = Console.ReadLine();
                intNumbers.Add(x);
            }

            Console.WriteLine();
            int counter = 1;

            foreach (string intNumber in intNumbers)
            {
                string[] intNumberSplited = intNumber.Split(' ');
                double n1 = double.Parse(intNumberSplited[0], CultureInfo.InvariantCulture);
                double n2 = double.Parse(intNumberSplited[1], CultureInfo.InvariantCulture);

                if (n2 == 0)
                {
                    Console.WriteLine($"Divisão impossível entre {n1} e {n2}");
                    continue;
                }

                double division = n1 / n2;

                Console.WriteLine("Divisão entre " + n1 + " e " + n2 + " = " + division.ToString("F1", CultureInfo.InvariantCulture));

                counter++;
            }
        }

        public static void Ex5()
        {
            //Ler um valor N
            //Calcular e escrever seu respectivo fatorial
            //Fatorial de N = N * (N - 1) * (N - 2) * (N - 3) * ... *1
            //Lembrando que, por definição, fatorial de 0 é 1

            Console.WriteLine("\nCALCULAR FATORIAL");
            Console.WriteLine("------------------");

            Console.Write("\nInforme o valor para calcular seu fatorial: ");
            int n = int.Parse(Console.ReadLine());

            int factorial = n;

            if (n == 0)
            {
                factorial = 1;
            }
            else
            {
                for (int i = n - 1; i > 0; i--)
                {
                    factorial = factorial * (n - i);
                }
            }

            Console.WriteLine($"\nFatorial de {n} = {factorial}");
        }
    }
}
