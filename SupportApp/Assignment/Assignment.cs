using System.ComponentModel.DataAnnotations;

namespace SupportApp.Assignment;
using SupportApp.Project;
public class Assignment
{
    public int Id { get; set; }
    [StringLength(50), Required]
    public String Name { get; set; }
    public String Description { get; set; }
    public DateTime InitDate { get; set; }
    public DateTime? EndDate { get; set; } = null!;
    
    public int ProjectId { get; set; }
    public Project Project { get; set; } = null!;
    
    public int PersonId { get; set; }
    public Person.Person Person { get; set; }
}