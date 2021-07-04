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
    }
}
