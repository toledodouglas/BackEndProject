using BackEnd.Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Project.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T FindById(int id);

    }
}
