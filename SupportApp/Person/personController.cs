using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SupportApp.Data;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace SupportApp.Person
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class personController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly IMapper _mapper;
        private readonly IPersonRepository _personRepository;
        public personController(ApplicationDBContext context,IPersonRepository personRepository, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            _personRepository = personRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<Person>>> GetAllPersons()
        {
            var persons = await _personRepository.GetAllPersons();
            return Ok(persons);
        }
        [HttpPost]
        public async Task<IActionResult> CreatePerson(CreatePersonDTO personDTO)
        {
            var person = _mapper.Map<Person>(personDTO);
            await _personRepository.CreatePerson(person);
            return Ok(person);
        }
        [HttpPut("{id:int}")]
        public async Task<ActionResult> UpdatePerson(int id, [FromBody]CreatePersonDTO person)
        {
            var modifiedPerson = await _context.Persons.FindAsync(id);
            if (modifiedPerson == null)
            {
                return NotFound();
            }
            _mapper.Map(person, modifiedPerson);
            await _personRepository.UpdatePerson(modifiedPerson);
            return Ok(modifiedPerson);
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeletePerson(int id)
        {
            var deletedPerson = await _context.Persons.FindAsync(id);
            if (deletedPerson == null)
            {
                return NotFound();
            }
            
            await _personRepository.DeletePerson(deletedPerson.Id);
            return NoContent();
        }
    }
    
}