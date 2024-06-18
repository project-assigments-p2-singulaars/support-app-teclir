using SupportApp.Project;
using AutoMapper;

namespace SupportApp.Utils;

 
public class AutoMapperProfiles: Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<Project.Project, ProjectDTO>();
        CreateMap<CreateProjectDTO, Project.Project>();
    }
}