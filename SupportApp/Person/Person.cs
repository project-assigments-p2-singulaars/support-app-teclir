using support_app.tableJoin;

namespace SupportApp.Person;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public ICollection<Assignment.Assignment> Assignments { get; set; }
    public ICollection<ProjectStructure> ProjectStructure { get; set; }

}