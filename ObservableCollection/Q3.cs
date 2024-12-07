using ObservableCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservableCollection
{
    /*
        Real-Time Stock Prices
       Problem: Display a list of real-time stock prices that update dynamically.
     */
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }

        public decimal Price { get; set; }
        
        public override string ToString()
        {
            return $"Id : {Id} | ProductProductName : {ProductName} | Price  : {Price:C} ";
        }
    }
    public class Q3
    {
        public static void Question()
        {
            MyObservableCollection<Product> Products = new MyObservableCollection<Product>();

            Products.Add(new Product() { Id = 1, ProductName = "Phone"  ,Price =50.2m});
            Products.Add(new Product() { Id = 2, ProductName = "labtob" ,Price = 70.2m });
            Products.Add(new Product() { Id = 3, ProductName = "pc" , Price = 100.2m });

            Console.Write($"\n\nPrice updated for {Products[0].ProductName}. New Price: ");
            Task.Delay(1000).Wait();
            Products[0].Price = 100;
            Console.Write($"{Products[0].Price} \n\n");

            Console.Write($"Price updated for {Products[1].ProductName}. New Price: ");
            Task.Delay(1000).Wait();
            Products[1].Price = 20;
            Console.Write($"{Products[1].Price} \n\n");

            Console.Write($"Price updated for {Products[2].ProductName}. New Price: ");
            Task.Delay(1000).Wait();
            Products[2].Price = 200;
            Console.Write($"{Products[2].Price} \n\n");

            Console.WriteLine("\n\nAll products in Product : ");
            foreach (var product in Products)
            {
                Console.WriteLine(product);
            }
        }
    }
}
