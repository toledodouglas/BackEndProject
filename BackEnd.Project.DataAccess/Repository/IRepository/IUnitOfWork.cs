namespace BackEnd.Project.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IProductRepository Product { get; }
        void Save();

    }
}
