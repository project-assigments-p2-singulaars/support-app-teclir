namespace SupportApp.Person;

public interface IPersonRepository
{
    Task<List<Person>> GetAllPersons();
    Task<string> CreatePerson(Person personDTO);
    Task UpdatePerson(Person person);
    Task<bool> ExistPerson(int id);
    Task DeletePerson(int id);
}