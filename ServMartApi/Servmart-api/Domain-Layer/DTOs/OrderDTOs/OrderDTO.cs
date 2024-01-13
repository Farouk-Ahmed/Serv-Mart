using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.DTOs.OrderDTOs
{
    public class OrderDTO
    {
        //for Customer
        public int ID { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalPrice { get; set; }
        public string Address { get; set; }
        public string Governorate { get; set; }
        public string City { get; set; }
       
        public DateTime CreateAt { get; set; }
        public List<OrderItemDTO> OrderItems { get; set; }


    }
    public class OrderItemDTO
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public List<string> Image { get; set; }
        public string ProviderName { get; set; }
    }
}
