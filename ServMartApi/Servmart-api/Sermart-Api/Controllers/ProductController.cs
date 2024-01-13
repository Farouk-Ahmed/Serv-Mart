using Application_Layer.Helpers;
using ApplicationLayer.IRepos;
using AutoMapper;
using Domain_Layer.DTOs.ProductDTOs;
using Domain_Layer.Helpers;
using Domain_Layer.Models;
using InfrastructureLayer.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sermart_Api.Helpers;
using System.Security.Claims;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sermart_Api.Controllers
{
   
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProduct _product;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IPhotoService _photo;

        public ProductController(IProduct product, IUnitOfWork unitOfWork, IMapper mapper,IPhotoService photo)
        {

            _product = product;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
           _photo = photo;
        }
        //GET: api/<ProductController>
        [HttpGet]
        [Route("GetAllProduct")]
        public async Task<ActionResult> GetAll()
        {

            //var allProduct = await _product.GetAllProduct();
            //var data = allProduct.Select(i => new ProductViewModel
            //{
            //    ProductID = i.ProductID,
            //    ProductName = i.ProductName,
            //    Description = i.Description,
            //    UnitPrice = i.UnitPrice,
            //    Stoke = i.Stoke,
            //    CategoryID = i.CategoryID,
            //    ProviderId = i.ProviderId,
            //    PicsURL = i.ProductMedias.Select(p => p.MeadiUrl).ToList(),

            //});

            //return Ok(data);

            var data = await _product.GetAllProduct();
            var mapper = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(data);
            return Ok(mapper);
        }

        [HttpGet("GetAllUserProduct")]
        [Authorize(Roles = "Vendor")]
        public async Task<ActionResult> GetAllUserProduct()
        {
          string id= User.FindFirstValue(ClaimTypes.NameIdentifier);
            var data = await _product.GetUserProduct(id);
            var mapper = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(data);
            return Ok(mapper);
        }

        //GET api/<ProductController>/5
        [HttpGet("GetProductById/{id}")]
        public async Task<ActionResult<ProductViewModel>> GetByid(Guid id)
        {
            if (ModelState.IsValid)
            {
                var result = await _product.GetProductByid(id);
                var mapper = _mapper.Map<Product, ProductViewModel>(result);
                
                return Ok(mapper);
            }
            return Ok();
        }

        //POST api/<ProductController>
        [HttpPost("AddProduct")]
        //[Route("AddProduct")]
        [Authorize(Roles = "Vendor")]
        [DisableRequestSizeLimit]
        public async Task<ActionResult<Product>> Addproduct([FromForm]AddProductDTO productVM)
        {
            if (ModelState.IsValid)
            {
                var request = new Product()
                {
                    ProductName = productVM.ProductName,
                    Description = productVM.Description,
                    UnitPrice = productVM.UnitPrice,
                    Stoke = productVM.Stoke,
                    CategoryID = productVM.CategoryID,
                    ProviderId = User.FindFirstValue(ClaimTypes.NameIdentifier),

                };
                request.ProductMedias = new List<ProductMedia>();
                foreach (var item in productVM.Pics)
                {
                    var resualt = await _photo.AddPhotoAsync(item);
                    request.ProductMedias.Add(new ProductMedia() { MeadiUrl = resualt.Url.ToString() });
                }

                await _product.Add(request);
                _unitOfWork.CommitChanges();
                return new JsonResult ("add New product");
            }
            return Ok();
        }

        //PUT api/<ProductController>/5
        [HttpPut("UpdateProduct/{id}")]
        public async Task<ActionResult> Update(Guid id ,[FromForm]ProductViewModel productVM)
        {
            productVM.ProductID=id;
           
            if (ModelState.IsValid)
            {
                    productVM.ProviderId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                try
                {
                    var mapper = _mapper.Map<ProductViewModel, Product>(productVM);
                    _product.Update(mapper);
                    _unitOfWork.CommitChanges();
                    return new JsonResult("UPdate One Product Succfuly");
                }
                catch (Exception ex)
                {

                    ModelState.AddModelError(string.Empty, ex.Message);
                }

            }

            return Ok(productVM);
        }
     
       

        //DELETE api/<ProductController>/5
        [HttpDelete("DeleteProduct/{id}")]
        public async Task<ActionResult> Delete(string id)
        {



           
                try
                {
                    
                    _product.Delete(id);
                     _unitOfWork.CommitChanges();
                    return new JsonResult("Delete One Product");
                }
                catch (Exception ex)
                {

                    ModelState.AddModelError(string.Empty, ex.Message);
                    return Ok();
                }
           

        }


        [HttpPost("Filter")]
        public IActionResult GetFilterdData([FromBody] FilterModel<Product> filters)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = _product.GetFilterdProducts(filters).ToList();
            return Ok(result);
        }
    }
}
