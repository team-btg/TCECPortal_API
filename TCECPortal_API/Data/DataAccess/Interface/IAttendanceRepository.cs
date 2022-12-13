using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCECPortal_API.Models;

namespace TCECPortal_API.Data.DataAccess.Interface
{
    public interface IAttendanceRepository : IGenericRepository<Attendance>
    {
        Task<IEnumerable<Attendance>> GetAllUser();
        Task<Attendance> GetUser(int UserId);
    }
}
