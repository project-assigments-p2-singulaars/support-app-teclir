namespace SupportApp.Assignment;
using Microsoft.EntityFrameworkCore;
using SupportApp.Data;


public class AssignmentRepository : IAssignmentRepository
{
    private readonly ApplicationDBContext _context;

    public AssignmentRepository(ApplicationDBContext context)
    {
        _context = context;
    }

    public async Task UpdateAssignment(Assignment assignment)
    {
        _context.Update(assignment);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Assignment>> GetAllAssignment()
    {
        return await _context.Assignments.ToListAsync();
    }

    public async Task<Assignment> CreateAssignment(Assignment assignment)
    {
        _context.Add(assignment);
        await _context.SaveChangesAsync();
        return assignment;
    }
}