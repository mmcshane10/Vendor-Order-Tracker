using System.Collections.Generic;
using System.Linq;

namespace OrderTracker.Models
{
    public class Vendor
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public static List<Order> _orders = new List<Order> { };
        public int Id { get; }
        private static int _idCounter = 0;

        public Vendor(string name, string description)
        {
            Name = name;
            Description = description;
            _orders.Add(this);
            _idCounter++;
            
            
        }
    }
}