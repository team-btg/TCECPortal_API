using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCECPortal_API.Models
{
    public class Project : IAuditTable  
    {
        public int ProjectId { get; set; } 
        public string PrjName { get; set; }
        public string ClubName { get; set; }
        public int PrjStatus { get; set; }
        public string PrjContact { get; set; }
        public string PrjContactNo { get; set; }
        public string PrjDescription { get; set; }
        public string PrjAddress { get; set; }
        public decimal PrjBudget { get; set; }
        public decimal PrjSpent { get; set; }
        public DateTime? TargetDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public ICollection<DocAttachment> Attachments { get; set; } = null;
    }
}
