using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SupportApp.Data;
using AutoMapper;
using SupportApp.Assignment; 
using Microsoft.EntityFrameworkCore;
using SupportApp.Person;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SupportApp.Assignment
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignmentController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly IMapper _mapper;
        private readonly IAssignmentRepository _assignmentRepository;

        public AssignmentController(ApplicationDBContext context, IAssignmentRepository assignmentRepository, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            _assignmentRepository = assignmentRepository;
        }
        
        [HttpGet]
        public async Task<ActionResult<List<AssignmentDTO>>> GetAllProjects()
        {
            var duties = await _assignmentRepository.GetAllAssignment();
            return Ok(duties);
        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult<List<AssignmentDTO>>> GetAllAssignment()
        {
            var assignments = await _assignmentRepository.GetAllAssignment();
            var assignmentDTO = _mapper.Map<List<AssignmentDTO>>(assignments);
            return Ok(assignmentDTO);
        }

        [HttpPost]
        public async Task<ActionResult<AssignmentDTO>> CreateAssignment(CreateAssignmentDTO createAssignmentDTO)
        {
            var assignment = _mapper.Map<Assignment>(createAssignmentDTO);
            var assignmentId = await _assignmentRepository.CreateAssignment(assignment);
            return Ok(assignmentId);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> UpdateAssignment(int id, [FromBody] CreateAssignmentDTO updateAssignmentDto)
        {
            var assignment = await _context.Assignments.FindAsync(id);
            if (assignment == null)
            {
                return NotFound();
            }

            _mapper.Map(updateAssignmentDto, assignment);
            await _assignmentRepository.UpdateAssignment(assignment);
            return Ok(assignment);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteAssignment(int id)
        {
            var assignment = await _context.Assignments.FindAsync(id);
            if (assignment == null)
            {
                return NotFound();
            }
            _context.Assignments.Remove(assignment);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}