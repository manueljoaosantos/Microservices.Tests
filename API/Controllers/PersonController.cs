using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class PersonController : BaseApiController
    {            
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPersonRepository _personService;
        public PersonController( IUnitOfWork unitOfWork, IPersonRepository personService)
        {
            this._unitOfWork = unitOfWork;
            this._personService = personService;
        }
     
        [HttpGet]
        public IEnumerable<Person> GetAllPersons()
        {
            return _unitOfWork.Repository<Person>().ListAll();
        }

        [Route("[action]")]
        [HttpGet]
        public IEnumerable<Person> GetAdultPersons()
        {
            return _personService.GetAdultPersons();
        }
    }
}
