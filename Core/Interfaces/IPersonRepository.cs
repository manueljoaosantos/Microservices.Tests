using Core.Entities;

namespace Core.Interfaces
{
    public interface IPersonRepository : IGenericRepository<Person>
    {
        IEnumerable<Person> GetAdultPersons();

    }
}
