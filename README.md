# Library Management System
<p align="center">
  <img src="https://github.com/user-attachments/assets/1f4831e9-803c-4333-8eeb-b08771767c60" width="700px"/>
</p>
This Library Management System is a desktop application developed in C# with a SQL Server backend. It allows administrators to manage library functions such as borrowing, reserving, and referring books efficiently.

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

      <img src="https://github.com/user-attachments/assets/bf8d712a-b160-4f28-8285-3d8435177e63" alt="Visual Studio Solution" width="45px">
      <img src="https://github.com/user-attachments/assets/e1776900-30b7-487a-b85a-2a501322d959" alt="Microsoft Sql Server Image" width="45px">


4. Update the ```connectionString``` in the code with your database server details.
   ```bash
   string connectionString = "Server=yourServerName; Database=yourDatabaseName; Integrated Security=True;";
   ```
   
5. Run the SQL scripts to create the necessary tables in your SQL Server.

   ```sql
   CREATE DATABASE LibraryManagementSystem;
   USE LibraryManagementSystem;
   
   CREATE TABLE Book (
       bookID NVARCHAR(50) PRIMARY KEY,
       bookTitle NVARCHAR(50),
       bookAuthor NVARCHAR(50),
       bookISBN NVARCHAR(50),
       bookCategory NVARCHAR(50),
       bookPublisher NVARCHAR(50),
       bookType NVARCHAR(50),
       bookLanguage NVARCHAR(50),
       bookAdditional NVARCHAR(255),
       bookRegistrationDate DATE,
       isAvailable VARCHAR(10) DEFAULT 'true'
   );
   
   CREATE TABLE adminData (
       adminID NVARCHAR(50) PRIMARY KEY,
       adminName NVARCHAR(255),
       adminNIC NVARCHAR(50),
       adminUsername NVARCHAR(50),
       adminPassword NVARCHAR(255)
   );
   
   INSERT INTO adminData (adminID, adminName, adminNIC, adminUsername, adminPassword)
   VALUES ('A001', 'Admin Name', '123', 'adminUser', '123');
   
   CREATE TABLE libraryMember (
       memberID NVARCHAR(50) PRIMARY KEY,
       memberFullName NVARCHAR(255),
       memberNIC NVARCHAR(50),
       memberAddress NVARCHAR(255),
       memberGender NVARCHAR(50),
       memberContact NVARCHAR(50),
       memberEmail NVARCHAR(50),
       memberPassword NVARCHAR(255),
       memberRegistrationDate DATE
   );
   
   CREATE TABLE borrowBook (
       borrowID NVARCHAR(20) PRIMARY KEY,
       bookID NVARCHAR(50),
       memberID NVARCHAR(50),
       borrowedDate DATE DEFAULT GETDATE(),
       returnDate AS DATEADD(DAY, 14, borrowedDate),
       FOREIGN KEY (bookID) REFERENCES Book(bookID),
       FOREIGN KEY (memberID) REFERENCES libraryMember(memberID)
   );
   
   CREATE TABLE referBook (
       referID NVARCHAR(50) PRIMARY KEY,
       bookID NVARCHAR(50),
       visitorNIC NVARCHAR(50),
       referedDate DATE,
       isReturned VARCHAR(5) DEFAULT 'false',
       FOREIGN KEY (bookID) REFERENCES Book(bookID)
   );
   
   CREATE TABLE Inquiries (
       inquiryID NVARCHAR(50) PRIMARY KEY,
       memberFullName NVARCHAR(255),
       memberContact NVARCHAR(50),
       memberDescription NVARCHAR(500)
   );
   
   CREATE TABLE Reservations (
       reservationID NVARCHAR(50) PRIMARY KEY,
       bookID NVARCHAR(50),
       memberID NVARCHAR(50),
       reservationDescription NVARCHAR(255),
       reservationDate DATE,
       FOREIGN KEY (bookID) REFERENCES Book(bookID),
       FOREIGN KEY (memberID) REFERENCES libraryMember(memberID)
   );
   ```

##

- Developer    : Chandisa Randeni
- GitHub Repo  : https://github.com/chandisarandeni/Library-Management-System
