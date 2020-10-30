# Animal Shelter API

<p align="center">
    <!-- Project Avatar/Logo -->
    <br>
    <a href="https://www.oregonhumane.org/">
        <img src="https://www.happylifeanimalrescue.org/wp-content/uploads/2020/09/cropped-HAPPY-LIFE-ANIMAL-RESCUE-WEBSITE-HEADER.png">
    </a>
    <p align="center">
      _____________________________________________________________
    </p>
    <!-- GitHub Link -->
    <p align="center">
        <a href="https://github.com/chloehellberg">
          <strong>Chloe Hellberg</strong>
        </a>
    </p>
    <!-- Project Shields -->
    <p align="center">
        <a href="https://www.linkedin.com/in/chloehellberg/">
            <img src="https://img.shields.io/badge/-LinkedIn-black.svg?style=plastic&logo=linkedin&colorB=2867B2">
        </a>
    </p>    
</p>

<p align="center">
  <small>Created October 30th, 2020, Version 1.0</small>
</p>

<!-- Project Links -->
<p align="center">
    <a href="https://github.com/chloehellberg/Animal-Shelter"><big>Project Docs</big></a> ·
    <a href="https://github.com/chloehellberg/Animal-Shelter/issues"><big>Report Bug</big></a> ·
    <a href="https://github.com/chloehellberg/Animal-Shelter/issues"><big>Request Feature</big></a>
</p>

------------------------------
### <u>Table of Contents</u>
* <a href="#🌐-about-the-project">About the Project</a>
    * <a href="#📖-description">Description</a>
    * <a href="#🦠-known-bugs">Known Bugs</a>
    * <a href="#🛠-built-with">Built With</a>
    <!-- * <a href="#🔍-preview">Preview</a> -->
* <a href="#🏁-getting-started">Getting Started</a>
    * <a href="#📋-prerequisites">Prerequisites</a>
    * <a href="#⚙️-setup-and-use">Setup and Use</a>
* <a href="#🛰️-api-documentation">API Documentation</a>
* <a href="#🤝-contributors">Auxiliary</a>
    * <a href="#🤝-contributors">Contributors</a>
    * <a href="#✉️-contact-and-support">Contact</a>
    * <a href="#⚖️-license">License</a>
    
------------------------------

## 🌐 About the Project

### 📖 Description
An API for a local Animal Shelter that lists/tracks the available cats and dogs for adoption. API utilizes RESTful principles, version control, pagination, and has integrated authentication to keep the API Read-Only for all users except administrators. The user is able to see the in-use version of the API when using Postman.

### 🦠 Known Bugs

* Authoriziation not set up on client facing side of application, therefore it is not secure. If you happen to encounter other bugs, please notify the main contributors.

### 🛠 Built With
* [Visual Studio Code](https://code.visualstudio.com/)
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)
* [MySQL](https://dev.mysql.com/)
* [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
* [Swagger](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-nswag?view=aspnetcore-3.1&tabs=visual-studio)
* [Postman](postman.com)

<!-- ### 🔍 Preview -->

------------------------------

## 🏁 Getting Started

### 📋 Prerequisites

#### Install .NET Core
* On macOS Mojave or later
  * [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download the .NET Core SDK from Microsoft Corp for macOS.
* On Windows 10 x64 or later
  * [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp for Windows.

#### Install dotnet script
 Enter the command ``dotnet tool install -g dotnet-script`` in Terminal for macOS or PowerShell for Windows.

#### Install MySQL Workbench
 [Download and install the appropriate version of MySQL Workbench](https://dev.mysql.com/downloads/workbench/).

#### Install Postman
(Optional) [Download and install Postman](https://www.postman.com/downloads/).

#### Code Editor

  To view or edit the code, you will need an code editor or text editor. The popular open-source choices for an code editor are Atom and VisualStudio Code.

  1) Code Editor Download:
     * Option 1: [Atom](https://nodejs.org/en/)
     * Option 2: [VisualStudio Code](https://www.npmjs.com/)
  2) Click the download most applicable to your OS and system.
  3) Wait for download to complete, then install -- Windows will run the setup exe and macOS will drag and drop into applications.
  4) Optionally, create a [GitHub Account](https://github.com)

### ⚙️ Setup and Use

  #### Cloning

  1) Navigate to the [Animal-Shelteer API repository here](https://github.com/chloehellberg/Animal-Shelter).
  2) Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
  3) Open up your system Terminal or GitBash, navigate to your desktop with the command: `cd Desktop`, or whichever location suits you best.
  4) Clone the repository to your desktop: `$ git clone https://github.com/chloehellberg/Animal-Shelter.git`
  5) Run the command `cd Animal-Shelter` to enter into the project directory.
  6) View or Edit:
      * Code Editor - Run the command `atom .` or `code .` to open the project in Atom or VisualStudio Code respectively for review and editing.
      * Text Editor - Open by double clicking on any of the files to open in a text editor.

  #### Download

  1) Navigate to the [Animal-Shelteer API repository here](https://github.com/chloehellberg/Animal-Shelter).
  2) Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
  3) Click 'Download ZIP' and unextract.
  4) Open by double clicking on any of the files to open in a text editor.

  #### AppSettings

  1) Create a new file in the AnimalShelter.Solution/AnimalShelter directory named `appsettings.json`
  2) Add in the following code snippet to the new appsettings.json file:
  
  ```
{
    "Logging": {
        "LogLevel": {
        "Default": "Warning"
        }
    },
    "AllowedHosts": "*",
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter;uid=root;pwd=YourPassword;"
    }
}
  ```
  3) Change the server, port, and user id as necessary. Replace 'YourPassword' with relevant MySQL password (set at installation of MySQL).

  #### Database
  1) Navigate to AnimalShelter.Solution/AnimalShelter directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/AnimalShelter.Solution/AnimalShelter`).
  2) Run the command `dotnet ef database update` to generate the database through Entity Framework Core.
  3) (Optional) To update the database with any changes to the code, run the command `dotnet ef migrations add <MigrationsName>` which will use Entity Framework Core's code-first principle to generate a database update. After, run the previous command `dotnet ef database update` to update the database.

  #### Launch the API
  1) Navigate to AnimalShelter.Solution/AnimalShelter directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/AnimalShelter.Solution/AnimalShelter`).
  2) Run the command `dotnet run` to have access to the API in Postman or browser.

------------------------------

## 🛰️ API Documentation
Explore the API endpoints in Postman or a browser. You will not be able to utilize authentication in a browser.

### Using Swagger Documentation 
To explore the Animal Shelter API with Swagger and easily access API endpoints, launch the project using `dotnet run` with the Terminal or Powershell, and input the following URL into your browser: `http://localhost:5000/swagger`

### Note on Pagination
The Animal Shelter can return a default of 2 results per page at a time, and results can be searched by page if "../?page=1" is included at end of GET call.

To modify this, use the query parameters `page` to alter the response results displayed. The `page` parameter will only display 2 results per page and you must specify calls on specific pages to view additional results.

#### Example Query
```
http://localhost:5000/api/cats/?page=1
```

To use default, _don't include_ `page` or set it equal to zero.

..........................................................................................

### Endpoints
Base URL: `https://localhost:5000`

#### HTTP General Request Structure
```
GET /api/{component}
POST /api/{component}
GET /api/{component}/{id}
PUT /api/{component}/{id}
DELETE /api/{component}/{id}
```

..........................................................................................

### Cats
Access information on cats available for adoption at the shelter.

#### HTTP Request
```
GET /api/Cats
POST /api/Cats
GET /api/Cats/{id}
PUT /api/Cats/{id}
DELETE /api/Cats/{id}
```

#### Path Parameters
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| Name | string | none | True | Return cat matches by name.
| Breed | string | none | True | Return cat matches by breed. |
| Color | string | none | True | Return cat matches by color. |
| Age | int | none | True| Return cat matches by age. |
| Gender | string | none | True | Return cat matches by gender. |

#### Example Query 
```
http://localhost:5000/api/Cats/?gender=Male
```

#### Sample JSON Response
```
{
    "catId": 2,
    "name": "George",
    "breed": "Ragamuffin",
    "color": "Grey",
    "age": 10,
    "gender": "Male"
}
```

..........................................................................................

### Dogs
Access information on cats available for adoption at the shelter.

#### HTTP Request
```
GET /api/Dogs
POST /api/Dogs
GET /api/Dogs/{id}
PUT /api/Dogs/{id}
DELETE /api/Dogs/{id}
```

#### Path Parameters
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| Name | string | none | True | Return dog matches by name.
| Breed | string | none | True | Return dog matches by breed. |
| Color | string | none | True | Return dog matches by color. |
| Age | int | none | True| Return dog matches by age. |
| Gender | string | none | True | Return dog matches by gender. |

#### Example Query
```
http://localhost:5000/api/Dogs/?breed=Labrador
```

#### Sample JSON Response
```
 {
        "dogId": 6,
        "name": "Comet",
        "breed": "Labrador",
        "color": "Yellow",
        "age": 7,
        "gender": "Male"
    },
    {
        "dogId": 7,
        "name": "Lizzie",
        "breed": "Labrador",
        "color": "Yellow",
        "age": 10,
        "gender": "Female"
    }
```


------------------------------

### 🤝 Contributors

| Author | GitHub | Email |
|--------|:------:|:-----:|
| [Chloe Hellberg](https://linkedin.com/in/chloehellberg) | [chloehellberg](https://github.com/chloehellberg) |  [chloe.hellberg@gmail.com](mailto:chloe.hellberg@gmail.com) |

------------------------------

### ✉️ Contact and Support

If you have any feedback or concerns, please contact one of the contributors.

<p>
    <a href="https://github.com/chloehellberg/Animal-Shelter/issues">Report Bug</a> ·
    <a href="https://github.com/chloehellberg/Animal-Shelter/issues">Request Feature</a>
</p>

------------------------------

### ⚖️ License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT). Copyright (C) 2020 Chloe Hellberg. All Rights Reserved.
```
MIT License

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
```

------------------------------

<center><a href="#">Return to Top</a></center>