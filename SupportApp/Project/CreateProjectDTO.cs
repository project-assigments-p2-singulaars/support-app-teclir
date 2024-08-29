namespace SupportApp.Project;

public class CreateProjectDTO
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime InitDate { get; set; }
    public DateTime? EndDateTime { get; set; }
}