using Domain_Layer.DTOs.CustomDTO;
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
    public class VendorSoldProductsRepo
    {
        private readonly AppDbContext _dbcontext;
        public VendorSoldProductsRepo(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }


        public async Task<IEnumerable<VendorSelectedItemDTO>> GetMySoldProducts(string UserID)
        {
            var userProductsInOrderItems = from user in _dbcontext.Users
                                           join product in _dbcontext.Product on user.Id equals product.ProviderId
                                           join orderItem in _dbcontext.OrderItem on product.ProductID equals orderItem.ProductID
                                           where user.Id == UserID
                                           select new VendorSelectedItemDTO
                                           {
                                               UserId = user.Id,
                                               UserName = user.UserName,
                                               ProductId = product.ProductID,
                                               ProductName = product.ProductName,
                                               OrderItemId = orderItem.ID,
                                               Quantity = orderItem.Quantity,
                                               TotalPrice = orderItem.ToltalPrice
                                           };

            // Execute the query and get the results
            var results = userProductsInOrderItems.ToList();
            return results;
        }
    }
}
