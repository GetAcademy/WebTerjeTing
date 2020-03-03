using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebTerjeTing.Model;

namespace WebTerjeTing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private List<Person> _persons = new List<Person>()
        {
            new Person {Id = 1, Name = "Per"},
            new Person {Id = 2, Name = "Pål"},
            new Person {Id = 3, Name = "Espen"}
        };

        [HttpGet]
        public IEnumerable<Person> GetPersons()
        {
            return _persons;
        }


        [HttpGet("{id}")]
        public Person GetPerson(int id)
        {
            var list = _persons.Where(p=>p.Id>100);

            return _persons.SingleOrDefault(p=>p.Id==id);
        }

        [HttpPost]
        public int CreatePerson(Person person)
        {
            _persons.Add(person);
            return person.Id = _persons.Count;
        }
    }
}