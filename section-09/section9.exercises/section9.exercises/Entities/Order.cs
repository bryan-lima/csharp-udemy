using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using section9.exercises.Entities.Enums;

namespace section9.exercises.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }

        public OrderStatus Status { get; set; }

        public Client Client { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0.0;

            foreach (OrderItem orderItem in Items)
            {
                total += orderItem.SubTotal();
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Order moment: ");
            stringBuilder.AppendLine(Moment.ToString());
            stringBuilder.Append("Order status: ");
            stringBuilder.AppendLine(Status.ToString());
            stringBuilder.Append("Client: ");
            stringBuilder.Append(Client.Name);
            stringBuilder.Append(" (");
            stringBuilder.Append(Client.BirthDate.ToString("dd/MM/yyyy"));
            stringBuilder.Append(") - ");
            stringBuilder.AppendLine(Client.Email);
            stringBuilder.AppendLine("Order items:");

            foreach (OrderItem item in Items)
            {
                stringBuilder.Append(item.Product.Name);
                stringBuilder.Append(", $ ");
                stringBuilder.Append(item.Price.ToString("F2", CultureInfo.InvariantCulture));
                stringBuilder.Append(", Quantity: ");
                stringBuilder.Append(item.Quantity);
                stringBuilder.Append(", Subtotal: $ ");
                stringBuilder.AppendLine(item.SubTotal().ToString("F2", CultureInfo.InvariantCulture));
            }

            stringBuilder.Append("Total price: $ ");
            stringBuilder.AppendLine(Total().ToString("F2", CultureInfo.InvariantCulture));

            return stringBuilder.ToString();
        }
    }
}
