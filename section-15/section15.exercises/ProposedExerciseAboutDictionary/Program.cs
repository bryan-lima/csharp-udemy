using System;
using System.Collections.Generic;
using System.IO;

namespace ProposedExerciseAboutDictionary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*

            Na contagem de votos de uma eleição, são gerados vários registros de votação contendo o nome do candidato e a quantidade de votos (formato .csv) que ele obteve em uma urna de votação.
            Você deve fazer um programa para ler os registros de votação a partir de um arquivo, e daí gerar um relatório consolidado com os totais de cada candidato.

            */

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader streamReader = File.OpenText(path))
                {
                    Dictionary<string, int> voting = new Dictionary<string, int>();

                    while (!streamReader.EndOfStream)
                    {
                        string[] candidateVotes = streamReader.ReadLine().Split(",");
                        string candidate = candidateVotes[0];
                        int votes = int.Parse(candidateVotes[1]);

                        if (voting.ContainsKey(candidate))
                        {
                            voting[candidate] += votes;
                        }
                        else
                        {
                            voting[candidate] = votes;
                        }
                    }

                    Console.WriteLine();

                    foreach (KeyValuePair<string, int> vote in voting)
                    {
                        Console.WriteLine($"{vote.Key} : {vote.Value}");
                    }
                }
            }
            catch (IOException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}