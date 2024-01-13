using ApplicationLayer.IRepos;
using AutoMapper;
using Domain_Layer.DTOs;
using Domain_Layer.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sermart_Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductCatgoreiController : ControllerBase
    {
        private readonly IProductCatgory _product;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public ProductCatgoreiController(IProductCatgory product,IMapper mapper,IUnitOfWork unitOfWork)
        {
            _product = product;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        // GET: api/<ProductCatgorei>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductCategory>>> GetAll()
        {

            var result = await _product.GetAllProduct();
            var mapper = _mapper.Map<IEnumerable<ProductCategory>, IEnumerable<ProductCatgoryViewModel>>(result);

            _unitOfWork.CommitChanges();
            return Ok(mapper);

        }
       



        // POST api/<ProductCatgorei>
        [HttpPost]

        public async Task<ActionResult<ProductCatgoryViewModel>> Add(ProductCatgoryViewModel model)
        {
            if (ModelState.IsValid)
            {
             var mapper=   _mapper.Map<ProductCatgoryViewModel, ProductCategory>(model);
                await _product.Add(mapper);
                _unitOfWork.CommitChanges();
                return CreatedAtAction(nameof(GetAll), new { id = mapper.ID }, mapper);
            }
            return Ok(model);
        }

            
        


    }
}
