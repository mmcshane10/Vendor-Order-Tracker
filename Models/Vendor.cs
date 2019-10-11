using System.Collections.Generic;
using System.Linq;

namespace OrderTracker.Models
{
    public class Vendor
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public static List<Vendor> _vendors = new List<Vendor> { };
        public List<Order> Orders { get; set; }
        public int Id { get; }

        public Vendor(string name, string description)
        {
            Name = name;
            Description = description;
            _vendors.Add(this);
            Orders = new List<Order> { };
            Id = _vendors.Count;
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        public static List<Vendor> GetAll()
        {
            return _vendors;
        }

        public static Vendor Find(int searchId)
        {
            return _vendors[searchId - 1];
        }
    }
}