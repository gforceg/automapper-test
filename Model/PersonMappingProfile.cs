using AutoMapper;
using automapper_test.Entity;

namespace automapper_test.Model
{
  public class PersonMappingProfile : Profile
  {
    public PersonMappingProfile() {
      CreateMap<PersonViewModel, Person>()
      .ReverseMap();
    }
  }
}