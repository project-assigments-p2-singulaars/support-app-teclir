namespace SupportApp.Project;

public class Project
{
    public int ProjectId { get; set; }
    public string ProjectName { get; set; } = null!;
    public DateTime StartDate  { get; set; }
    public DateTime EndDate { get; set; }
}

