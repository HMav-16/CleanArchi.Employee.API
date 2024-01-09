using CleanArchitecture.HR.Domain.Entities;
using CleanArchitectureHR.Application.Common.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureHR.Application.Features.Employees.Queries.GetEmpById
{
    public class GetEmployeeByIdDto : IMapFrom<Employee>
    {
        public int Id { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Email { get; init; }
        public string PhoneNumber { get; init; }
        public DateTime HireDate { get; init; }
        public double Salary { get; init; }
        public int ComissionPCT { get; init; }
        public int ManagerId { get; init; }
        public string JobId { get; init; }
        public int DepartementId { get; init; }
    }
}
