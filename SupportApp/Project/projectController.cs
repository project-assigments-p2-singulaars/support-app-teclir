using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SupportApp.Data;
using AutoMapper;
using FluentValidation;
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
            var projectsDTO = _mapper.Map<IEnumerable<Project>>(projects);
            return Ok(projects);
        }
        
        [HttpGet("{id:int}")]
        public async Task<ActionResult<List<ProjectDTO>>> GetIdProject(int id)
        {
            var project = await _projectRepository.ExistProject(id);
            if (project == null)
            {
                return NotFound();

            }

            return Ok(project);
        }

        [HttpPost]
            public async Task<IActionResult> CreateProject(CreateProjectDTO createProjectDTO)
            {
                var project = _mapper.Map<Project>(createProjectDTO);
                await _projectRepository.CreateProject(project);
                return Ok(project);
        }
        [HttpPut("{id:int}")]
        public async Task<ActionResult> UpdateProject(int id, [FromBody]CreateProjectDTO createProjectDTO)
        {
            var project = await _context.Projects.FindAsync(id);
            if (project == null)
            {
                return NotFound();
            }
            _mapper.Map(createProjectDTO,project);
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
            await _projectRepository.Delete(project.Id);
            return NoContent();
        }
        }
    }
    
