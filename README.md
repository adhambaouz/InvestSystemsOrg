# InvestSystems.org

Social network & tools for non-professional investors.

### Architecture

![architecture](https://cloud.githubusercontent.com/assets/8171434/18026939/5e368734-6c56-11e6-8fca-5635ddfab447.png)


### Microservices

* Companies
* Gateway
* Identity
* Portfolio
* RuleOne
* Watchlist


### Folder structure
    .
    ├── client
    │   ├── hybrid                  # Ionic 2 based app for (iOS, Android, Windows)
    │   └── web                     # Angular 2 and Material Design based web app
    ├── docs                        # Documentation
    ├── server
    │   ├── Companies               # Companies microservice
    │   ├── Gamification            # Gamification microservice
    │   ├── Gateway                 # Gateway microservice
    │   ├── Identity                # Identity microservice
    │   ├── InvestSystemsOrg        # Service Fabric project
    │   ├── Portfolio               # Portfolio microservice
    │   ├── RuleOne                 # Rule #1 microservice
    │   ├── Shared                  # Shared code
    │   ├── Watchlist               # Watchlist microservice
    │   └── InvestSystemsOrg.sln    # Solution with all microservices

### Technologies

* Angular 2
* Ionic 2
* Material Design for Angular 2
* ASP.NET Core
* GraphQL
* Swashbuckle
* Entity Framework Core
* xUnit.net
* Service Fabric

### FAQ

> **Q: Why Material Design for web app?**
>
> **A:** Because...