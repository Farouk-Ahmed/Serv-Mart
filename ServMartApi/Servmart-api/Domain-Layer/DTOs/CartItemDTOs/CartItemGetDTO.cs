using Domain_Layer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.DTOs.CartItemDTOs
{
    public class CartItemGetDTO
    {

        public int Id { get; set; }
        public Guid ProductID { get; set; }
        public string ProductName { get; set; }
        public int Stoke { get; set; }
        public int Count { get; set; } = 1;
        public decimal SupPrice { get; set; }
        public string PicURL { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
