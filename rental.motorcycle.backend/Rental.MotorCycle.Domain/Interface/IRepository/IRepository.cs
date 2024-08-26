﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental.MotorCycle.Domain.Interface.IRepository
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        TEntity Get(int id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
