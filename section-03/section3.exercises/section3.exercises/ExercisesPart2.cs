using System;
using System.Collections.Generic;
using System.Globalization;
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

        public static void Ex2()
        {
            //Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar

            Console.WriteLine("\nVERIFICADOR DE NÚMERO - PAR OU ÍMPAR?");
            Console.WriteLine("---------------------------------------");
            Console.Write("\nInforme um número inteiro: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------");

            if (number % 2 == 0)
            {
                Console.WriteLine("\nPAR");
            }
            else
            {
                Console.WriteLine("\nÍMPAR");
            }
        }

        public static void Ex3()
        {
            //Leia 2 valores inteiros(A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si
            //Atenção: os números devem poder ser digitados em ordem crescente ou decrescente

            Console.WriteLine("\nVERIFICADOR DE NÚMEROS - MÚLTIPLOS OU NÃO?");
            Console.WriteLine("---------------------------------------------");
            Console.Write("\nInforme um valor inteiro para A: ");
            int a = int.Parse(Console.ReadLine());
            
            Console.Write("\nInforme um valor inteiro para B: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("---------------------------------------------");

            int higherNumber;
            int smallestNumber;

            if (a > b)
            {
                higherNumber = a;
                smallestNumber = b;
            }
            else
            {
                higherNumber = b;
                smallestNumber = a;
            }



            if (higherNumber % smallestNumber == 0)
            {
                Console.WriteLine("\nOs números informados são múltiplos entre si");
            }
            else
            {
                Console.WriteLine("\nOs números informados não são múltiplos entre si");
            }
        }

        public static void Ex4()
        {
            //Leia a hora inicial e a hora final de um jogo
            //A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas

            Console.WriteLine("\nCONTAR HORAS DE JOGO");
            Console.WriteLine("-----------------------");
            Console.Write("\nHora inicial (24hr): ");
            int startTime = int.Parse(Console.ReadLine());
            Console.Write("\nHora final (24hr): ");
            int endTime = int.Parse(Console.ReadLine());
            Console.WriteLine("\n-----------------------");

            int amountFfGameHours = (24 - startTime) + endTime;

            if (amountFfGameHours > 24)
            {
                amountFfGameHours -= 24;
            }

            Console.WriteLine($"\nO jogo durou {amountFfGameHours} hora(s)");
        }

        public static void Ex5()
        {
            //Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item
            //A seguir, calcule e mostre o valor da conta a pagar

            Console.WriteLine("\n>>>>>>>>>>>>>>>>> DOGÃO DO RATÃO <<<<<<<<<<<<<<<<<");
            
            Console.WriteLine("\n                       MENU                       ");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("CODIGO          ESPECIFICAÇÃO               PREÇO");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("  1             Cachorro Quente            R$ 4,00");
            Console.WriteLine("  2             X-Salada                   R$ 4,50");
            Console.WriteLine("  3             X-Bacon                    R$ 5.00");
            Console.WriteLine("  4             Torrada Simples            R$ 2,00");
            Console.WriteLine("  5             Refrigerante               R$ 1,50");
            Console.WriteLine("--------------------------------------------------");

            Console.Write("\n\nInforme código e quantidade: ");
            string[] choice = Console.ReadLine().Split(' ');

            int itemCode = int.Parse(choice[0]);
            int itemQuantity = int.Parse(choice[1]);

            double itemPrice;

            if (itemCode == 1)
            {
                itemPrice = 4.0;
            }
            else if (itemCode == 2)
            {
                itemPrice = 4.5;
            }
            else if (itemCode == 3)
            {
                itemPrice = 5.0;
            }
            else if (itemCode == 4)
            {
                itemPrice = 2.0;
            }
            else
            {
                itemPrice = 1.50;
            }

            double amoountToPay = itemQuantity * itemPrice;

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"\nTotal: R$ {amoountToPay:F2}");
        }
    }
}
