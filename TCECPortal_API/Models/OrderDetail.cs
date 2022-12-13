using System;

namespace TCECPortal_API.Models
{
    public class OrderDetail : IAuditTable
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public decimal Qty { get; set; }
        public string Dscription { get; set; }
        public decimal Amount { get; set; }
        public string Remarks { get; set; }
        public decimal LineTotal { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Order Order { get; set; }
    }
}