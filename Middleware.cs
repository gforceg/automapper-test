
// using Microsoft.Extensions.DependencyInjection;
// using Newtonsoft.Json.Serialization;

// namespace automapper_test
// {
//   public static class ConfigServices
//   {
//     public static IServiceCollection AddJsonSerialization(this IServiceCollection services)
//     {
//       services.AddMvc((options => options.MaxModelValidationErrors = 1)).AddJsonOptions(config =>
//       {
//         config.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
//       }).AddJsonOptions(config2 =>
//       {
//         config2.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
//       });
//       return services;
//     }
//   }
// }