using System.Collections.Generic;
using System.Linq;

namespace OrderTracker.Models
{
    public class Order
    {
        public string Name { get; set; }
        public string DeliveryDate { get; set; }
        public int BreadCount { get; set; }
        public int PastryCount { get; set; }
        public int OrderCost { get; set; }
        private static List<Order> _instances = new List<Order> { };
        public int Id { get; }
        
        public Order(string name, string deliveryDate, int breadCount, int pastryCount)
        {
            Name = name;
            DeliveryDate = deliveryDate;
            BreadCount = breadCount;
            PastryCount = pastryCount;
            OrderCost = 0;
            _instances.Add(this);
            Id = _instances.Count;
        }

        public static Order Find(int searchId)
        {
            return _instances[searchId - 1];
        }

    }
}