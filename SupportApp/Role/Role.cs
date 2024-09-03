using support_app.tableJoin;

namespace SupportApp.Role;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


public class Role
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<ProjectStructure> ProjectStructure { get; set; }
}
