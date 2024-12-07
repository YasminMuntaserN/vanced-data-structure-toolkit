using ObservableCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservableCollection
{
    /*
        Shopping Cart for an E-commerce App
        Problem: Maintain a shopping cart where items can be added, removed, or replaced, and notify the UI.
     */
    public class Cart
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        
        public override string ToString()
        {
            return $"Id : {Id} | ProductProductName : {ProductName} ";
        }
    }
    public class Q2
    {
        public static void Question()
        {
            MyObservableCollection<Cart> Cart = new MyObservableCollection<Cart>();

            Cart.Add(new Cart() { Id = 1, ProductName = "Phone" });
            Cart.Add(new Cart() { Id = 2, ProductName = "labtob"});
            Cart.Add(new Cart() { Id = 3, ProductName = "pc" });

            Cart.RemoveAt(1);

            Cart.Insert(0, new Cart() { Id = 4, ProductName = "headphones" });

            Cart.Move(0, 2);


            Console.WriteLine("All products in cart : ");
            foreach (var product in Cart)
            {
                Console.WriteLine(product);
            }
        }
    }
}
