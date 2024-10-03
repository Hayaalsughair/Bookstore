# Bookstore MVC Application

This is a simple Bookstore MVC application built using ASP.NET Core. The application allows users to perform CRUD (Create, Read, Update, Delete) operations on books.

## Table of Contents

- [Prerequisites](#prerequisites)
- [Setting Up the Project](#setting-up-the-project)
- [Running the Application](#running-the-application)
- [Using the Application](#using-the-application)
- [Features](#features)
- [Contributing](#contributing)
- [License](#license)

## Prerequisites

Before you begin, ensure you have met the following requirements:

- [.NET Core SDK](https://dotnet.microsoft.com/download/dotnet-core) (version 5.0 or later)
- [Visual Studio](https://visualstudio.microsoft.com/) (or another IDE that supports ASP.NET Core)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

## Setting Up the Project

1. **Clone the repository**:
   ```bash
   git clone https://github.com/Hayaalsughair/Bookstore.git
   cd bookstore
2. **Open the project in Visual Studio**:
	Launch Visual Studio.
	Click on Open a project or solution.
	Navigate to the cloned `bookstore` folder and open the .`sln` file.
3. **Set up the database**:
	Open `AppDbContext.cs` and ensure your connection string is correctly configured for your SQL Server instance.
	Run the following commands in the Package Manager Console to create the database:
	 ```bash
	Add-Migration InitialCreate
	Update-Database 

In the Package Manager Console, run:
## Running the Application

1. **Start the Application**
   - Open the project in Visual Studio.
   - Press `F5` to run the application. This will launch the application in your default web browser.

2. **Access the Application**
   - Once the application is running, navigate to `http://localhost:5000` (or the specified port in your launch settings).
   - You will be directed to the homepage of the Bookstore application, where you can access the CRUD functionality.

### CRUD Functionality

- **Create a Book**
  - Click on the "Create" link to add a new book.
  - Fill in the required fields (Title, Author, Price, Genre) and click the "Submit" button.

- **Read Books**
  - The main page (Index) lists all books in the database.
  - Click on a book's title to view its details.

- **Update a Book**
  - From the details page, click on the "Edit" link to modify the book's information.
  - After making your changes, click the "Update" button to save the changes.

- **Delete a Book**
  - From the details page, click on the "Delete" link to remove the book.
  - Confirm the deletion, and you will be redirected back to the Index page.
  ## Using the Application

Once the application is running, you can perform the following actions:

### View Books
- The homepage displays a list of all books in the bookstore.
- You can click on the **Details** link for any book to view more information.

### Create a Book
1. Click on the **Create Book** button.
2. Fill out the form with the book details:
   - **Title**
   - **Author**
   - **Price**
   - **Genre**
3. Click the **Submit** button to add the book to the database.

### Edit a Book
1. Click on the **Edit** link next to the book you want to modify.
2. Update the book details in the form.
3. Click the **Update** button to save your changes.

### Delete a Book
1. Click on the **Delete** link next to the book you want to remove.
2. Confirm the deletion on the delete confirmation page.

### Search for Books
- Use the search box on the index page to filter books by title or author.

## Features
- Add, edit, and delete books.
- View book details.
- Search for books by title or author.

## Contributing
Contributions are welcome! Please feel free to submit a Pull Request or create an issue for any suggestions or improvements.

## License
This project is licensed under the MIT License. See the LICENSE file for details.
