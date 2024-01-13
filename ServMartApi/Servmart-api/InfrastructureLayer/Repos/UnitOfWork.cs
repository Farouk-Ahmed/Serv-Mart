using ApplicationLayer.IRepos;

namespace InfrastructureLayer.Repos
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDbContext _dbcontxt;

        public UnitOfWork(AppDbContext dbcontxt)
        {
            _dbcontxt = dbcontxt;
        }

        public int CommitChanges()
        {
            return _dbcontxt.SaveChanges();
        }
    }
}
