using System;

namespace section4.exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1(); // Aula 40. Primeiros exercícios (classes, objetos e atributos)
            Ex2(); // Aula 40. Primeiros exercícios (classes, objetos e atributos)
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

        static void Ex2()
        {
            //Fazer um programa para ler nome e salário de dois funcionários
            //Depois, mostrar o salário médio dos funcionários

            Console.WriteLine("\n               FUNCIONÁRIOS");
            Console.WriteLine("--------------------------------------------");

            Functionary f1 = new Functionary();
            Console.WriteLine("\nDados do primeiro funcionário:");
            Console.WriteLine("------------------------------");
            Console.Write("Nome: ");
            f1.name = Console.ReadLine();
            Console.Write("Salário: R$ ");
            f1.salary = double.Parse(Console.ReadLine());

            Functionary f2 = new Functionary();
            Console.WriteLine("\n\nDados do segundo funcionário:");
            Console.WriteLine("------------------------------");
            Console.Write("Nome: ");
            f2.name = Console.ReadLine();
            Console.Write("Salário: R$ ");
            f2.salary = double.Parse(Console.ReadLine());

            double averageSalary = (f1.salary + f2.salary) / 2;

            Console.WriteLine($"\n\nSalário médio: R$ {averageSalary:F2}");
        }
    }
}
