using System.Collections.Generic;
using System.Linq;

namespace OrderTracker.Models
{
    public class Vendor
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public static List<Vendor> _vendors = new List<Vendor> { };
        public static List<Order> Orders { get; set; }
        public int Id { get; }
        private static int _idCounter = 0;

        public Vendor(string name, string description)
        {
            Name = name;
            Description = description;
            _vendors.Add(this);
            Orders = new List<Order> { };
            _idCounter++;
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
    }
}