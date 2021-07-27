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
    }
}
