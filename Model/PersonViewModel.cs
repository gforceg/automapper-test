using System;
using System.ComponentModel.DataAnnotations;

namespace automapper_test.Model
{
  public class PersonViewModel
  {
    // [Required]
    // public bool Test { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set;  }
    [Required]
    public DateTime? DOB { get; set; }
  }
}