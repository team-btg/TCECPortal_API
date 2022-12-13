using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCECPortal_API.Data.DataAccess.Interface; 
using TCECPortal_API.Model.Dto;
using TCECPortal_API.Models;

namespace TCECPortal_API.Data.DataAccess.Repository
{
    public class UserRepository : GenericRepository<User> , IUserRepository
    {
        private readonly ILogger<UserRepository> _logger;

        public UserRepository(DataContext context, ILogger<UserRepository> logger) : base(context)
        {
            _logger = logger;
        }

        public async Task<IEnumerable<User>> GetAllUser()
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

        public async Task<User> GetUser(int UserId)
        {
            try
            {
                var query = await GetAsync(UserId);
                return query;
            }
            catch(Exception e)
            {
                _logger.LogError(e.Message);
            }
            return null;
        } 
        public async Task<User> GetUserEmail(string Email)
        {
            try
            {
                var query = await GetAllAsyn();
                return query.Where(a => a.Email == Email).FirstOrDefault();
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
            return null;
        }
    }
}
