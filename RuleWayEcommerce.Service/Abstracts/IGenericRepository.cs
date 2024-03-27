﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleWayEcommerce.Service.Abstracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task Add(T entity);

        Task Update(T entity);

        Task Delete(T entity);

        Task<T> GetById(int id);

        Task<List<T>> GetAll();
    }
}
