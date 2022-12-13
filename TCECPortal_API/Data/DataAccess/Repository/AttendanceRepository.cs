using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCECPortal_API.Data.DataAccess.Interface;
using TCECPortal_API.Models;

namespace TCECPortal_API.Data.DataAccess.Repository
{
    public class AttendanceRepository : GenericRepository<Attendance>, IAttendanceRepository
    {
        private readonly ILogger<AttendanceRepository> _logger;
        public AttendanceRepository(DataContext context, ILogger<AttendanceRepository> logger) : base(context)
        {
            _logger = logger;
        }

        public async Task<IEnumerable<Attendance>> GetAllUser()
        {
            try
            {
                var query = await GetAllAsyn();
                return query;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
            return null;
        }

        public async Task<Attendance> GetUser(int UserId)
        {
            try
            {
                var query = await GetAllAsyn(); 
                return query.Where(a => a.UserId == UserId).FirstOrDefault();
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
            return null;
        }
    }
}
