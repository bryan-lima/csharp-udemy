using System;
using System.Collections.Generic;
using System.Text;

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




        }
    }
}
