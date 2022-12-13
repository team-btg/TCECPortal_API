using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCECPortal_API.Models
{
    public class Account : IAuditTable
    {
        public int AccountId { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public string AccountDesc { get; set; }
        public bool isActive { get; set; } = true;
        public decimal Amount { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
