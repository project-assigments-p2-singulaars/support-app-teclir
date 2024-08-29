using System.ComponentModel.DataAnnotations;
using support_app.tableJoin;

namespace SupportApp.Project;
using SupportApp.Assignment;


public class Project
{
    public int Id { get; set; }
    [StringLength(50), Required]
    public string Name { get; set; }
    [StringLength(500), Required]
    public string Description { get; set; }
    public DateTime InitDate { get; set; }
    public DateTime? EndDateTime { get; set; } = null!;
    
    public ICollection<Assignment> SupportTask { get; set; } = new List<Assignment>();
    public ICollection<ProjectStructure> ProjectStructure { get; set; }
}

