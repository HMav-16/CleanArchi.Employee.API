using CleanArchitecture.HR.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.HR.Domain.Entities
{
    public class Region :  BaseAuditableEntity
    {
        public string RegionName { get; set; }
    }
}
