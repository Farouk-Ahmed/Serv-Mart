using Application_Layer.Helpers;
using ApplicationLayer.IRepos;
using Domain_Layer.DTOs.OrderDTOs;
using Domain_Layer.Models;
using Infrastructure_Layer.IRepos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Immutable;
using System.Security.Claims;

namespace Sermart_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepo _orderRepo;
        private readonly IcartItemRepo _icartItemRepo;
        private readonly IProduct _productRepo;

        private readonly UserManager<User> _usermanager;
        private readonly IUnitOfWork _unitofwork;
        public OrderController(IOrderRepo orderRepo, UserManager<User> usermanager, IUnitOfWork unitofwork, IcartItemRepo icartItemRepo, IProduct productRepo)
        {
            _orderRepo = orderRepo;
            _usermanager = usermanager;
            _unitofwork = unitofwork;
            _icartItemRepo = icartItemRepo;
            _productRepo = productRepo; 
        }
        [HttpGet("GetVendorOrder")]
        [Authorize (Roles ="Vendor")]
        public async Task<IActionResult> GetVendorOrder()
        {
            string VendorId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var data=  await _orderRepo.GetAllOrderForVendor(VendorId);
            return Ok(data);
        }
        [HttpGet("GetCustomerOrder")]
        [Authorize]
        public async Task<IActionResult> GetCustomerOrder()
        {
            string Id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var data = await _orderRepo.GetAllOrderForCustomer(Id);
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> MakeOrder([FromBody]AddOrderDTO orderDTO)
        {
            try
            {
                var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var user = await _usermanager.FindByIdAsync(userid);
                var orderitemslist = OrderHelper.GetOrderItems(user.Cart);
                if(orderitemslist.Count<= 0)
                    return BadRequest("Cant make order");

                var order = new Order { Items = orderitemslist };
                order.Details = orderDTO.Details;
                order.Address = orderDTO.Address;
                order.CityId = orderDTO.CityId;
                order.GovernorateId = orderDTO.GovernorateId;
                order.UserID = userid;
                order.TotalAmount = 0;
                foreach (var item in orderitemslist)
                {
                    order.TotalAmount += item.Quantity;
                }
                user.Orders.Add(order);
               

                _icartItemRepo.Empty(userid);

                foreach (var item in orderitemslist)
                {
                    var prd = await _productRepo.GetProductByid(item.ProductID);
                    prd.Stoke -= item.Quantity;
                    _productRepo.Update(prd);
                }
                _unitofwork.CommitChanges();
                return Ok();    

            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPatch()]

        public IActionResult ChangeOrderStatus(int orderId, OrderStatus newStatus)
        {
            var order = _orderRepo.GetOrderById(orderId);

            if (order == null)
            {
                return NotFound($"Order with ID {orderId} not found");
            }

            _orderRepo.UpdateOrderStatus(orderId, newStatus);

            return Ok($"Order status changed to {newStatus}");
        }

    }
}
