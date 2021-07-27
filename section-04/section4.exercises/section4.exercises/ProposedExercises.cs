using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace section4.exercises
{
    class ProposedExercises
    {
        public static void Ex01()
        {
            /*
            Fazer um programa para ler os valores da largura e altura de um retângulo
            Em seguida, mostrar na tela o valor de sua área, perímetro e diagonal
            Usar uma classe como mostrado no projeto ao lado

            +----------------------------+
            |         Retângulo          |
            +----------------------------+
            | - Largura: double          |
            | - Altura: double           |
            +----------------------------+
            | + Area(): double           |
            | + Perimetro(): double      |
            | + Diagonal(): double       |
            +----------------------------+

            */

            Rectangle rectangle = new Rectangle();

            Console.Write("Informe a largura do retângulo: ");
            rectangle.width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("\nInforme a altura do retângulo: ");
            rectangle.height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("ÁREA = " + rectangle.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + rectangle.Perimeter().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + rectangle.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }

        public static void Ex02()
        {
            /*
            Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto)
            Em seguida, mostrar os dados do funcionário (nome e salário líquido)
            Em seguida, aumentar o salário do funcionário com base em uma porcentagem dada (somente o salário bruto é afetado pela porcentagem) e mostrar novamente os dados do funcionário
            Use a classe projetada abaixo

            +------------------------------------------------+
            |                  Funcionário                   |
            +------------------------------------------------+
            | - Nome: string                                 |
            | - SalarioBruto: double                         |
            | - Imposto: double                              |
            +------------------------------------------------+
            | + SalarioLiquido(): double                     |
            | + AumentarSalario(porcentagem: double): void   |
            +------------------------------------------------+

            */

            Worker worker = new Worker();

            Console.WriteLine("\n         DADOS DO FUNCIONÁRIO");
            Console.WriteLine("-------------------------------------------");

            Console.Write("\nNome: ");
            worker.Name = Console.ReadLine();

            Console.Write("\nSalário bruto: R$ ");
            worker.GrossSalary = double.Parse(Console.ReadLine());

            Console.Write("\nImposto: R$ ");
            worker.Tax = double.Parse(Console.ReadLine());

            //worker.NetSalary();

            Console.WriteLine($"\n\nFuncionário: {worker}");

            Console.Write("\nInforme a porcentagem para aumento de salário: ");
            double increasePercentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            worker.RaiseSalary(increasePercentage);

            Console.WriteLine($"\nDados atualizados: {worker}");
        }
    }
}
