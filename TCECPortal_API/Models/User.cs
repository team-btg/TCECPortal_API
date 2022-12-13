using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TCECPortal_API.Data.Enums;

namespace TCECPortal_API.Models
{
    public class User : IAuditTable
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Pssword { get; set; }
        public string Postion { get; set; } = null;
        public string Address { get; set; }
        public string Email { get; set; } = null;
        public string MobilePhone { get; set; } = null;
        public string ClubName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string Profession { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? JoinedDate { get; set; }
        public string Gender { get; set; }
        public bool isAdmin { get; set; } = false;
        public string Avatar { get; set; }
        public string MemberType { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string FacebookId { get; set; }
    }
}
