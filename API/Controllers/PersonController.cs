using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class PersonController : BaseApiController
    {            
        private readonly IUnitOfWork unitOfWork;

        public PersonController( IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
     
        [HttpGet]
        public IEnumerable<Person> GetAllPersons()
        {
            return unitOfWork.Person.ListAll();
        }

        [Route("[action]")]
        [HttpGet]
        public IEnumerable<Person> GetAdultPersons()
        {
            return unitOfWork.Person.GetAdultPersons();
        }
    }
}
