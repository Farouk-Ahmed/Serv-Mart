
namespace ApplicationLayer.IRepos
{
    public interface IUnitOfWork
    {
        int CommitChanges();
    }
}
