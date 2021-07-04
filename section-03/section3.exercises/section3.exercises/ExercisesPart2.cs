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

        public static void Ex6()
        {
            //Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos seguintes intervalos([0,25], (25, 50], (50, 75], (75, 100]) este valor se encontra
            //Obviamente se o valor não estiver em nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”

            Console.Write("\n\nInforme um número: ");
            double anyNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (anyNumber >= 0 && anyNumber <= 25)
            {
                Console.WriteLine("\nIntervalo [0, 25]");
            }
            else if (anyNumber >= 25 && anyNumber <= 50)
            {
                Console.WriteLine("\nIntervalo [25, 50]");
            }
            else if (anyNumber >= 50 && anyNumber <= 75)
            {
                Console.WriteLine("\nIntervalo [50, 75]");
            }
            else if (anyNumber >= 75 && anyNumber <= 100)
            {
                Console.WriteLine("\nIntervalo [75, 100]");
            }
            else
            {
                Console.WriteLine("\nFora de intervalo");
            }
        }

        public static void Ex7()
        {
            //Leia 2 valores com uma casa decimal(x e y), que devem representar as coordenadas de um ponto em um plano
            //A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na origem(x = y = 0)
            //Se o ponto estiver na origem, escreva a mensagem “Origem”
            //Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação
            //
            //           Y
            //          |
            //    Q2    |    Q1
            //__________|__________ X
            //          |
            //    Q3    |    Q4
            //          |


            Console.WriteLine("\nCOORDENADAS");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.Write("Informe duas coordenadas para o ponto no plano cartesiano: ");
            string[] coordinates = Console.ReadLine().Split(' ');

            double axisX = double.Parse(coordinates[0], CultureInfo.InvariantCulture);
            double axisY = double.Parse(coordinates[1], CultureInfo.InvariantCulture);

            string position = "";

            if (axisX > 0 && axisY > 0)
            {
                position = "em Q1";
            }
            else if (axisX > 0 && axisY < 0)
            {
                position = "em Q4";
            }
            else if (axisX < 0 && axisY > 0)
            {
                position = "em Q2";
            }
            else if (axisX < 0 && axisY < 0)
            {
                position = "em Q3";
            }
            else if (axisX == 0 && axisY != 0)
            {
                position = "no Eixo X";
            }
            else if (axisX != 0 && axisY == 0)
            {
                position = "no Eixo Y";
            }
            else
            {
                position = "na Origem";
            }

            Console.WriteLine($"\n\nO ponto está {position}");

        }

        public static void Ex8()
        {
            //Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem que nele não existem políticos corruptos e os recursos arrecadados são utilizados em 
            //benefício da população, sem qualquer desvio
            //A moeda deste país é o Rombus, cujo símbolo é o R$
            //Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb
            //Em seguida, calcule e mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo

            //--------------------------------------------------
            //           Renda               | Imposto de Renda
            //-------------------------------+------------------
            // de 0.00 a R$ 2000.00          |      Isento
            // de R$ 2000.01 até R$ 3000.00  |        8%
            // de R$ 3000.01 até R$ 4500.00  |       18%
            // acima de R$ 4500.00           |       28%
            //-------------------------------+------------------

            //Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8 % apenas sobre R$ 1000.00, pois a faixa de salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda
            //No exemplo fornecido(abaixo), a taxa é de 8 % sobre R$ 1000.00 + 18 % sobre R$ 2.00, o que resulta em R$ 80.36 no total
            //O valor deve ser impresso com duas casas decimais

            Console.WriteLine("\n  CÁLCULO DE IMPOSTO DE RENDA (IR)");
            Console.WriteLine("----------------------------------------");
            Console.Write("\nInforme o salário: R$ ");
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine("\n----------------------------------------");
            Console.Write("\nImposto a pagar: ");

            double taxToPay = 0.0;
            double valueToConsiderForTaxCalculation = 0.0;

            if (salary <= 2000)
            {
                Console.WriteLine("ISENTO");
            }
            else if (salary >= 2000.01 && salary <= 3000)
            {
                valueToConsiderForTaxCalculation = salary - 2000;
                taxToPay = valueToConsiderForTaxCalculation * 0.08;
                Console.WriteLine($"R$ {taxToPay:F2}");
            }
            else if (salary >= 3000.01 && salary <= 4500)
            {
                double firstTaxRange = 1000 * 0.08;
                valueToConsiderForTaxCalculation = salary - 3000;
                taxToPay = firstTaxRange + (valueToConsiderForTaxCalculation * 0.18);
                Console.WriteLine($"R$ {taxToPay:F2}");
            }
            else
            {
                double firstTaxRange = 1000 * 0.08;
                double secondTaxRange = 1500 * 0.18;
                valueToConsiderForTaxCalculation = salary - 4500;
                taxToPay = firstTaxRange + secondTaxRange + (valueToConsiderForTaxCalculation * 0.28);
                Console.WriteLine($"R$ {taxToPay:F2}");
            }
        }
    }
}
