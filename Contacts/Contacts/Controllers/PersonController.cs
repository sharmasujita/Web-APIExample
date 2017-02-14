using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Contacts.Models;

namespace Contacts.Controllers
{
    public class PersonController : ApiController
    {
        Person[] persons = new Person[]
        {
          new Person {ID = 1, FirstName ="Joe", LastName ="Joe", Address= "123 abc st", Phone ="111111111"},
          new Person {ID = 2, FirstName ="Mark", LastName ="Williams", Address= "456 xyz st", Phone ="22222222222"},
          new Person {ID = 3, FirstName ="Bob", LastName ="John", Address= "678 pqr st", Phone ="33333333333"},

        };
      
       
         [HttpGet]
        public IEnumerable<Person> GetAllPersons()
        {
             return persons;
        }

        public IHttpActionResult GetPerson(int id)
        {
            var person = persons.FirstOrDefault(p => p.ID == id);

            if(person == null)
            {
                return Ok(person);
            }
            else
            {
                return NotFound();
            }
        }

        public IHttpActionResult DeletePerson(int id)
        {
            // remove from array
            return Ok();   
        }

        public IHttpActionResult UpdatePerson()
        {
            //Update array
            return Ok();
        }



    }
}
