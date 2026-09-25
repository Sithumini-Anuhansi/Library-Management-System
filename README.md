# Library Management System

A Windows Forms desktop application for managing a small library — books, authors, and
book lending — built in C# on .NET Framework 4.7.2, with SQL Server for data storage and
Crystal Reports for printable reports.

## Features

* **Login** with role-based access (`Admin` / `User`) via a `tblUser` table
* **Add / View Books** and **Add Authors**
* **Book Lending** workflow
* **Reports**: Book Report, Lending Report, Member Lending Report (Crystal Reports)

Admins see the full menu (add books/authors, lending, lending report). Regular users see
a reduced menu (view books, member lending report only).

## Tech stack

* C# / Windows Forms (.NET Framework 4.7.2)
* SQL Server (via `System.Data.SqlClient`, parameterized queries)
* SAP Crystal Reports for Visual Studio (report design + viewer)

## Project structure

```
LibraryManagementSystem/
├── Login.cs / .Designer.cs / .resx       # Login form
├── LMS.cs / .Designer.cs / .resx         # Main dashboard / menu
├── Add Books.cs / AddAuthors.cs          # Data entry forms
├── ViewBooks.cs / BookLending.cs         # Browsing \& lending
├── BookReport.cs / LendingReport.cs
├── MemberLendingReport.cs                # Report screens
├── \*CrystalReport.cs / \*.rpt             # Crystal Reports definitions
├── Properties/                           # AssemblyInfo, Settings
├── App.config
└── LibraryManagementSystem.csproj
```

## Setup

1. **Prerequisites**

* Visual Studio 2019/2022 with the ".NET desktop development" workload
* SQL Server / SQL Server Express
* [SAP Crystal Reports runtime for Visual Studio](https://help.sap.com/crystal-reports) (needed to open/build the `\*CrystalReport` designer files)

2. **Database**

   * Create a database named `LibraryManagementSystem`.
   * Create the required tables, e.g.:

```sql
     CREATE TABLE tblUser (
         UserName VARCHAR(50),
         Password VARCHAR(50),
         UserType VARCHAR(20)
     );

     CREATE TABLE tblBooks (
         BookID VARCHAR(10) PRIMARY KEY,
         ISBN VARCHAR(20),
         Category VARCHAR(50),
         Name VARCHAR(100),
         Author VARCHAR(100)
     );
     -- plus tables for authors and lending records used by AddAuthors.cs / BookLending.cs
```

* Update the connection string in each form (currently hardcoded, e.g. in `Login.cs` and `Add Books.cs`) to point at your own SQL Server instance:

```csharp
string cs = @"Data Source = YOUR\_SERVER\\SQLEXPRESS; Initial Catalog=LibraryManagementSystem; Integrated Security=True";
```

Ideally, move this into `App.config` and read it via `ConfigurationManager` instead
of duplicating it per form.

3. **Run**

   * Open `LibraryManagementSystem.sln` in Visual Studio.
   * Restore/verify references (Crystal Reports assemblies must be installed locally).
   * Build and run (F5). The app starts on the `Login` form.

## Known limitations / possible improvements

* Connection string is duplicated and hardcoded across forms — should be centralized.
* No password hashing (plaintext comparison against the database).
* No `.gitignore` originally — `bin/`/`obj/` build output has been excluded going forward.
* Direct SQL calls in code-behind, no separation into a data-access/service layer.

---

## Author

**Sithumini Anuhansi**

Software Engineering Undergraduate (NIBM)

[![Email](https://img.shields.io/badge/Email-D14836?style=flat&logo=gmail&logoColor=white)](mailto:anuhansisithumini@gmail.com)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=flat&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/sithumini-anuhansi-5b32a8334)

---

<div align="right">
<img src="https://visitor-badge.laobi.icu/badge?page_id=Sithumini-Anuhansi.Library-Management-System&left_text=Views"/>
</div>
