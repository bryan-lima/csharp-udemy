using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using section10.exercises.Entities;
using section10.exercises.Entities.Enums;

namespace section10.exercises
{
    class SolvedExercise
    {
        public static void InheritanceAndPolymorphism()
        {
            /*
            
            Uma empresa possui funcionários próprios e terceirizados.
            Para cada funcionário, deseja - se registrar nome, horas trabalhadas e valor por hora.
            Funcionários terceirizados possuem ainda uma despesa adicional.

            O pagamento dos funcionários corresponde ao valor da hora multiplicado pelas horas trabalhadas, sendo que os funcionários terceirizados ainda recebem um bônus correspondente a 110 % de sua despesa adicional.
            
            Fazer um programa para ler os dados de N funcionários(N fornecido pelo usuário) e armazená-los em uma lista.
            Depois de ler todos os dados, mostrar nome e pagamento de cada funcionário na mesma ordem em que foram digitados.
            
            Construa o programa conforme projeto abaixo.


                      +---------------------------+
                      |          Employee         |
                      +---------------------------+
                      | - name: String            |
                      | - valuePerHour: Double    |
                      +---------------------------+
                      | + payment(): Double       |
                      +---------------------------+
                                  /|\
                                   |
                                   |
                   +---------------------------------+
                   |       OutsourcedEmployee        |
                   +---------------------------------+
                   | - additionalCharge: Double      |
                   +---------------------------------+
                   | + payment(): Double             |
                   +---------------------------------+

            */

            Console.Write("\nEnter the number of employees: ");
            int numberOfEmployees = int.Parse(Console.ReadLine());

            List<Employee> employeeList = new List<Employee>();

            for (int i = 1; i <= numberOfEmployees; i++)
            {
                Console.WriteLine($"\n\nEmployee #{i} data:");
                Console.WriteLine("-----------------");

                bool hasOutsourced = false;

                while (true)
                {
                    Console.Write("\nOutsourced (y/n)? ");
                    string answerIfIsOutsourced = Console.ReadLine();

                    if (answerIfIsOutsourced.Trim().ToUpper() == "Y")
                    {
                        hasOutsourced = true;
                        break;
                    }
                    else if (answerIfIsOutsourced.Trim().ToUpper() == "N")
                    {
                        hasOutsourced = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid answer! Just type Y or N.");
                    }
                }

                Console.Write("Name: ");
                string employeeName = Console.ReadLine();

                Console.Write("Hours: ");
                int employeeHours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: $ ");
                double employeeValuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (hasOutsourced)
                {
                    Console.Write("Additional charge: $ ");
                    double outsourcedEmployeeAdditionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    employeeList.Add(new OutsourcedEmployee(employeeName, employeeHours, employeeValuePerHour, outsourcedEmployeeAdditionalCharge));
                }
                else
                {
                    employeeList.Add(new Employee(employeeName, employeeHours, employeeValuePerHour));
                }
            }

            Console.WriteLine("\n\n\n                    PAYMENTS:");
            Console.WriteLine("-------------------------------------------------");

            foreach (Employee employee in employeeList)
            {
                Console.WriteLine(employee);
            }
        }

        public static void AbstractMethods()
        {
            /*

            Fazer um programa para ler os dados de N figuras(N fornecido pelo usuário), e depois mostrar as áreas destas figuras na mesma ordem em que foram digitadas.

            */

            Console.Write("\n\nEnter the number of shapes: ");
            int numberOfShapes = int.Parse(Console.ReadLine());

            List<Shape> shapeList = new List<Shape>();

            for (int i = 1; i <= numberOfShapes; i++)
            {
                Console.WriteLine($"\nShape #{i} data:");
                Console.WriteLine("--------------");

                string shapeType;

                while (true)
                {
                    Console.Write("\nRectangle or Circle (r/c)? ");
                    shapeType = Console.ReadLine().Trim().ToUpper();

                    if (shapeType == "R" || shapeType == "C")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid answer! Just type R for Rectangular or C for Circle.");
                    }
                }

                Color shapeColor;

                while (true)
                {
                    Console.Write("Color (Black/Blue/Red): ");
                    string chooseShapeColor = Console.ReadLine().Trim();
                    chooseShapeColor = char.ToUpper(chooseShapeColor[0]) + chooseShapeColor.Substring(1).ToLower();

                    if (chooseShapeColor == "Black" || chooseShapeColor == "Blue" || chooseShapeColor == "Red")
                    {
                        shapeColor = Enum.Parse<Color>(chooseShapeColor);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid answer! Just type Black, or Blue, or Red.");
                    }
                }

                if (shapeType == "R")
                {
                    Console.Write("Width: ");
                    double shapeWidth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Height: ");
                    double shapeHeight = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapeList.Add(new Rectangle(shapeWidth, shapeHeight, shapeColor));
                }
                else if (shapeType == "C")
                {
                    Console.Write("Radius: ");
                    double shapeRadius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapeList.Add(new Circle(shapeRadius, shapeColor));
                }
            }

            Console.WriteLine("\n\n\nSHAPE AREAS:");
            Console.WriteLine("------------");

            foreach (Shape shape in shapeList)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
