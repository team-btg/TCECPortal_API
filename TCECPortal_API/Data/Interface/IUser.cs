using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCECPortal_API.Model.Dto;

namespace TCECPortal_API.Data.Interface
{
    public interface IUser
    {
        Task<IEnumerable<UserDto>> GetAllUser();
        Task<UserDto> GetUser(int UserId);
        Task<UserDto> GetUserEmail(UserDto user);
        Task<UserDto> AddUser(UserDto user);
        Task<UserDto> UpdateUser(UserDto user);
    }
}
