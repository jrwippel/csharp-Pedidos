using System;
using System.Globalization;
namespace Pedidos.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Produtc { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int quantity, double price, Product produtc)
        {
            Quantity = quantity;
            Price = price;
            Produtc = produtc;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return Produtc.Name 
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
