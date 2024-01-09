using CleanArchitecture.HR.Domain.Common;
using CleanArchitectureHR.Application.Interfaces;
using ClearnArchitectureHR.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearnArchitectureHR.Persistence.Abstractions
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseAuditableEntity
    {

        #region Object Database

        private readonly HrDbContext _dbContext;
        #endregion

        #region Constructor
        public GenericRepository(HrDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion

        #region Ovverides methods

        public IQueryable<T> Entities => _dbContext.Set<T>();

        public async Task<T> AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _dbContext.Remove(entity);

        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbContext
                .Set<T>()
                .ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public Task UpdateAsync(T entity)
        {
            T exist = _dbContext.Set<T>().Find(entity.Id);
            _dbContext.Entry(exist).CurrentValues.SetValues(entity);
            return Task.CompletedTask;
        }
        #endregion
    }
}
