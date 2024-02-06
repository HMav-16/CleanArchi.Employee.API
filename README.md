Complete solution for Clean architecture using .NET Core

Domain
This will contain all entities, enums, exceptions, interfaces, types and logic specific to the domain layer.

Application
This layer contains all application logic. It is dependent on the domain layer, but has no dependencies on any other layer or project. This layer defines interfaces that are implemented by outside layers. For example, if the application need to access a notification service, a new interface would be added to application and an implementation would be created within infrastructure.

Infrastructure
This layer contains classes for accessing external resources such as file systems, web services, smtp, and so on. These classes should be based on interfaces defined within the application layer.

WebApi
This layer is a web api application based on ASP.NET 6.0.x. This layer depends on both the Application and Infrastructure layers, however, the dependency on Infrastructure is only to support dependency injection. Therefore only Startup.cs should reference Infrastructure.

Clean Architecture
Complete solution template which is built on Clean Architecture with all essential feature using .NET Core!
Explore the docs »


Clean Architecture
Clean Architecture was introduced by by Robert C. Martin (Uncle Bob) to provide a better way to build applications in perspective of better testability, maintainability, and dependability on the infrastructures like databases and services

Domain in center and building layer top of it. You can call it as Domain-centric Architecture too.

Though layer architectures like onion, Hexagonal all vary somewhat in their details, they are very similar. All DDD approach have the same objective, which is the separation of concerns.

Reference
Clean Architecture by Robert C. Martin (Uncle Bob)
About The Project
This project provides complete solution which is built on Clean Architecture with all essentia, feature CI/CD, best practice, testing Strategy using .NET Core.

image

Technology stack
Architecture Pattern

 Clean architecture
 (Includes)
 Screaming architecture-Functional organisation design
 Onion archhitecture
Design Pattern

 CQRS design pattern
 Decorator design pattern
 Mediator design pattern
 Repository design pattern
 Unit of work
 Factory design pattern
Backend

 Language: C#
 Framework: dotnet core 6, ASP.NET Core
UI : N/A  
Database
 MS SQL Server
 DB Connectivity : Entityframework Core - Code First
 
Service
 Web API (Restful service)
 
Feature

 Automapper
 Fluent validation
 Swagger UI
 Advanced Pagination
 Enabling CORS with CustomPolicy

 Conventional commit - commit and commit message
 Docsify
Licence Used
GitHub license

See the contents of the LICENSE file for details


![Clean-api-employee](https://github.com/HMav-16/CleanArchi.Employee.API/assets/148790419/3f654da1-ad34-4f6a-8342-b373e49874c8)

![get-employee](https://github.com/HMav-16/CleanArchi.Employee.API/assets/148790419/79bd5b0d-1131-456f-8038-04b82d4be46c)

![get-by-id-employee](https://github.com/HMav-16/CleanArchi.Employee.API/assets/148790419/4f33c2aa-309b-48e5-ada0-2fd46a7c76fa)
