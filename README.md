# 🐾 Animal Shelter 🐾
🐈 🐕 🐈‍⬛ 🐩 🐈 🐕 🐈‍⬛ 🐩 🐈 🐕 🐈‍⬛ 🐩🐈 🐕 🐈‍⬛ 🐩 🐈 🐕 🐈‍⬛ 🐩 🐈 🐕 🐈‍⬛ 
#### _C# Week 6 Independent Project, 6/11/2021_

#### By _**Marney Mallory**_

## ✨Description

This week's independent project objective was to build an API implementing full CRUD functionality, one further exploration objective and complete documentation of API endpoints and the further exploration route of choice. I decided to create and API for a local animal shelter that would list all available cats and dogs, supplemented with Swagger documentation.

## ✨Setup and Use

### Prerequisites

- [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- A text editor like [VS Code](https://code.visualstudio.com/)
- A command line interface like Terminal or GitBash to set up and run the project
- MySQL 8.0.19, following [these pinned installation instructions](https://web.archive.org/web/20210521163651/https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql)
- A web browser to view and interact with the project
- Postman 

## ✨Installation

1. Clone the repository: `$ git clone https://github.com/marneymallory/AnimalShelter.Solution.git`
2. Navigate to the `AnimalShelter.Solution` directory on your computer
3. Open with your preferred text editor to view the code base
4. To setup a SQL database using MySQL:
   - Create an `appsettings.json` file in the `AnimalShelter` directory
   - Copy the text box below and paste into the `appsettings.json` file, replacing `<password>` with your MySQL password:
   ```
     {
        "ConnectionStrings": {
           "DefaultConnection": "Server=localhost;Port=3306;database=marney_mallory;uid=root;pwd=<password>;"
         }
     }
   ```
5. To serve the local web app:

- Navigate to `AnimalShelter.Solution/AnimalShelter` in your command line
- Run the commands:
  - `dotnet restore` to restore the dependencies that are listed in `AnimalShelter.csproj`
  - `dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0`
  - `dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2`
  - `dotnet add package Microsoft.EntityFrameworkCore.Design -v 5.0.0`
  - `dotnet ef Migrations add Initial`
  - `dotnet ef database update`
  - `dotnet add AnimalShelter.csproj package Swashbuckle.AspNetCore -v 5.6.3` to implement Swagger.
- Finally, run the command `dotnet run` to run the project!
- Note: `dotnet run` also restores and builds the project, so you can use this single command to start the console app

6. Visit the application via web browser at: `localhost:5000/index.html`

## ✨API Documentation

API endpoints can be accessed with GET, POST, PUT, and DELETE requests in [Postman](https://www.postman.com/downloads/) or a browser.

## ✨Swagger

To explore the AnimalShelter API with  [Swagger](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-5.0&tabs=visual-studio-code):
- Launch using `dotnet run` in the Terminal. 
- Once the project is running, input the URL: http://localhost:5000/index.html to access Swagger documentation. 

## ✨Endpoints/HTTP Requests

Base URL: http://localhost:5000

- GET `/api/animals`: request that returns all instances of Animals.
- GET `/api/animals/{id}`: request that returns a single instance of Animal by ID.
- POST `/api/animals` : creates a new Animal with properties Name, Species, Age, Breed, Description and Gender.
- PUT `/api/animals` : updates existing Animal by updating selected field.
- DELETE `/api/animals` : deletes existing animal. 
 
## ✨Known Bugs

_No known bugs_ :bug:

## ✨Support and contact details

_Please reach out through my GitHub account._

## ✨Technologies Used

- C#
- .NET 5 SDK
- ASP.NET Core 
- Entity Framework Core
- MySQL
- Postman

## ✨License

<details>
<summary><a href="https://opensource.org/licenses/MIT"><strong>MIT</strong></a></summary>
<pre>
MIT License

Copyright (c) 2021 Marney Mallory

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

</pre>
</details>

Copyright © 2021 **_Marney Mallory_**
