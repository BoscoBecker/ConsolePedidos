using ConsolePedidos.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePedidos.Entities.OrderItems
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public List<OrderItem> orderItem { get; set; } = new List<OrderItem>();

        public List<Product> produto { get; set; } = new List<Product>();

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }

        public void addProduto(string nome, double preco)
        {
            Product produtoNovo = new Product { name = nome, price = preco };
            produto.Add(produtoNovo);
        }
        public string getProdutos()
        {
            StringBuilder strProd = new StringBuilder();
            foreach (Product prod in produto){
                strProd.AppendLine($"Nome: {prod.name}, Preço: {prod.price}");
            }
            return strProd.ToString();
        }
        public double subTotal()
        {
            return (Quantity * Price);
        }


    }
}
