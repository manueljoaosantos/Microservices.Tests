using System;
using System.Text.Json;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;

namespace Infrastructure.Data
{
    public class PersonRepository : IPersonRepository
    {
        private readonly BaseContext _context;
        public PersonRepository(BaseContext context)
        {
            _context = context;
        }
        public IEnumerable<Person> GetAdultPersons()
        {
            return _context.Person.Where(p => p.Age >= 18).ToList();
        }

    }
}