using Domain_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Helpers
{
    public static class OrderHelper
    {
        public static ICollection<OrderItem> GetOrderItems(Cart cart)
        {
            var List = new List<OrderItem>();
            foreach(var item in cart.Items)
            {
                List.Add(new OrderItem { ProductID = item.ProductID, Quantity = item.Qauntety, ToltalPrice = (item.Qauntety * item.Product.UnitPrice) });
            }
            return List;
        }
    }
}
