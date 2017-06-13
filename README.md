a super simple [AutoMapper](https://github.com/AutoMapper/AutoMapper) example using the [Dependency Injection Extension](https://github.com/AutoMapper/AutoMapper.Extensions.Microsoft.DependencyInjection)

noteable files:

[Middleware.cs](Middleware.cs) - DI stuff
[Model/PersonMappingProfile.cs](Model/PersonMappingProfile.cs) - A basic mapping profile
[Controllers/PersonController.cs](Controllers/PersonController.cs) - A controller that uses AutoMapper (this should actually use the repository pattern instead)
