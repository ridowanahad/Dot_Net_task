# RankWebsites
Sample Application that ranks websites based on number of visits created using ReactJS, ASP.NET WEB API, EF

The front end is powered by React JS, that talks to the Microservice to get the data. The MicroService is created using ASP.NET WEBAPI.
The WEB API controllers then talks to the Entity Framework via another service layer. The service layer can be extended to add business
logic. 

This app makes use of NLog to log exceptions and verbose data. 

This app uses UNITY for dependency injection making it easier to UNIT TEST

This App is divided into layers that performs very specific task that makes it easily MAINTAINABLE, Scalable, Modular and extensible.

This app was hosted on AZURE and services were publicly available 


