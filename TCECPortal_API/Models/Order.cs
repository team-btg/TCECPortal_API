using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCECPortal_API.Models
{
    public class Order : IAuditTable
    {
        public int OrderId { get; set; }
        public string OrderNo { get; set; }
        public string UserId { get; set; }
        public string Remarks { get; set; }
        public DateTime? OrderDate { get; set; }
        public int OrderType { get; set; }
        public int ProjectId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public User User { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public ICollection<DocAttachment> Attachments { get; set; } = null;
    }
}
