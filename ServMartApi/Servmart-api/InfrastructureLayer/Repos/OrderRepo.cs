using Domain_Layer.DTOs.OrderDTOs;
using Domain_Layer.Models;
using Infrastructure_Layer.IRepos;
using InfrastructureLayer;
using InfrastructureLayer.Repos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Repos
{
    public class OrderRepo : BaseRepos<Order>, IOrderRepo
    {
        private readonly AppDbContext _appDbContext;
        public OrderRepo(AppDbContext appContext) : base(appContext)
        {
            _appDbContext = appContext;
        }

        public async Task<IEnumerable<ShowOrderDTO>> GetAllOrderForVendor(string VendorID)
        {
          var orderItems = await _appDbContext.OrderItem.Where(i => i.Product.ProviderId== VendorID).ToListAsync();            
            var data = orderItems.Select(i => new ShowOrderDTO
            {
                ProductName = i.Product.ProductName,
                UserName = i.Order.User.UserName,
                Image = i.Product.ProductMedias.Select(i=>i.MeadiUrl).ToList(),
                Address = i.Order.Address,
                TotalAmount = i.Quantity,
                Governorate = i.Order.Governorate.NameAr,
                City = i.Order.City.NameAr,
                CreateAt = i.Order.CreateAt.Date,
                Details = i.Order.Details,
                OrderID = i.OrderID,
                TotalPrice =i.ToltalPrice
            });
            return data;
        }

        public async Task<IEnumerable<OrderDTO>> GetAllOrderForCustomer(string UserID)
        {
            var orderItems = await _appDbContext.Order.Where(i => i.UserID == UserID).ToListAsync();
            var data = orderItems.Select(i => new OrderDTO
            {
                Address = i.Address,
                TotalAmount = i.TotalAmount,
                Governorate = i.Governorate.NameAr,
                City = i.City.NameAr,
                CreateAt = i.CreateAt,
                ID = i.ID,
                TotalPrice = i.Items.Sum(i => i.ToltalPrice),
                OrderItems = i.Items.Select(i => new OrderItemDTO
                {
                    Image = i.Product.ProductMedias.Select(i => i.MeadiUrl).ToList(),
                    ProductId = i.ProductID,
                    ProductName = i.Product.ProductName,
                    ProviderName = i.Product.ProductUser.UserName,

                }).ToList()
            });
            ; 
            return data;
        }

        public async Task<Order> MakeOrder(Order order)
        {
            await _appDbContext.Order.AddAsync(order);
            return order;
        }

        public Order GetOrderById(int orderId)
        {
            return _appDbContext.Order.Find(orderId);
        }

        public async void UpdateOrderStatus(int orderId, OrderStatus newStatus)
        {
            var order = await _appDbContext.Order.FindAsync(orderId);

            if (order != null)
            {
                order.OrderStatus = newStatus;
                _appDbContext.SaveChanges();
            }
        }

    }
}
