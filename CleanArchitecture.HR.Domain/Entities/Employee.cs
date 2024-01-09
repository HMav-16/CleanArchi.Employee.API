using CleanArchitecture.HR.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.HR.Domain.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class Employee : BaseAuditableEntity
    {
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public string Email { get; set; } 
        public string PhoneNumber { get; set; } 
        public DateTime HireDate { get; set; }
        public double Salary { get; set; }
        public int ComissionPCT { get; set; }
        public int ManagerId { get; set; }
        public string JobId { get; set; }
        public int DepartementId { get; set; }
    }
}
