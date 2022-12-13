using AutoMapper;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCECPortal_API.Data.DataAccess.Interface;
using TCECPortal_API.Data.Interface;
using TCECPortal_API.Model.Dto;
using TCECPortal_API.Models;

namespace TCECPortal_API.Data.Implementation
{
    public class AttendanceService : IAttendance
    {
        private readonly IMapper _mapper;
        private readonly ILogger<AttendanceService> _logger;
        private readonly IAttendanceRepository _attendanceRepository;
        public AttendanceService(IMapper mapper,
            ILogger<AttendanceService> logger
            , IAttendanceRepository attendanceRepository)
        {
            _mapper = mapper;
            _logger = logger;
            _attendanceRepository = attendanceRepository;
        }
        public async Task<AttendanceDto> AddAttendance(AttendanceDto user)
        {
            try
            {
                user.CreatedDate = DateTime.Now;

                var model = _mapper.Map<Attendance>(user);
                var a = await _attendanceRepository.AddAsync(model);
                await _attendanceRepository.SaveAsync();
                 
                if (a != null)
                {
                    var _model = _mapper.Map<AttendanceDto>(a);

                    return _model;
                }

            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
            return null;
        }

        public async Task<IEnumerable<AttendanceDto>> GetAllUser()
        {
            try
            {
                var query = await _attendanceRepository.GetAllAsyn();
                if (query != null)
                {
                    var model = _mapper.Map<IEnumerable<Attendance>, IEnumerable<AttendanceDto>>(query);
                    return model;
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
            return null;
        }

        public async Task<AttendanceDto> GetUser(int UserId)
        {
            try
            {
                var query = await _attendanceRepository.GetUser(UserId);
                if (query != null)
                {
                    var model = _mapper.Map<Attendance, AttendanceDto>(query);
                    return model;
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
            return null;
        }
    }
}
