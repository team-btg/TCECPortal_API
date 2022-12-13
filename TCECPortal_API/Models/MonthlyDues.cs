using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCECPortal_API.Models
{
    public class MonthlyDues : IAuditTable
    {
        public int MonthlyId { get; set; }
        public int Month { get; set; }
        public string MonthName { get; set; }
        public double MonthlyAmount { get; set; }
        public double PaidAmount { get; set; }
        public bool isPaid { get; set; } = false;
        public string Year { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int TransId { get; set; }
        public Transaction Transaction { get; set; }
    }
}
