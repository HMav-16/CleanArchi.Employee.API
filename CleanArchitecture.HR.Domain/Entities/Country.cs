using CleanArchitecture.HR.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.HR.Domain.Entities
{
    public class Country : BaseAuditableEntity
    {
        public string CountryShortName { get; set; }
        public string CountryName { get; set; }
        public int RegionId { get; set; }
    }
}
