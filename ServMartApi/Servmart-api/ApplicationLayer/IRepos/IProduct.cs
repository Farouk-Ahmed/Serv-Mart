using Domain_Layer.Helpers;
using Domain_Layer.Models;

namespace ApplicationLayer.IRepos
{
    public interface IProduct
    {
        Task Add(Product entity);
        void Update(Product entity);
        void Delete(string id);
        Task<IEnumerable<Product>> GetAllProduct();
        Task<IEnumerable<Product>> GetUserProduct(string id);
        Task<Product> GetProductByid(Guid id);
        IQueryable<Product> GetFilterdProducts(FilterModel<Product> filers);
    }
}
