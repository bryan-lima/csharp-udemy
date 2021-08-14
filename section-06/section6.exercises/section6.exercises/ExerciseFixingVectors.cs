using System;
using System.Collections.Generic;
using System.Text;

namespace section6.exercises
{
    class ExerciseFixingVectors
    {
        public static void Ex01()
        {
            Console.Write("\nQuantos quartos serão alugados? ");
            int numberOfRents = int.Parse(Console.ReadLine());

            int i = 0;

            Student[] rentalRooms = new Student[10];

            while (i < numberOfRents)
            {
                Console.WriteLine($"\nALUGUEL # {i + 1}:");
                Console.Write("Nome: ");
                string nameStudent = Console.ReadLine();

                Console.Write("Email: ");
                string emailStudent = Console.ReadLine();

                Console.Write("Número quarto: ");
                int roomNumber = int.Parse(Console.ReadLine());

                rentalRooms[roomNumber] = new Student(nameStudent, emailStudent, roomNumber);

                i++;
            }

            Console.WriteLine("\n\nQUARTOS OCUPADOS:");
            Console.WriteLine("-----------------");

            for (int room = 0; room < rentalRooms.Length; room++)
            {
                if (rentalRooms[room] != null)
                {
                    Console.WriteLine($"{room}: {rentalRooms[room].Name}, {rentalRooms[room].Email}");
                }
            }
        }
    }
}
