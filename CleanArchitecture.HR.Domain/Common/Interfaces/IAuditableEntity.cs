using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.HR.Domain.Common.Interfaces
{
    public interface IAuditableEntity : IEntity
    {
        DateTime? CreatedDate { get; set; }
        DateTime? ModifiedDate { get; set; }
        DateTime? DeletededDate { get; set; }
    }
}
