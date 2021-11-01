using System;
using System.Collections.Generic;

namespace ProposedExerciseAboutSets
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*

            Em um portal de cursos online, cada usuário possui um código único, representado por um número inteiro.

            Cada instrutor do portal pode ter vários cursos, sendo que um mesmo aluno pode se matricular em quantos cursos quiser.
            Assim, o número total de alunos de um instrutor não é simplesmente a soma dos alunos de todos os cursos que ele possui, pois pode haver alunos repetidos em mais de um curso.

            O instrutor Alex possui três cursos A, B e C, e deseja saber seu número total de alunos.

            Seu programa deve ler os alunos dos cursos A, B e C do instrutor Alex, depois mostrar a quantidade total e alunos dele, conforme exemplo.

            */

            HashSet<int> studentsCourseA = new HashSet<int>();
            HashSet<int> studentsCourseB = new HashSet<int>();
            HashSet<int> studentsCourseC = new HashSet<int>();

            Console.Write("\nHow many students for course A?: ");
            int numberStudentsCourse = int.Parse(Console.ReadLine());
            ReadUserResponse(numberStudentsCourse, studentsCourseA);

            Console.Write("\nHow many students for course B?: ");
            numberStudentsCourse = int.Parse(Console.ReadLine());
            ReadUserResponse(numberStudentsCourse, studentsCourseB);

            Console.Write("\nHow many students for course C?: ");
            numberStudentsCourse = int.Parse(Console.ReadLine());
            ReadUserResponse(numberStudentsCourse, studentsCourseC);

            HashSet<int> totalStudents = new HashSet<int>(studentsCourseA);
            totalStudents.UnionWith(studentsCourseB);
            totalStudents.UnionWith(studentsCourseC);

            Console.WriteLine($"\n\nTotal students: {totalStudents.Count}");
        }

        public static void ReadUserResponse(int numberStudentsCourse, HashSet<int> hashSetStudent)
        {
            for (int index = 0; index < numberStudentsCourse; index++)
            {
                int codeStudent = int.Parse(Console.ReadLine());
                hashSetStudent.Add(codeStudent);
            }
        }
    }
}