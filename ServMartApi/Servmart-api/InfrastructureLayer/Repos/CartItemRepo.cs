using ApplicationLayer.IRepos;
using Domain_Layer.DTOs.CartItemDTOs;
using Domain_Layer.Models;
using Infrastructure_Layer.IRepos;
using InfrastructureLayer;
using InfrastructureLayer.Repos;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Repos
{
    public class CartItemRepo : BaseRepos<CartItem> ,IcartItemRepo
    {
        private readonly AppDbContext _context;
        public CartItemRepo(AppDbContext dbContext) : base(dbContext)
        {
            _context = dbContext; 
        }

        public async Task<CartItem> Add(string ProducID, string userID)
        {
            var user = _context.Users.FirstOrDefault(i => i.Id == userID);
            if (user != null)
            {
                if (user.Cart.Items.Where(c => c.ProductID == new Guid(ProducID)).Count() != 0)
                    return null;
                var item = new CartItem
                {
                    CartID = user.Cart.Id,
                    ProductID = new Guid(ProducID),
                    Qauntety = 1
                };
                await _context.CartItem.AddAsync(item);
                return item;
            }
            return null;
        }

        public async Task<CartItem> Delete(int id)
        {
            var item = await _context.CartItem.FirstOrDefaultAsync(item => item.Id == id);
            if (item != null)
                _context.CartItem.Remove(item);
            return item;
        }

        public async void Empty(string id)
        {
            var user = _context.Users.FirstOrDefault(i => i.Id == id);
            if (user != null)
            {
                foreach (var item in user.Cart.Items)
                {
                    _context.CartItem.Remove(item);
                }
            }
        }
        public async Task<IEnumerable<CartItem>> GetAllItems(string UserId)
        {
            return await _context.CartItem.Where(c=>c.Cart.UserId == UserId).ToListAsync();
        }

        public async Task<CartItem> Update(CartItemUpdateDTO cartItemUpdateDTO)
        {
            var item = await _context.CartItem.FirstOrDefaultAsync(item => item.Id == cartItemUpdateDTO.CartItemID);
            if (item == null)
                return item;
            item.Qauntety = cartItemUpdateDTO.Quantity;
            _context.CartItem.Update(item);
            return item;
        }
    }
}
