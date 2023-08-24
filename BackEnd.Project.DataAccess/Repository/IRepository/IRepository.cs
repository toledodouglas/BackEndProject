using BackEnd.Project.Models;

namespace BackEnd.Project.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T FindById(int id);
        void Remove(T entity);
    }
}
