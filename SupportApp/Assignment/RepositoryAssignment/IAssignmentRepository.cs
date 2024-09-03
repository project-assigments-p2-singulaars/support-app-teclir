namespace SupportApp.Assignment;

public interface IAssignmentRepository
{
    Task<List<Assignment>> GetAllAssignment();
    Task UpdateAssignment(Assignment assignment);
    Task<Assignment> CreateAssignment(Assignment assignment);
}