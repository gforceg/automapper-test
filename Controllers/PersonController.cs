using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using automapper_test.Model;
using Microsoft.AspNetCore.Mvc;
using automapper_test.Entity;
using AutoMapper;

namespace automapper_test.Controllers
{
  [Route("api/[controller]")]
  public class PersonController : Controller
  {
    IMapper Mapper;
    public PersonController(IMapper _mapper)
    {
      Mapper = _mapper;
    }
    static Person LastPerson;

    // POST api/values
    [HttpPost]
    public IActionResult Post([FromBody]PersonViewModel pm)
    {
      if (pm == null)
      {
        return BadRequest(PersonController.LastPerson);
      }
      else if (ModelState.IsValid)
      {
        // fixme: this code should go in a Repo
        PersonController.LastPerson = Mapper.Map<Person>(pm);
        return Ok(PersonController.LastPerson);
      }
      return BadRequest(PersonController.LastPerson);
    }
  }
}
