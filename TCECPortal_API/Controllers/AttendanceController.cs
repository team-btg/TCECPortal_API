using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCECPortal_API.Data.Interface;
using TCECPortal_API.Model.Dto;

namespace TCECPortal_API.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class AttendanceController : Controller
    {
        private readonly IAttendance _attendance;
        public AttendanceController(IAttendance attendance)
        {
            _attendance = attendance;
        }

        [EnableQuery()]
        [HttpGet]
        public async Task<IQueryable<AttendanceDto>> GetAllUser()
        {
            var command = await _attendance.GetAllUser();
            return command.AsQueryable();
        }

        [HttpGet("{UserId}")]
        public async Task<AttendanceDto> GetUser(int UserId)
        {
            var command = await _attendance.GetUser(UserId);
            return command;
        }

        [HttpPost]
        public async Task<IActionResult> AddAttendance([FromBody] AttendanceDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var _model = await _attendance.AddAttendance(model);
            return Ok(_model);
        }
    }
}
