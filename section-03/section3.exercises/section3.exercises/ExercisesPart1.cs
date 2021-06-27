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

        public static void Ex3()
        {
            //Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D)

            Console.WriteLine("\nInforme 4 números inteiro: ");
            Console.Write(">> ");
            int A = int.Parse(Console.ReadLine());
            Console.Write(">> ");
            int B = int.Parse(Console.ReadLine());
            Console.Write(">> ");
            int C = int.Parse(Console.ReadLine());
            Console.Write(">> ");
            int D = int.Parse(Console.ReadLine());

            int difference = A * B - C * D;

            Console.WriteLine($"\nDIFERENÇA = {difference}");
        }

        public static void Ex4()
        {
            //Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário
            //A seguir, mostre o número e o salário do funcionário, com duas casas decimais

            Console.Write("\nID Funcionário: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("\nHoras trabalhadas: ");
            int workedHours = int.Parse(Console.ReadLine());

            Console.Write("\nValor por hora: R$ ");
            double hourlyRate = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salary = workedHours * hourlyRate;

            Console.WriteLine("------------------------------------");

            Console.WriteLine($"\nNUMBER = {id}");
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));
        }

        public static void Ex5()
        {
            //Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2
            //Calcule e mostre o valor a ser pago

            Console.WriteLine("\nPRODUTO 1 -----------------------------------------");
            Console.WriteLine("Informe código da peça, quantidade, valor unitário:");
            Console.Write(">> ");
            string[] product1 = Console.ReadLine().Split(' ');

            int quantityProduct1 = int.Parse(product1[1]);
            double unitPrice1 = double.Parse(product1[2], CultureInfo.InvariantCulture);
            double valueToPayProduct1 = quantityProduct1 * unitPrice1;

            Console.WriteLine("\nPRODUTO 2 -----------------------------------------");
            Console.WriteLine("Informe código da peça, quantidade, valor unitário:");
            Console.Write(">> ");
            string[] product2 = Console.ReadLine().Split(' ');

            int quantityProduct2 = int.Parse(product2[1]);
            double unitPrice2 = double.Parse(product2[2], CultureInfo.InvariantCulture);
            double valueToPayProduct2 = quantityProduct2 * unitPrice2;

            double totalToPay = valueToPayProduct1 + valueToPayProduct2;

            Console.WriteLine("\n---------------------------------------------------");

            Console.WriteLine("\nValor a pagar: R$ " + totalToPay.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
