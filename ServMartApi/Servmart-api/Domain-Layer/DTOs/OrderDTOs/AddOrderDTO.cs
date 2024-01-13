using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.DTOs.OrderDTOs
{
    public class AddOrderDTO
    {
        public string Details { get; set; }
        public string Address { get; set; }
        public int GovernorateId { get; set; }
        public int CityId { get; set; }
    }
}
