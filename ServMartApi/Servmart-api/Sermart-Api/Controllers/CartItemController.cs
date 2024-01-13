using ApplicationLayer.IRepos;
using Domain_Layer.DTOs.CartItemDTOs;
using Domain_Layer.Models;
using Infrastructure_Layer.IRepos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Sermart_Api.Helpers;
using System.Security.Claims;

namespace Sermart_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CartItemController : ControllerBase
    {
        private readonly IcartItemRepo _repo;
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<User> _manager;

        public CartItemController(IUnitOfWork unitOfWork, IcartItemRepo repo, UserManager<User> manager)
        {
            _unitOfWork = unitOfWork;
            _repo = repo;
            _manager = manager;
        }

        [HttpGet]
        public async Task<ActionResult<CartItemGetDTO>> GetAll()
        {
            var userID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result = await _repo.GetAllItems(userID);
            var data = result.Select(i => new CartItemGetDTO
            {
                ProductID = i.ProductID,
                ProductName = i.Product.ProductName,
                UnitPrice = i.Product.UnitPrice,
                Stoke = i.Product.Stoke,
                Count = i.Qauntety,
                Id = i.Id,
                SupPrice = i.Product.UnitPrice * i.Qauntety,
                PicURL = i.Product.ProductMedias.Select(i => i.MeadiUrl).FirstOrDefault()
            }) ;
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> AddItem(string productid)
        {
            var userID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(productid))
                return BadRequest("No Product to Add");
            var result = await _repo.Add(productid, userID);
            var user = await _manager.FindByIdAsync(userID);           
            user.Cart.Items.Add(result);
            _unitOfWork.CommitChanges();
            return Ok(result);
        }

        [HttpPatch]
        public async Task<IActionResult> Update(CartItemUpdateDTO cartItemUpdateDTO)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _repo.Update(cartItemUpdateDTO);
            if(result == null)
                return BadRequest(result);
            _unitOfWork.CommitChanges();
            return Ok(result);
        }

        [HttpDelete("Empty")]
        public async Task<IActionResult> Empty()
        {
            var userID = User.FindFirstValue(ClaimTypes.NameIdentifier);
             _repo.Empty(userID);
            _unitOfWork.CommitChanges();
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _repo.Delete(id);
            if (result == null)
                return BadRequest(result);
            _unitOfWork.CommitChanges();
            return Ok(result);
        }
    }
}
