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
        
        public Vendor(string name, string deliveryDate, int breadCount, int pastryCount)
        {
            Name = name;
            DeliveryDate = deliveryDate;
            BreadCount = breadCount;
            PastryCount = pastryCount;
            OrderCost = 0;
        }
    }
}