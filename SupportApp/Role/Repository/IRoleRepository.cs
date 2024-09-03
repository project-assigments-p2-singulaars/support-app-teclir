namespace SupportApp.Role.Repository;

public interface IRoleRepository
{
    Task<List<Role>> GetAllRoles();
    Task<Role> CreateProject(Role roleDTO);
    Task<bool> ExistRole(int id);
    Task UpdateProject(Role role);
}