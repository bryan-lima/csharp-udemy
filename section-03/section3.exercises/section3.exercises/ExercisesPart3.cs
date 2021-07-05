using System;
using System.Collections.Generic;
using System.Text;

namespace section3.exercises
{
    class ExercisesPart3
    {
        public static void Ex1()
        {
            //Escreva um programa que repita a leitura de uma senha até que ela seja válida
            //Para cada leitura de senha incorreta informada, escrever a mensagem "Senha Invalida"
            //Quando a senha for informada corretamente deve ser impressa a mensagem "Acesso Permitido" e o algoritmo encerrado
            //Considere que a senha correta é o valor 2002

            Console.WriteLine("\n AUTENTICADOR");
            Console.WriteLine("----------------");
            Console.Write("\nInforme a senha: ");

            int PASSWORD = 2002;

            int passwd = int.Parse(Console.ReadLine());

            while (passwd != PASSWORD)
            {
                Console.WriteLine("\nSenha inválida!\nTente novamente.");
                Console.Write("\nInforme a senha: ");
                passwd = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nAcesso permitido!");
        }

        public static void Ex2()
        {
            //Escreva um programa para ler as coordenadas (X, Y) de uma quantidade indeterminada de pontos no sistema cartesiano
            //Para cada ponto escrever o quadrante a que ele pertence
            //O algoritmo será encerrado quando pelo menos uma de duas coordenadas for NULA(nesta situação sem escrever mensagem alguma)

            Console.WriteLine("\nPLANO CARTESIANO");
            Console.WriteLine("-------------------");

            Console.Write("Informe as coordenadas X e Y: ");
            string[] coordinates = Console.ReadLine().Split(' ');
            int coordinateX = int.Parse(coordinates[0]);
            int coordinateY = int.Parse(coordinates[1]);

            while (coordinateX != 0 && coordinateY != 0)
            {
                if (coordinateX > 0 && coordinateY > 0)
                {
                    Console.WriteLine("\nPrimeiro quadrante");
                }
                else if (coordinateX > 0 && coordinateY < 0)
                {
                    Console.WriteLine("\nQuarto quadrante");
                }
                else if (coordinateX < 0 && coordinateY > 0)
                {
                    Console.WriteLine("\nSegundo quadrante");
                }
                else if (coordinateX < 0 & coordinateY < 0)
                {
                    Console.WriteLine("\nTerceiro quadrante");
                }

                Console.Write("\nInforme novas coordenadas X e Y: ");
                coordinates = Console.ReadLine().Split(' ');
                coordinateX = int.Parse(coordinates[0]);
                coordinateY = int.Parse(coordinates[1]);
            }
        }

        public static void Ex3()
        {
            //Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes
            //Escreva um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 4.Fim)
            //Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até que seja válido)
            //O programa será encerrado quando o código informado for o número 4
            //Deve ser escrito a mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme exemplo

            Console.WriteLine("\n\n    POSTO DE COMBUSTÍVEL TABAJARA - PESQUISA");
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("            +------+-----------+");
            Console.WriteLine("            | CÓD. | DESCRIÇÃO |");
            Console.WriteLine("            +------+-----------+");
            Console.WriteLine("            |  1   | Álcool    |");
            Console.WriteLine("            |  2   | Gasolina  |");
            Console.WriteLine("            |  3   | Diesel    |");
            Console.WriteLine("            |  4   | Fim       |");
            Console.WriteLine("            +------+-----------+");

            Console.WriteLine("\nInforme os valores, uma linha por vez:");
            Console.Write(">> ");
            int option = int.Parse(Console.ReadLine());

            int counterAlcohol = 0;
            int counterGasoline = 0;
            int counterDiesel = 0;

            while (option != 4)
            {
                if (option == 1)
                    counterAlcohol += 1;

                if (option == 2)
                    counterGasoline += 1;

                if (option == 3)
                    counterDiesel += 1;

                Console.Write(">> ");
                option = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n\n  MUITO OBRIGADO!");
            Console.WriteLine("------------------");
            Console.WriteLine($"Álcool: {counterAlcohol}");
            Console.WriteLine($"Gasolina: {counterGasoline}");
            Console.WriteLine($"Diesel: {counterDiesel}");
        }
    }
}
