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
    public class UserService : IUser
    {
        private readonly IMapper _mapper;
        private readonly ILogger<UserService> _logger;
        private readonly IUserRepository _userRepository;
        public UserService(IMapper mapper,
            ILogger<UserService> logger,
            IUserRepository userRepository)
        {
            _mapper = mapper;
            _logger = logger;
            _userRepository = userRepository;
        }
        public async Task<UserDto> AddUser(UserDto user)
        {
            try
            {
                user.CreatedDate = DateTime.Now;

                var model = _mapper.Map<User>(user);
                await _userRepository.AddAsync(model);
                await _userRepository.SaveAsync();

                var getNewUser = await _userRepository.GetAllUser();
                getNewUser.Where(a => a.Email == user.Email).FirstOrDefault();

                if (getNewUser != null)
                {
                    var _model = _mapper.Map<UserDto>(getNewUser);

                    return _model;
                }

            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
            return null;
        }

        public async Task<IEnumerable<UserDto>> GetAllUser()
        {
            try
            {
                var query = await _userRepository.GetAllAsyn();
                if (query != null)
                {
                    var model = _mapper.Map<IEnumerable<User>, IEnumerable<UserDto>>(query);
                    return model;
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
            return null;
        }

        public async Task<UserDto> GetUser(int UserId)
        {
            try
            {
                var query = await _userRepository.GetAsync(UserId);
                if (query != null)
                {
                    var model = _mapper.Map<User, UserDto>(query);
                    return model;
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
            return null;
        }

        public async Task<UserDto> GetUserEmail(UserDto user)
        {
            try
            {
                var query = await _userRepository.GetUserEmail(user.Email); 
                if (query != null)
                {
                    var model = _mapper.Map<User, UserDto>(query);
                    return model;
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
            return null;
        }

        public async Task<UserDto> UpdateUser(UserDto user)
        {
            try
            {
                var query = await _userRepository.GetAsync(user.UserId);
                
                if (query != null)
                {
                    user.ModifiedDate = DateTime.Now;

                    var entity = _mapper.Map<User>(user);
                    await _userRepository.UpdateAsync(entity, user.UserId);
                    await _userRepository.SaveAsync();

                    var result = await _userRepository.GetAsync(user.UserId);
                    if (result != null)
                    {
                        var _model = _mapper.Map<UserDto>(query);
                        return _model;
                    }
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
