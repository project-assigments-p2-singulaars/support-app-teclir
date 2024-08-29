using SupportApp.Project;
using AutoMapper;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using SupportApp.Assignment;
using SupportApp.Person;
using SupportApp.Role;

namespace SupportApp.Utils;

 
public class AutoMapperProfiles: Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<Project.Project, ProjectDTO>();
        CreateMap<CreateProjectDTO, Project.Project>();

        CreateMap<Person.Person, PersonDTO>();
        CreateMap<CreatePersonDTO, Person.Person>();

        CreateMap<Assignment.Assignment, AssignmentDTO>();
        CreateMap<CreateAssignmentDTO, Assignment.Assignment>();

        CreateMap<RoleDTO, Role.Role>();

    }
}