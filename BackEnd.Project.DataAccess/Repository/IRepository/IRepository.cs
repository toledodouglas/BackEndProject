using BackEnd.Project.Models;

namespace BackEnd.Project.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : Entity
    {
        T FindById(int id);
        void Remove(T entity);
        void Add(T entity);

    }
}
