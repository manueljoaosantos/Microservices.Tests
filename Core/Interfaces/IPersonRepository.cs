using Core.Entities;

namespace Core.Interfaces
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetAdultPersons();

    }
}
