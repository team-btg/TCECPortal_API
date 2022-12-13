using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCECPortal_API.Models
{
    public class Transaction : IAuditTable
    {
        public int TransId { get; set; }
        public string TransDescription { get; set; }
        public decimal Amount { get; set; }
        public string Reference { get; set; }
        public string Remarks { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int TransferFrom { get; set; }
        public int TransferTo { get; set; }
        public ICollection<TransactionDetail> TransactionDetails { get; set; }
    }
}
