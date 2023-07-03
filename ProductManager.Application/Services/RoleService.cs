using ProductManager.Application.Interfaces.Repositories;
using ProductManager.Application.Interfaces.Services;
using ProductManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Application.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository) 
        {
            _roleRepository = roleRepository;
        }

        public async Task<Role> GetRoleById(int id)
        {
            return await _roleRepository.GetById(id);
        }

        public async Task<List<Role>> GetAllRoles()
        {
            return await _roleRepository.GetAll();
        }      
    }
}
