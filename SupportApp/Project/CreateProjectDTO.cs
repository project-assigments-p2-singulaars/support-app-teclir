namespace SupportApp.Project;

public class CreateProjectDTO
{
    
    public string ProjectName { get; set; } = null!;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}