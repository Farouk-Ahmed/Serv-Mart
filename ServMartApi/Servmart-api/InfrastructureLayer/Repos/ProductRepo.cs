using Application_Layer.Helpers;
using ApplicationLayer.IRepos;
using Domain_Layer.Helpers;
using Domain_Layer.Models;
using Microsoft.EntityFrameworkCore;

namespace InfrastructureLayer.Repos
{
    public class Products : IProduct
    {
        private readonly AppDbContext _dbContext;

        public Products(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(Product entity)
        {
            await _dbContext.Product.AddAsync(entity);
        }

        public   void Delete(string id)
        {
            var Delete = _dbContext.Product.Include(i => i.OrderItems).FirstOrDefault(i => i.ProductID.ToString() == id);

            var x =_dbContext.Remove(Delete);

          
        }

        public async Task<IEnumerable<Product>> GetAllProduct()
        {
            return await _dbContext.Product.ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetUserProduct(string id)
        {
            return await _dbContext.Product.Where(x => x.ProviderId == id).ToListAsync();
        }

        public async Task<Product> GetProductByid(Guid id)
        {
          return  await  _dbContext.Product.FindAsync(id);
        }

        public void Update(Product entity)
        {
            _dbContext.Product.Update(entity);
        }


        public IQueryable<Product> GetFilterdProducts(FilterModel<Product> filers)
        {
            var filter = new GenericFilter<Product>();
            var query = _dbContext.Product.AsQueryable();
            var filteredQuery = filter.ApplyFilter(query, filers);            
            return filteredQuery;
        }
    }
}
