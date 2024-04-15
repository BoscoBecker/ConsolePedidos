using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePedidos.Entities.Products
{
    class Product
    {
        public string name { get; set; }
        public double price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public override string ToString()
        {
            StringBuilder sbProduto = new StringBuilder();
            sbProduto.AppendLine(name);
            sbProduto.AppendLine(price.ToString());
            return sbProduto.ToString();
        }
    }
}
