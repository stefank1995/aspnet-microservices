# AspnetMicroservices

ASP.NET Microservices Shopping App with Blazor and Razor Pages as two Client apps communicating through Ocelot API as a gateway(+aggregator) with the APIs that use RabbitMQ as a message-broker, Redis for Cache, MongoDB, PostgreSQL, SQL Server as databases, Dapper and Entity Framework as ORMs, Docker for containerization

### Microservices Architecture
Microservices architecture is an approach to designing and building software applications as a collection of loosely coupled, independently deployable services. This architectural style offers numerous benefits that can enhance the development, deployment, scalability, and maintainability of software systems. 
![MicroservicesApp](https://github.com/stefank1995/aspnet-microservices/assets/132662524/68d392d5-4471-41e0-8282-557923e5c46f)




## Built With

* [ASP.NET](https://dotnet.microsoft.com/en-us/apps/aspnet) - The web framework used
* [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) - Used to persist data from the OrderingAPI
* [MongoDB](https://www.mongodb.com/) - Used to persist data from the CatalogAPI
* [PostgreSQL](https://www.postgresql.org/) - Used to persist data from the DiscountGRPC
* [Redis](https://redis.io/) - Used to cache data from the basket
* [OcelotAPI](https://ocelot.readthedocs.io/en/latest/introduction/gettingstarted.html) - Used as a gateway service
* [RabbitMQ](https://www.rabbitmq.com/) - Used as a message-broker between BasketAPI and OrderingAPI





