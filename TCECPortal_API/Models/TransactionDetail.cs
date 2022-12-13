using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCECPortal_API.Models
{
    public class TransactionDetail : IAuditTable
    {
        public int Id { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public string AccountCode { get; set; }
        public string Remarks { get; set; }
        public string Reference { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int TransId { get; set; }
        public int AccountId { get; set; }
        public Transaction Transaction { get; set; }
        public Account Account { get; set; }
    }
}