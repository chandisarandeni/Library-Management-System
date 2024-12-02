# Library Management System

This **Library Management System** is a desktop application developed in **C#** with a **SQL Server** backend. It allows administrators to manage library functions such as borrowing, reserving, and referring books efficiently.

## Features

1. **Admin Management:**
   - Admin login and authentication
   - View and manage admin details

2. **Book Management:**
   - Add, update, and delete book records
   - Search and filter books by category or language
   - Display recently borrowed books

3. **Member Management:**
   - Register new members with encrypted passwords
   - Limit book borrowing to 5 books per member
   - Manage member details and view borrowing history

4. **Borrow and Reservation System:**
   - Assign books to members with a borrowing limit
   - Reserve books and display reservation details
   - Track borrowed and returned books

5. **Inquiries Management:**
   - Store and manage inquiries from library members
   - Display recent inquiries with member details

## Technologies Used

- **Frontend:** C# (Windows Forms)
- **Backend:** SQL Server
- **Database:** Tables for Books, Members, Borrow, Reservations, Inquiries

## Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/chandisarandeni/LibraryManagementSystem.git
   ```
2. Open the solution in Visual Studio.
   ```bash
   string connectionString = "Server=yourServerName; Database=yourDatabaseName; Integrated Security=True;";
   ```
3. Update the ```connectionString``` in the code with your database server details.
4. Run the SQL scripts to create the necessary tables in your SQL Server.

##

- Developer    : Chandisa Randeni
- GitHub Repo  : 
