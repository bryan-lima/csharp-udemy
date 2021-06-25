using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace section3.exercises
{
    class DataOutput
    {
        public static void CSharpDataOutput()
        {
            string product1 = "Computador"; ;
            string product2 = "Mesa de escritório";

            byte age = 30;
            int code = 5290;
            char gender = 'M';

            double price1 = 2100.0;
            double price2 = 650.50;
            double measure = 53.234567;


            Console.WriteLine("\nPRODUTOS");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"{product1}, cujo preço é $ {price1:F2}");
            Console.WriteLine($"{product2}, cujo preço é $ {price2:F2}\n\n");

            Console.WriteLine($"Registro: {age} anos de idade, código {code} e gênero: {gender}\n\n");

            Console.WriteLine($"Medida com oito casas decimais: {measure:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {measure:F3}");
            Console.WriteLine("Separador decimal invariante culture: " + measure.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("---------------------------------------------------");
        }
    }
}
