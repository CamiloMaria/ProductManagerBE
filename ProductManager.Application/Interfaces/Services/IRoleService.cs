using ProductManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Application.Interfaces.Services
{
    public interface IRoleService
    {
        Task<Role> GetRoleById(int id);
        Task<List<Role>> GetAllRoles();
    }
}
