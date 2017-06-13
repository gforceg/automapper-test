
using AutoMapper;
using automapper_test.Entity;
using automapper_test.Model;
using Microsoft.Extensions.DependencyInjection;

namespace automapper_test
{
  public static class ConfigServices
  {
    public static IServiceCollection AddAppMappings(this IServiceCollection services)
    {
      services.AddAutoMapper(typeof(PersonViewModel), typeof(Person));
      return services;
    }
  }
}