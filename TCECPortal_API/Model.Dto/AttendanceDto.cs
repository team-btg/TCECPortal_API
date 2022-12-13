using System; 
using TCECPortal_API.Models;

namespace TCECPortal_API.Model.Dto
{
    public class AttendanceDto : IAuditTable
    {
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
