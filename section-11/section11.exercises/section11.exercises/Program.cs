using System;
using section11.exercises.Entities;

namespace section11.exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            # Aulas 143, 144 e 145. Criando exceções personalizadas - Partes 1, 2 e 3

            Fazer um programa para ler os dados de uma reserva de hotel (número do quarto, data de entrada e data de saída) e mostrar os dados da reserva, inclusive sua duração em dias.
            Em seguida, ler novas datas de entrada e saída, atualizar a reserva, e mostrar novamente a reserva com os dados atualizados.
            O programa não deve aceitar dados inválidos para a reserva, conforme as seguintes regras:
             - Alterações de reserva só podem ocorrer para datas futuras
             - A data de saída deve ser maior que a data de entrada
             
            
                            +--------------------------------------------------------+
                            |                      Reservation                       |
                            +--------------------------------------------------------+
                            | - roomNumber: Integer                                  |
                            | - ckeckIn: Date                                        |
                            | - checkOut: Date                                       |
                            +--------------------------------------------------------+
                            | + duration(): Integer                                  |
                            | + updateDates(checkIn: Date, checkOut: Date): void     |
                            +--------------------------------------------------------+


            */

            Console.Write("\nRoom number: ");
            int roomNumber = int.Parse(Console.ReadLine());

            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());

            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if (checkOut <= checkIn)
            {
                Console.WriteLine("\nError in reservation: Check-out date must be after check-in date!");
            }
            else
            {

                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine($"\nReservation: {reservation}");

                Console.WriteLine("\nEnter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;

                if (checkIn < now || checkOut < now)
                {
                    Console.WriteLine("\nError in reservation: Reservation dates for update must be future dates!");
                }
                else if (checkOut <= checkIn)
                {
                    Console.WriteLine("\nError in reservation: Check-out date must be after check-in date!");
                }
                else
                {
                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine($"\nReservation: {reservation}");
                }
            }
        }
    }
}
