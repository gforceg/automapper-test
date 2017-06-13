using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using automapper_test.Model;
using Microsoft.AspNetCore.Mvc;

namespace automapper_test.Controllers
{
  [Route("api/[controller]")]
  public class PersonController : Controller
  {
    // GET api/values
    [HttpGet]
    public IEnumerable<string> Get()
    {
      return new string[] { "value1", "value2" };
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
      return "value";
    }

    // POST api/values
    [HttpPost]
    public IActionResult Post([FromBody]PersonViewModel pm)
    {
      if (pm == null)
      {
        return BadRequest();
      }
      else if (ModelState.IsValid)
      {
          pm.FirstName = "wtf";
        return Ok(pm);
      }
      return BadRequest();
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
