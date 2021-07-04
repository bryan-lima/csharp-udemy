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
    }
}
