using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData;
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
    public class UserController : Controller
    {
        private readonly IUser _user;
        public UserController(IUser user)
        {
            _user = user;
        }

        [EnableQuery()]
        [HttpGet]
        public async Task<IQueryable<UserDto>> GetAllUser()
        {
            var command = await _user.GetAllUser();
            return command.AsQueryable();
        }

        [HttpGet("{UserId}")]
        public async Task<UserDto> GetUser(int UserId)
        {
            var command = await _user.GetUser(UserId);
            return command;
        }

        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody] UserDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var _model = await _user.AddUser(model);
            return Ok(_model);
        }

        [HttpPost]
        [Route("getemail")]
        public async Task<IActionResult> GetUserEmail([FromBody] UserDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var command = await _user.GetUserEmail(model);
            return Ok(command);
        }

        [HttpPatch]
        public async Task<IActionResult> UpdateUser([FromBody] UserDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var command = await _user.UpdateUser(model);
            return Ok(command);
        }
    }
}
