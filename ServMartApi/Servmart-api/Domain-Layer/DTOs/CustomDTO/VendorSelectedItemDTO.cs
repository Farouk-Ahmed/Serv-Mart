using Domain_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.DTOs.CustomDTO
{
    public class VendorSelectedItemDTO
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public int OrderItemId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
