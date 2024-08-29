namespace SupportApp.Project;

public interface IProjectRepository
{
    Task<IEnumerable<Project>> GetAllProjects();
    Task<int> CreateProject(Project createProjectDTO);
    Task UpdateProject(Project project);
    Task<bool> ExistProject(int id);
    Task Delete(int id);
}