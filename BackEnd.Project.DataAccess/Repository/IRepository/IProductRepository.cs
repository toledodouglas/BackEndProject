﻿using BackEnd.Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Project.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetAll();

    }
}
