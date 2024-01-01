
Welcome to Stock Demo Project! This web application is built with ASP.NET 


To get started with Stock Demo Project, follow these steps:

Installation

1- Clone the Repository:

git clone https://github.com/your-username/your-repository.git


2- Navigate to the Project Directory:

cd your-repository



3- Install Dependencies:

dotnet restore


Usage

Prerequisites

Before you begin, ensure that you have the following installed on your machine:

* .NET SDK - [.NET 6.0]
* Other Dependencies,
* Microsoft.EntityFramworkCore(7.0.14)
* Microsoft.EntityFramworkCore.SqlServer(7.0.14)
* Microsoft.EntityFramworkCore.Tools(7.0.14)

  
Running the Application

Build the Project:

dotnet build


Run the Application:

dotnet run

Access the Application:
Open your web browser and go to [http://localhost:5000] (or the specified port) to view [Your Web Application Name].


1* Make sure you changed the connection string in appsetting.jason to your Server Name , Database Name etc..
2* Please write in your Package Manager Console the following commands
2a* Add-Migration "Migration Name"
2b* Update-database







Store Branch Operations (CRUD):

- Allows users to perform CRUD operations on the store branch.
- Includes data validation to ensure data integrity.


Item Operations (CRUD):

- Allows users to perform CRUD operations on items.
- Implements data validation to maintain data quality.


Purchase Invoice Display:

- Displays a purchase invoice with options for selecting a store and items.
- Utilizes asynchronous loading of items based on the selected store.
- Dynamically updates the balance using AJAX when a specific item is chosen.
- Allows users to create a purchase order, which automatically decreases the item balance in the database.


Item Inventory Report:

- Generates a report displaying items across various stores and their respective balances.
- Features a search functionality enabling users to locate specific items and view their balances.
- Enhances user experience by providing detailed information on item distribution within stores.




The project incorporates the following technologies and principles:

Technologies:

- ASP.NET MVC
- Entity Framework
- SQL Server
- AJAX for asynchronous operations


Principles and Patterns:

- Generic Repository Pattern
- Dependency Injection
- SOLID Principles
- LINQ
