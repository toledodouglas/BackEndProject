namespace BackEnd.Project.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {

        IProductRepository Product { get; }
        IClientRepository Client { get; }
        void Save();

        
    }
}
