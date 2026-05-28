# Digital Egypt Pioneers - Full Stack .NET Technical Tasks

This repository contains the technical tasks and practice projects for the **Digital Egypt Pioneers Initiative (DEPI) - Full Stack with .NET path**.

The work is organized by topic and follows the learning path from C# fundamentals to database design, OOP, advanced C#, LINQ, and Entity Framework Core.

## Repository Structure

| Folder | Content |
| --- | --- |
| `1.C#_BASICS` | Introductory C# console applications covering input/output, conditions, loops, arrays, and basic data handling. |
| `2.Database` | Database design tasks for a Product Management System, including requirements, ERD/schema images, DDL scripts, seed data, and SQL queries. |
| `3.OOP` | Object-oriented programming tasks covering classes, structs, properties, constructors, arrays of objects, inheritance, composition, and indexers. |
| `4.C#_Advaned` | Advanced C# practice using a class library project and a console application that references it. |
| `5.LINQ` | LINQ practice over student data, including filtering, sorting, projection, grouping, aggregation, dictionaries, and distinct values. |
| `6.EF` | Entity Framework Core task for a school database with students, teachers, departments, relationships, migrations, seeding, and CRUD operations. |

## Tasks Overview

### 1. C# Basics

- `Task1_ATM`
  - Console-based ATM application.
  - Supports showing balance, depositing, withdrawing, and exiting.
  - Practices menus, loops, conditions, user input, and balance management.

- `Task2_Save_Names`
  - Console application for storing student names.
  - Extends the task by storing four grades per student and calculating total grades.
  - Practices arrays, loops, and simple calculations.

### 2. Database

- `Task1`
  - Product Management System requirement analysis.
  - Includes problem statement, ERD/schema design, and database planning.
  - Main entities include products, categories, suppliers, warehouses, orders, and order items.

- `Task2`
  - SQL DDL script for creating the Product Management System database schema.

- `Task3`
  - SQL scripts for table creation, sample data insertion, and query practice.
  - Covers simple selects, filtering, joins, grouping, and category/product queries.

### 3. OOP

- `Lecture1/Task1`
  - Simple `Product` class with `Id`, `Name`, `Qty`, and `RegistrationDate`.
  - Practices getters, setters, and properties.

- `Lecture2/Task01/Store`
  - Store product management using a `Product` struct.
  - Uses an array of products filled from user input.

- `Lecture2/Task02/Manage_Employee`
  - Employee management console application.
  - Uses an `Employee` class with constructors and an array of employees.

- `Lecture3_4/Task1`
  - Track and course management application.
  - Demonstrates inheritance, composition, constructor chaining, and indexers.
  - Course types include programming, design, and math courses.

### 4. Advanced C#

- `Lecture1/UserServices`
  - Class library containing a reusable `Person` model.

- `Lecture1/app`
  - Console application that references the `UserServices` class library.
  - Practices project references and code reuse across projects.

### 5. LINQ

- `Task1_LINQ`
  - Student list query practice using LINQ.
  - Includes examples of `Where`, `First`, `Sum`, `OrderBy`, `ThenBy`, `Select`, `Any`, `All`, `SingleOrDefault`, `DistinctBy`, `ToDictionary`, `GroupBy`, `Max`, and `Count`.

### 6. Entity Framework Core

- `Task1`
  - EF Core console application for a school database.
  - Models include `Student`, `Teacher`, `Department`, and `TeacherDepartment`.
  - Relationships:
    - Student to Teacher
    - Student to Department
    - Teacher to Department through a join entity
  - Includes migrations, seed data, and CRUD examples from `Main`.

## Requirements

- .NET SDK installed.
  - Some projects target `net8.0`.
  - Some projects target `net10.0`.
- SQL Server for the database and EF Core tasks.
- A C# IDE/editor such as Visual Studio, Rider, or Visual Studio Code.

## How to Run a C# Task

From the repository root, move into the project folder and run:

```bash
dotnet run
```

Example:

```bash
cd 1.C#_BASICS/Task1_ATM
dotnet run
```

For projects that contain a solution file, you can also open the `.sln` file in your IDE.

## How to Run the EF Core Task

1. Open `6.EF/Task1/Context/SchoolDbContext.cs`.
2. Update the SQL Server connection string for your local machine.
3. Run the project:

```bash
cd 6.EF/Task1
dotnet run
```

The application creates the database if needed, seeds sample data, and runs CRUD operations.

## Notes

- `bin` and `obj` folders are generated build output and are not part of the main source code.
- The main learning materials are the `.cs`, `.csproj`, `.sln`, `.sql`, `.md`, `.txt`, and diagram image files.
- Folder names are numbered to match the learning sequence of the .NET full stack path.

