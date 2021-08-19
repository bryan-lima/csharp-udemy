using System;
using System.Collections.Generic;
using System.Globalization;
using Exercise.InheritanceAndPolymorphism.Entities;

namespace Exercise.InheritanceAndPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            Fazer um programa para ler os dados de N produtos(N fornecido pelo usuário).
            Ao final, mostrar a etiqueta de preço de cada produto na mesma ordem em que foram digitados.

            Todo produto possui nome e preço. 
            Produtos importados possuem uma taxa de alfândega, e produtos usados possuem data de fabricação.
            Estes dados específicos devem ser acrescentados na etiqueta de preço conforme exemplo(próxima página).
            Para produtos importados, a taxa e alfândega deve ser acrescentada ao preço final do produto.

            Favor implementar o programa conforme projeto abaixo.


                                         +------------------------+
                                         |        Product         |
                                         +------------------------+
                                         | - name: String         |
                                         | - price: Double        |
                                         +------------------------+
                                         | + priceTag(): String   |
                                         +------------------------+
                                                     /|\
                                                      |
                                   ___________________|___________________
                                   |                                     |
                                   |                                     |
                     +---------------------------+        +---------------------------+
                     |      ImportedProduct      |        |        UsedProduct        |
                     +---------------------------+        +---------------------------+
                     | - customsFee: Double      |        | - manufactureDate: Date   |
                     +---------------------------+        +---------------------------+
                     | + priceTag(): String      |        | + priceTag(): String      |
                     | + totalPrice(): Double    |        +---------------------------+
                     +---------------------------+


            */

            Console.Write("\n\nEnter the number of products: ");
            int quantityProducts = int.Parse(Console.ReadLine());

            List<Product> productList = new List<Product>();

            for (int i = 1; i <= quantityProducts; i++)
            {
                Console.WriteLine($"\n\nProduct #{i} data:");
                Console.WriteLine("----------------");

                string productType;

                while (true)
                {
                    Console.Write("\nCommom, used or imported (c/u/i)? ");
                    productType = Console.ReadLine().Trim().ToUpper();

                    if (productType == "C" || productType == "U" || productType == "I")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid answer! Just type C for Common, or U for Used, or I for Imported.");
                    }
                }

                Console.Write("Name: ");
                string productName = Console.ReadLine();

                Console.Write("Price: $ ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (productType == "U")
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime productManufactureDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                    productList.Add(new UsedProduct(productName, productPrice, productManufactureDate));
                }
                else if (productType == "I")
                {
                    Console.Write("Customs fee: $ ");
                    double productCustomsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    productList.Add(new ImportedProduct(productName, productPrice, productCustomsFee));
                }
                else
                {
                    productList.Add(new Product(productName, productPrice));
                }
            }

            Console.WriteLine("\n\n\n                    PRICE TAGS:");
            Console.WriteLine("---------------------------------------------------");

            foreach (Product product in productList)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
