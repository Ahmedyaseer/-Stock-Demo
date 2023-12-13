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
