# N-Layered App with Entity Framework, Autofac, ASP.NET MVC and Unit Testing

http://techbrij.com/service-layer-entity-framework-asp-net-mvc-unit-testing

In my recent post, I explained how to implement a decoupled, unit-testable, N tier architecture based on Generic Repository Pattern with Entity Framework, IoC Container and Dependency Injection in ASP.NET MVC, then I got feedback against the repository/Unit of Work pattern. On googling, I found some more posts:

Say No to the Repository Pattern in your DAL
Repositories On Top UnitOfWork Are Not a Good Idea
Why Entity Framework renders the Repository pattern obsolete?

Entity Framework already implements a repository pattern. Implementing another layer on top of this is not only redundant, but makes maintenance harder. You might want to mock your Entity Framework context rather than using the repository pattern. This post explains how you can implement N Layered app without repository/unit of work pattern on top of EF.

Environment:

1. .NET Framework 4.6.1
2. ASP.NET MVC 5.2
3. Entity Framework 6.1.3 Code First
4. Sql Server LocalDB v11
5. Autofac 3.4
6. Moq 4.5.16
7. Visual Studio 2015 Community Update 3

Conclusion:

We have replaced the Repository/Unit of Work pattern on top of Entity Framework to avoid redundancy. It makes coding simpler and maintenance easier. We have implemented simple CRUD operations and unit testing.
