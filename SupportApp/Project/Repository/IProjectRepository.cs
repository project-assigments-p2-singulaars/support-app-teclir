namespace SupportApp.Project;

public interface IProjectRepository
{
    Task<List<Project>> GetAllProjects();
    Task UpdateProject(Project project);
    Task<Project> CreateProject(Project project);
}