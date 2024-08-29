namespace SupportApp.Assignment;
using SupportApp.Person;
public class AssignmentDTO
{
    public int Id { get; set; }
    public String Name { get; set; }
    public String Description { get; set; }
    public DateTime InitDate { get; set; }
    public DateTime? EndDate { get; set; } = null;
}