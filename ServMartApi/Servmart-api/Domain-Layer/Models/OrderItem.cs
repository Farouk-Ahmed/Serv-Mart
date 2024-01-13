using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Models
{
    public class OrderItem
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public virtual Order Order { get; set; }
        public Guid ProductID { get; set; }
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal ToltalPrice { get; set; }
    }
}
