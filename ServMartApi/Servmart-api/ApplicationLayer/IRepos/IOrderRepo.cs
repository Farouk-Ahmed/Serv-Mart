using ApplicationLayer.IRepos;
using Domain_Layer.DTOs.OrderDTOs;
using Domain_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Layer.IRepos
{
    public interface IOrderRepo : IBaseRepo<Order>
    {
        Task<Order> MakeOrder(Order order);
        Task<IEnumerable<OrderDTO>> GetAllOrderForCustomer(string UserID);
        Task<IEnumerable<ShowOrderDTO>> GetAllOrderForVendor(string VendorID);
        Order GetOrderById(int orderId);
         void UpdateOrderStatus(int orderId, OrderStatus newStatus);

    }
}
