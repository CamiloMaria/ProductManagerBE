using ProductManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Application.Interfaces
{
    public interface IUserService
    {
        Task<User> GetUserById(int id);
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetRolByUser(User user);
        Task AddUSer(User user);
        Task UpdateUser(User user);
        Task DeleteUser(User user);
    }
}
