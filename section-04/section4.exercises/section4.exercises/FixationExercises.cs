using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace section4.exercises
{
    class FixationExercises
    {
        public static void Ex01()
        {
            //Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por uma pessoa em reais
            //Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda que a pessoa terá que pagar 6 % de IOF sobre o valor em dólar
            //Criar uma classe ConversorDeMoeda para ser responsável pelos cálculos.

            Console.WriteLine("\n         CONVERSOR DE MOEDA");
            Console.WriteLine("-------------------------------------------");
            

            Console.Write("\nQual é a cotação do dólar? ");
            double currentDollarQquote = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("\nQuantos dólares você irá comprar? ");
            double dollarAmountBuy = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nValor a ser pago em reais: R$ " + CurrencyConverter.ConvertFromDollarToReal(currentDollarQquote, dollarAmountBuy).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
