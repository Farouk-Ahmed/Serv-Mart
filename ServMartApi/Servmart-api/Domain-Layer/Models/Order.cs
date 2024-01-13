using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Models
{
    public class Order
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public string Details { get; set; }
        public string Address { get; set; }
        public int GovernorateId { get; set; }
        public int CityId { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public virtual User User { get; set; }
        public virtual Governorate Governorate { get; set; }
        public virtual City City { get; set; }
        public virtual ICollection<OrderItem> Items { get; set; }
    }
    public enum OrderStatus
    {
        Pending=0,
        Canceled=1,
        Completed=2,
        NoTheWay=3
    }
}
