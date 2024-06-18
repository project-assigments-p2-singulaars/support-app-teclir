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

    public async Task UpdateProject(Project project)
    {
        _context.Update(project);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Project>> GetAllProjects()
    {
        return await _context.Projects.ToListAsync();
    }

    public async Task<Project> CreateProject(Project project)
    {
        _context.Add(project);
        await _context.SaveChangesAsync();
        return project;
    }
}
    
    


