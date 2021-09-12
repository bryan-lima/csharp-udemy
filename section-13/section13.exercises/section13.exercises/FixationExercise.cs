using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace section13.exercises
{
    class FixationExercise
    {
        public static void Exercise()
        {
            /*

            Fazer um programa para ler o caminho de um arquivo .csv contendo os dados de itens vendidos.
            Cada item possui um nome, preço unitário e quantidade, separados por vírgula. 
            Você deve gerar um novo arquivo chamado "summary.csv", localizado em uma subpasta chamada "out" a partir da pasta original do arquivo de origem, 
            contendo apenas o nome e o valor total para aquele item (preço unitário multiplicado pela quantidade), conforme exemplo.

            */

            string sourcePathFile = @"..\..\..\FixationExercise\sales.csv"; // Caminho relativo
            string targetPathFile = Path.GetDirectoryName(sourcePathFile) + @"\out\summary.csv";

            Directory.CreateDirectory(Path.GetDirectoryName(sourcePathFile) + @"\out");

            try
            {
                string[] sales = File.ReadAllLines(sourcePathFile);

                using (StreamWriter streamWriter = File.AppendText(targetPathFile))
                {
                    foreach (string sale in sales)
                    {
                        string[] saleSplited = sale.Trim().Split(",");
                        string saleProduct = saleSplited[0];
                        double salePrice = double.Parse(saleSplited[1], CultureInfo.InvariantCulture);
                        int saleQuantity = int.Parse(saleSplited[2]);

                        double saleTotal = salePrice * saleQuantity;

                        string saleSummary = $"{saleProduct},{saleTotal.ToString("F2", CultureInfo.InvariantCulture)}";

                        streamWriter.WriteLine(saleSummary);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
