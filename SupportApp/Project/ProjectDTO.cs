namespace SupportApp.Project;

public class ProjectDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime InitDate { get; set; }
    public DateTime? EndDateTime { get; set; }
    
    public List<Assignment.Assignment> SupportTask { get; set; } = new List<Assignment.Assignment>();
}