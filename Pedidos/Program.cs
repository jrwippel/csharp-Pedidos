using Pedidos.Entities;
using Pedidos.Entities.Enums;
using System.Globalization;

namespace Pedidos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime moment = DateTime.Now;
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name:");
            string name = Console.ReadLine();
            Console.Write("Email:");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY):");
            DateTime birthDate= DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            Console.Write("Status:");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
            Order order = new Order(moment, status, client);


            Console.Write("How many items to this order?");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) 
            {
                Console.WriteLine($"Enter #{i + 1} item data:");
                Console.Write("Product Name:");
                string nameProduct = Console.ReadLine();
                Console.Write("Price:");
                double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity:");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(nameProduct, priceProduct);
                OrderItem item = new OrderItem(quantity, priceProduct, product);
                order.AddItem(item);
            }                       
            Console.WriteLine(order);            
        }
    }
}