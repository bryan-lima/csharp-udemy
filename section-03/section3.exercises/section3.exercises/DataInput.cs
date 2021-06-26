using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace section3.exercises
{
    class DataInput
    {
        public static void CSharpDataInput()
        {
            Console.WriteLine("\nFORMULÁRIO DE CADASTRO");
            Console.WriteLine("------------------------------------------------------------\n");

            Console.WriteLine("Entre com seu nome completo:");
            Console.Write(">> ");
            string name = Console.ReadLine();

            Console.WriteLine("\nQuantos quartos tem na sua casa?");
            Console.Write(">> ");
            int numberOfRooms = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEntre com o preço de um produto:");
            Console.Write(">> ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nEntre seu último nome, idade e altura (mesma linha):");
            Console.Write(">> ");
            string[] longAnswer = Console.ReadLine().Split(' ');

            string lastName = longAnswer[0];
            int age = int.Parse(longAnswer[1]);
            double height = double.Parse(longAnswer[2], CultureInfo.InvariantCulture);

            Console.WriteLine("------------------------------------------------------------\n");

            Console.WriteLine($"Nome: {name}");
            Console.WriteLine($"Quantidade quartos: {numberOfRooms}");
            Console.WriteLine("Preço do produto: " + price.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine($"Último nome: {lastName}");
            Console.WriteLine($"Idade: {age}");
            Console.WriteLine("Altura: " + height.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
