using CleanArchitecture.HR.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureHR.Application.Interfaces
{
    public interface IApplicationDbContext : IDisposable
    {
        DbSet<Employee> EmployeesList { get; set; }
        DbSet<Location> LOcationList { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
