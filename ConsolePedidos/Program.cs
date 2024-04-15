using ConsolePedidos.Entities.Clients;
using ConsolePedidos.Entities.OrderItems;
using ConsolePedidos.Entities.Orders;
using ConsolePedidos.Entities.Products;
using ConsolePedidos.Enum;
using System.Globalization;
using System.Transactions;

namespace ConsolePedidos
{

    class Program
    {

        public static void Main(string[] args)
        {
            Order order = null;
            
            Console.WriteLine("#################### Enter Cliente data:");
            Console.WriteLine("Name");
            string clientName = Console.ReadLine();
            Console.WriteLine("Email");
            string clientemail = Console.ReadLine();
            Console.WriteLine("Birth Date: ");
            DateTime clienBirth = DateTime.Parse( Console.ReadLine());
            Console.WriteLine("#################### Enter Order data:  PENDING_PAYMENT = 0, PROCESSING = 1, SHIPPED = 2, DELIVERED = 3 ");
            int status = int.Parse(Console.ReadLine());
            Console.WriteLine("How many items  to this order ?");
            int QtdOrder = int.Parse(Console.ReadLine());
            for (int i = 0; i < QtdOrder; i++)
            {
                Console.WriteLine($"Enter #{1} Data: ");
                Console.WriteLine("Product Name: ");
                string? productName = Console.ReadLine();
                Console.WriteLine("Product Price: ");
                double productPrice = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Quantity:");
                int productquantity = int.Parse(Console.ReadLine());

                order = new Order(DateTime.Now, (OrderStatus)status);
                OrderItem item = new OrderItem(productquantity, productPrice);
                
                Client client = new Client(clientName, clientemail, clienBirth);
                item.addProduto(productName, productPrice);
                order.addItem(item);
                order.addCLient(client);
            }
            Console.WriteLine(order.ToString());
        }
    }
}