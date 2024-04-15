using ConsolePedidos.Enum;
using ConsolePedidos.Entities.OrderItems;
using ConsolePedidos.Entities.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsolePedidos.Entities.Products;
using System.Net.Http.Json;

namespace ConsolePedidos.Entities.Orders
{
    class Order
    {
        public DateTime moment { get; set; }
        public OrderStatus status { get; set; }

        public  List<OrderItem> orderItem { get; set; } = new List<OrderItem>();
        public List<Client> client { get; set; } = new List<Client>();

        public Order()
        {
            this.moment = DateTime.Now;
        }

        public Order(DateTime moment, OrderStatus status)
        {
            this.moment = DateTime.Now;
            this.status = status;
        }

        public void addItem(OrderItem item)
        {
            orderItem.Add(item);
        }
        public void removeItem(OrderItem item)
        {
            orderItem.Remove(item);
        }

        public void addCLient(Client addclient) {
            client.Add(addclient);

        }

        public string getClient() {

            return client[0].ToString(); 
        }

        public string getOrderItems()
        {
            StringBuilder sbItem = new StringBuilder();

            foreach (OrderItem item in orderItem)
            {
                sbItem.AppendLine(item.getProdutos());
                sbItem.AppendLine("Qtd: "+item.Quantity.ToString());
                sbItem.AppendLine("Subtotal: "+item.subTotal().ToString());
            }
            return sbItem.ToString();
        }
        public override string ToString()
        {
            StringBuilder sbOrder = new StringBuilder();
            sbOrder.Append("Order moment ");
            sbOrder.AppendLine(moment.ToString());
            sbOrder.Append("Order status ");
            sbOrder.AppendLine(status.ToString());
            sbOrder.Append("Client ");
            sbOrder.AppendLine(this.getClient());
            sbOrder.AppendLine("Order Items");
            sbOrder.AppendLine(this.getOrderItems());
            return sbOrder.ToString();       
        }

    }
}
