using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SupportApp.Data;
using AutoMapper;

using Microsoft.EntityFrameworkCore;

namespace SupportApp.Project
{
    [Route("api/[controller]")]
    [ApiController]
    public class projectController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly IMapper _mapper;
        private readonly IProjectRepository _projectRepository;
        public projectController(ApplicationDBContext context,IProjectRepository projectRepository, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            _projectRepository = projectRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProjectDTO>>> GetAllProjects()
        {
            var projects = await _projectRepository.GetAllProjects();
            _mapper.Map<List<ProjectDTO>>(projects);
            return Ok(projects);
        }
        [HttpPost]
        public async Task<ActionResult<ProjectDTO>> CreateProject(CreateProjectDTO createProjectDto,IProjectRepository projectRepository)
        {
            var project= _mapper.Map<Project>(createProjectDto);
            await _projectRepository.CreateProject(project);
            return Ok(project);
        }
        [HttpPut("{id:int}")]
        public async Task<ActionResult> UpdateProject(int id, [FromBody]CreateProjectDTO updateProjectDTO)
        {
            var project = await _context.Projects.FindAsync(id);
            if (project == null)
            {
                return NotFound();
            }
            _mapper.Map(updateProjectDTO,project);
            await _projectRepository.UpdateProject(project);
            return Ok(project);
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteProject(int id)
        {
            var project = await _context.Projects.FindAsync(id);
            if (project== null)
            {
                return NotFound();
            }
            _context.Projects.Remove(project);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
    
}