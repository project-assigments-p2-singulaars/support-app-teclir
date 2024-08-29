using SupportApp.Person;
using SupportApp.Project;
using SupportApp.Role;

namespace support_app.tableJoin;

public class ProjectStructure
{
    public int ProjectId { get; set; }
    public Project Project { get; set; }

    public int PersonId { get; set; }
    public Person Person { get; set; }

    public int RoleId { get; set; }
    public Role Role { get; set; }
}