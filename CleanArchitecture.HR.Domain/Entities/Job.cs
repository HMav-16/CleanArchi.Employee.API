using CleanArchitecture.HR.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.HR.Domain.Entities
{
    public class Job : BaseAuditableEntity
    {
        public string JobId { get; set; }
        public string JobTitle { get; set; }
        public decimal MinSalaire { get; set; }
        public decimal MaxSalaire { get; set; }
    }
}
