using ProductManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Application.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetById(int id);
        Task<List<User>> GetAll();
        Task Add(User user);
        Task Update(User user);
        Task Delete(int id);

    }
}
