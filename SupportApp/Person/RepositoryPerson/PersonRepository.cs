using Microsoft.EntityFrameworkCore;
using SupportApp.Data;
namespace SupportApp.Person;

public class PersonRepository : IPersonRepository
{
    private readonly ApplicationDBContext _context;



    public PersonRepository(ApplicationDBContext context)
    {
        _context = context;

    }
    
    public async Task<List<Person>> GetAllPersons()
    {
        return await _context.Persons.ToListAsync();
    }

    public async Task<string> CreatePerson(Person personDTO)
    {
        _context.Add(personDTO);
        await _context.SaveChangesAsync();
        return personDTO.Name;
    }

    public async Task UpdatePerson(Person person)
    {
        _context.Update(person);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> ExistPerson(int id)
    {
        return await _context.Persons.AnyAsync(x => x.Id == id);
    }

    public async Task DeletePerson(int id)
    {
        await _context.Persons.Where(x => x.Id == id).ExecuteDeleteAsync();
    }
}