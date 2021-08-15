using System;
using System.Collections.Generic;
using System.Text;

namespace section6.exercises
{
    class ExerciseFixingMatrices
    {
        public static void Ex01()
        {
            /*
            
            Fazer um programa para ler dois números inteiros M e N, e depois ler uma matriz de M linhas por N colunas contendo números inteiros, podendo haver repetições.
            Em seguida, ler um número inteiro X que pertence à matriz.
            Para cada ocorrência de X, mostrar os valores à esquerda, acima, à direita e abaixo de X, quando houver, conforme exemplo.
            
             */

            Console.WriteLine("\n\n      MATRIZES");
            Console.WriteLine("--------------------");

            Console.Write("\nInforme quantidade de linhas (N) e quantidade de colunas (M), separados por espaço [N M]: ");
            string[] matrixDefinition = Console.ReadLine().Split(" ");

            int numberMatrixLines = int.Parse(matrixDefinition[0]);
            int numberMatrixColumns = int.Parse(matrixDefinition[1]);

            int[,] numericalMatrix = new int[numberMatrixLines, numberMatrixColumns];

            for (int row = 0; row < numberMatrixLines; row++)
            {
                Console.Write($"\nInforme {numberMatrixColumns} números para a linha #{row}, separados por espaço [1 2 3 ...]: ");
                string[] values = Console.ReadLine().Split(" ");

                for (int column = 0; column < numberMatrixColumns; column++)
                {
                    numericalMatrix[row, column] = int.Parse(values[column]);
                }
            }

            //Console.WriteLine($"numericalMatrix.GetLength(0) = {numericalMatrix.GetLength(0) - 1}");
            //Console.WriteLine($"numericalMatrix.GetLength(1) = {numericalMatrix.GetLength(1) - 1}");

            Console.Write("\n\nInforme um número que contenha na matriz: ");
            int chosenNumber = int.Parse(Console.ReadLine());


            for (int row = 0; row < numberMatrixLines; row++)
            {
                for (int column = 0; column < numberMatrixColumns; column++)
                {
                    if (numericalMatrix[row, column] == chosenNumber)
                    {
                        Console.WriteLine($"\nPosição: [{row}, {column}]");

                        int matrixRow = row;
                        int matrixColumn = column;

                        #region verifica à esquerda
                        if ((column - 1) >= 0)
                        {
                            Console.WriteLine($"Número à esquerda: {numericalMatrix[matrixRow, --matrixColumn]}");
                        }
                        #endregion

                        matrixRow = row;
                        matrixColumn = column;

                        #region verifica à direita
                        if (column < (numericalMatrix.GetLength(1) - 1))
                        {
                            Console.WriteLine($"Número à direita: {numericalMatrix[matrixRow, ++matrixColumn]}");
                        }
                        #endregion

                        matrixRow = row;
                        matrixColumn = column;

                        #region verifica acima
                        if ((row - 1) >= 0 )
                        {
                            Console.WriteLine($"Número acima: {numericalMatrix[--matrixRow, matrixColumn]}");
                        }
                        #endregion

                        matrixRow = row;
                        matrixColumn = column;

                        #region verifica abaixo
                        if (row < (numericalMatrix.GetLength(0) - 1))
                        {
                            Console.WriteLine($"Número abaixo: {numericalMatrix[++matrixRow, matrixColumn]}");
                        }
                        #endregion
                    }
                }
            }
        }
    }
}
