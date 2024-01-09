using CleanArchitecture.HR.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.HR.Domain.Entities
{
    public class Location : BaseAuditableEntity
    {
        public string LocationId { get; set; }
        public string StreetAddress { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public int CountryId { get; set; }
    }
}
