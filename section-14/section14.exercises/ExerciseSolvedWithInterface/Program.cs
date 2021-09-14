using System;
using System.Globalization;
using ExerciseSolvedWithInterface.Entities;
using ExerciseSolvedWithInterface.Services;

namespace ExerciseSolvedWithInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEnter rental data:");
            Console.WriteLine("------------------");
            Console.Write("Car model: ");
            string carModel = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyy hh:mm): ");
            DateTime rentalStart = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyy hh:mm): ");
            DateTime rentalFinish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Enter price per hour: ");
            double pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double pricePerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(rentalStart, rentalFinish, new Vehicle(carModel));

            RentalService rentalService = new RentalService(pricePerHour, pricePerDay, new BrazilTaxService());

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("\n\nINVOICE:");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
