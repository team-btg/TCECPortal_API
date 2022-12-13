using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCECPortal_API.Model.Dto;

namespace TCECPortal_API.Data.Interface
{
    public interface IAttendance
    {
        Task<IEnumerable<AttendanceDto>> GetAllUser();
        Task<AttendanceDto> GetUser(int UserId); 
        Task<AttendanceDto> AddAttendance(AttendanceDto user);
    }
}
