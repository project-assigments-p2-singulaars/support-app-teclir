using Microsoft.EntityFrameworkCore;
using SupportApp.Data;

namespace SupportApp.Role.Repository;

public class RoleRepository : IRoleRepository
    {
        private readonly ApplicationDBContext _context;

        public RoleRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<List<Role>> GetAllRoles()
        {
            return await _context.Roles.ToListAsync();
        }

        public async Task<Role> CreateProject(Role roleDto)
        {
            _context.Add(roleDto);
            await _context.SaveChangesAsync();
            return roleDto;
        }

        public async Task<bool> ExistRole(int id)
        {
            return await _context.Roles.AnyAsync(x => x.Id == id);
        }

        public async Task UpdateProject(Role role)
        {
            _context.Update(role);
            await _context.SaveChangesAsync();
        }
    }
