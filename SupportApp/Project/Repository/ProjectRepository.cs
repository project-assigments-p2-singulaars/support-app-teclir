using Microsoft.EntityFrameworkCore;
using SupportApp.Data;
namespace SupportApp.Project;

public class ProjectRepository : IProjectRepository
{
    private readonly ApplicationDBContext _context;

    public ProjectRepository(ApplicationDBContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Project>> GetAllProjects()
    {
        return await _context.Projects.ToListAsync();
    }
    
    public async Task<int> CreateProject(Project projectDTO)
    {
        _context.Add(projectDTO);
        await _context.SaveChangesAsync();
        return projectDTO.Id;
    }

    public async Task UpdateProject(Project project)
    {
        
        _context.Update(project);
        await _context.SaveChangesAsync();
    }
    
    public async Task<bool> ExistProject(int id)
    {
        return await _context.Projects.AnyAsync(x => x.Id == id);
    }

    public async Task Delete(int id)
    {
        await _context.Projects.Where(x => x.Id == id).ExecuteDeleteAsync();
    }

}
    
    


