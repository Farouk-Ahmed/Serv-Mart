
namespace ApplicationLayer.IRepos
{
    public interface IBaseRepo<T> where T : class
    {
        IEnumerable<T> GetAll();


        
    }
}
