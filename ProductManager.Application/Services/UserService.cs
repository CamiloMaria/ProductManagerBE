using ProductManager.Application.Interfaces;
using ProductManager.Domain.Entities;
using ProductManager.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<User> GetUserById(int id)
        {
            return await _userRepository.GetByIdAsync(id);
        }
        public async Task<User> GetRolByUser(User user)
        {
            return await _userRepository.GetRolByUser(user);
        } 
        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await _userRepository.GetAllAsync();
        }
        public async Task AddUSer(User user)
        {
            await _userRepository.AddAsync(user);
        }
        public async Task UpdateUser(User user)
        {
            await _userRepository.UpdateAsync(user);
        }
        public async Task DeleteUser(User user)
        {
            await _userRepository.DeleteAsync(user);
        }
    }
}
