using CleanArchitecture.HR.Domain.Entities;
using CleanArchitectureHR.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearnArchitectureHR.Persistence.Abstractions
{
    public class EmployeeRepository : IEmployeeRepository
    {
        #region Object Repositories

        private readonly IGenericRepository<Employee> _repository;
        #endregion

        #region Constructor
        public EmployeeRepository(IGenericRepository<Employee> repository)
        {
            _repository = repository;
        }
        #endregion
    }
}
