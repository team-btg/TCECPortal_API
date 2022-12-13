using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TCECPortal_API.Models
{
    public class Attendance : IAuditTable
    {
        [Key]
        public int AttendanceId { get; set; }
        public int UserId { get; set; }
        public DateTime? AttendanceDate { get; set; }
        public string EventDscription { get; set; }
        public string DeviceName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public User User { get; set; }
        public string GeneratedCode { get; set; }
    }
}
