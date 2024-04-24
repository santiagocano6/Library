### Library Architecture
Library is a simple web application that shows the list of books that are stored in the database. Those are the technologies used for each part of the web app:

- Backend: It is a WebAPI built in .Net 8 WITH C#. The architecture uses multilayer, repository pattern, dependency injections, and code first. This application will be able to escalate horizontally having multiple services running with a load balancer also being a microservice. You will find multiple layers with their responsibility using the SOLID principles in the process. I included code to migrate the database every time that the service runs so we always ensure to have the latest version.

- Database: I used a SQL Server Database. For the time I tried to keep it simple, but a complete version would have to be normalized and create a table for authors, types, and categories. I would have to create some indexes for the searched fields so they will be easier to access.

- Frontend: It is a React web application using javascript, create-react-app, and axios. The architecture uses layers to separate components and services. It can be used as a micro frontend in the future to be used in a container web application.


### How to run the app
- First, create a SQL DB or use an existing one.
- In the .Net solution configure the connection string in the LibrearyService.API appsettings.json and run the application, it automatically should install all dependencies.
- In the React application I used npm so just installed dependencies and ran the app.