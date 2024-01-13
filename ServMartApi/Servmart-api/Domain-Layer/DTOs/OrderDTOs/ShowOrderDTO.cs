using Domain_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.DTOs.OrderDTOs
{
    public class ShowOrderDTO
    {
        //for Vendor
        public decimal TotalAmount { get; set; }
        public decimal TotalPrice { get; set; }
        public List<string> Image { get; set; } 
        public string Address { get; set; }
        public string Governorate { get; set; }
        public string Details { get; set; }
        public int OrderID { get; set; }
        public string City { get; set; }
        public string UserName {  get; set; }
        public string ProductName { get; set; }
        public DateTime CreateAt { get; set; } 
        
      
    }
}
