using System;

namespace section4.exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex1(); // Aula 40. Primeiros exercícios (classes, objetos e atributos)
        }

        static void Ex1()
        {

            //Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha

            Console.WriteLine("\n                   CADASTRO");
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("\n1º Cadastro:");
            Console.WriteLine("------------");
            People p1 = new People();
            Console.Write("\nNome: ");
            p1.name = Console.ReadLine();
            Console.Write("Idade: ");
            p1.age = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\n2º Cadastro:");
            Console.WriteLine("------------");
            People p2 = new People();
            Console.Write("\nNome: ");
            p2.name = Console.ReadLine();
            Console.Write("Idade: ");
            p2.age = int.Parse(Console.ReadLine());

            string oldPerson = "";

            if (p1.age > p2.age)
            {
                oldPerson = p1.name;
            }
            else
            {
                oldPerson = p2.name;
            }

            Console.WriteLine($"\n\nA pessoa mais velha cadastrada é: {oldPerson}");
        }
    }
}
