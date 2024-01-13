using ApplicationLayer.IRepos;
using Domain_Layer.DTOs.CartItemDTOs;
using Domain_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Layer.IRepos
{
    public interface IcartItemRepo : IBaseRepo<CartItem>
    {
        Task<IEnumerable<CartItem>> GetAllItems(string UserID);
        Task<CartItem> Add(string ProducID, string userID);
        Task<CartItem> Update(CartItemUpdateDTO cartItemUpdateDTO);
        Task<CartItem> Delete(int id);
        void Empty(string id);
    }
}
