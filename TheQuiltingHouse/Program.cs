using System;

namespace TheQuiltingHouse
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
    }

    public class QuiltingOrder
    {
        public string Fabric { get; }
        public string Pattern { get; set; }
        public string Size { get; set; }

        public QuiltingOrder(string name, )
        {
            this.Customer = name;
        }

        public void QuiltOrder();

        private var order = new QuiltingOrder("Collin");
        Console.WriteLine("Your order has been sent!");
    }
}