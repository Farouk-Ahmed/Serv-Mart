using Domain_Layer.Models;

namespace ApplicationLayer.IRepos
{
    public interface IProductCatgory
    {
        Task Add(ProductCategory entity);
        Task<IEnumerable<ProductCategory>> GetAllProduct();
        Task<int> getCatgoryCount();
    }
}
