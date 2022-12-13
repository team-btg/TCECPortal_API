using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCECPortal_API.Models
{
    public interface IAuditTable
    {
        string CreatedBy { get; set; }
        DateTime? CreatedDate { get; set; }
        string ModifiedBy { get; set; }
        DateTime? ModifiedDate { get; set; }
    }
}
