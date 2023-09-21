using BackEnd.Project.Models;

namespace BackEnd.Project.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetAll();
    }
}
