using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCECPortal_API.Models;

namespace TCECPortal_API.Data.DataAccess.Interface
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<IEnumerable<User>> GetAllUser();
        Task<User> GetUser(int UserId);
        Task<User> GetUserEmail(string Email);
    }
}
