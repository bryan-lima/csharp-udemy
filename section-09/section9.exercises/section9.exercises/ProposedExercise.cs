using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using section9.exercises.Entities;
using section9.exercises.Entities.Enums;

namespace section9.exercises
{
    class ProposedExercise
    {
        public static void Exercise()
        {
            /*
            
            Ler os dados de um pedido com N itens(N fornecido pelo usuário).
            Depois, mostrar um sumário do pedido conforme exemplo (próxima página).
            Nota: o instante do pedido deve ser o instante do sistema: DateTime.Now


            +--------------------------------------+                       
            |                 Order                |                       +-------------------------+
            +--------------------------------------+                       |        OrderItem        |                         +-------------------+
            | - moment: Date                       |              - items  +-------------------------+              - product  |      Product      |
            | - status: OrderStatus                | /\___________________\| - quantity: Integer     |________________________\+-------------------+
            +--------------------------------------+ \/                   /| - price: Double         |                        /| - name: String    |
            | + addItem(item: OrderItem): void     |                    *  +-------------------------+                      1  | - price: Double   |
            | + removeItem(item: OrderItem): void  |                       | + subTotal(): Double    |                         +-------------------+
            | + total(): Double                    |                       +-------------------------+                         +-------------------+
            +--------------------------------------+
                               |
                               |
                               |                                                       +----------------------------------------------------------+
                               |                                                       |                                                          |
                            1  | - client                                              |                                                          |
                              \|/                                                      |                                                          |
                   +-----------------------+                                           |                                                          |
                   |         Client        |                                           |            +--------------------------------+            |
                   +-----------------------+                                           |            |            <<enum>>            |            |
                   | - name: String        |                                           |            |           OrderStatus          |            |
                   | - email: String       |                                           |            +--------------------------------+            |
                   | - birthDate: Date     |                                           |            | - PENDING_PAYMENT: int = 0     |            |
                   +-----------------------+                                           |            | - PROCESSING: int = 1          |            |
                   +-----------------------+                                           |            | - SHIPPED: int = 2             |            |
                                                                                       |            | - DELIVERED: int = 3           |            |
                                                                                       |            +--------------------------------+            |
                                                                                       |            +--------------------------------+            |
                                                                                       |                                                          |
                                                                                       |                                                          |
                                                                                       |                                                          |
                                                                                       +----------------------------------------------------------+
            
            */

            #region Client Data
            Console.WriteLine("\nEnter client data:");
            Console.WriteLine("------------------");
            
            Console.Write("Name: ");
            string clientName = Console.ReadLine();

            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();

            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime clientBirthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Client client = new Client(clientName,clientEmail, clientBirthDate);
            #endregion

            #region Order Data
            Console.WriteLine("\n\nEnter order data:");
            Console.WriteLine("-----------------");

            Console.Write("Status: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, orderStatus, client);

            Console.Write("\nHow many items to this order? ");
            int quantityItems = int.Parse(Console.ReadLine());

            for(int item = 1; item <= quantityItems; item++)
            {
                Console.WriteLine($"\nEnter {item}# item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                Console.Write("Product price: $ ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(productQuantity, productPrice, product);
                order.AddItem(orderItem);
            }
            #endregion

            #region Order Summary
            Console.WriteLine("\n\n                    ORDER SUMMARY");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine(order);
            #endregion
        }
    }
}
