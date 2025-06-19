# ITI Summer Training – .NET Full Stack Development

Welcome to my official repository for the **Information Technology Institute (ITI) .NET Full Stack Training Program**.

This repo contains all the practical tasks, labs, and final project I completed during the 126-hour intensive training conducted between **August and September 2024**.

---

## 📚 Overview

The ITI training program focused on mastering full-stack development with ASP.NET MVC, C#, Entity Framework, SQL Server, and front-end technologies like HTML, CSS, and Bootstrap.

This repository showcases:
- Hands-on backend implementation
- Database interaction with EF & SQL
- CRUD-based MVC applications
- Final project: **Magazine Website**

---

## 🗂️ Repository Structure

| Folder | Description |
|--------|-------------|
| `EF/EFDay1` | Entity Framework basics, Code First & CRUD operations |
| `Linq/Linq_lab_Day2` | LINQ syntax, queries, and transformations |
| `MVC` | Core ASP.NET MVC labs: Controllers, Views, Models |
| `Magazine_FinalProject` | Final Project – Full CRUD magazine site with article/author management |
| `SQL` | SQL tasks: Joins, normalization, indexing |
| `c#` | Core C# topics: OOP, Classes, Inheritance |

---

## 🎓 Final Project: Magazine Website

The **Magazine Website** project is a full-stack ASP.NET MVC application that allows managing:

- Posts
- Authors
- Departments

### 🛠 Features
- CRUD operations for all entities
- Form validation and error handling
- Responsive design with Bootstrap
- SQL Server integrated with Entity Framework

🔗 [Explore the Final Project](https://github.com/Rahma260/ITI-Summer-Training/tree/main/Magazine_FinalProject)

---

## 🧪 How to Run the Final Project Locally

To run the **Magazine Website** project:

### ✅ 1. Clone the Repository

```bash
git clone https://github.com/Rahma260/ITI-Summer-Training.git
cd ITI-Summer-Training/Magazine_FinalProject
````

### ✅ 2. Open in Visual Studio

* Launch **Visual Studio 2022 or newer**
* Open the `.sln` file inside the `Magazine_FinalProject` folder

### ✅ 3. Restore NuGet Packages

If not done automatically:

* Go to **Tools** → **NuGet Package Manager** → **Package Manager Console**
* Run:

```bash
Update-Package -reinstall
```

### ✅ 4. Set the Startup Project

* Right-click the main project (likely named `Magazine_FinalProject`)
* Select **Set as Startup Project**

### ✅ 5. Configure Database Connection

Edit `appsettings.json` and confirm the connection string:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=MagazineDB;Trusted_Connection=True;"
}
```

> You may need to update `Server=.` to match your local SQL Server instance.

### ✅ 6. Apply Migrations

Open **Package Manager Console** and run:

```bash
Add-Migration InitialCreate
Update-Database
```

### ✅ 7. Run the Application

* Press **F5** or click **Start Debugging**
* Visit `https://localhost:xxxx` in your browser

---

## 🚀 Technologies Used

* **Backend:** C#, ASP.NET MVC, Entity Framework
* **Frontend:** HTML5, CSS3, Bootstrap
* **Database:** SQL Server
* **Tools:** Visual Studio, Git, GitHub

---

## 📜 Certificate Summary

* 📅 Duration: Aug 2024 – Sep 2024
* ⏱️ Hours: 126 (5 hours/day, 6 days/week)
* ✅ Delivered: 17 practical tasks + 1 full project
* 🧠 Gained Skills: C#, OOP, LINQ, EF, MVC, Bootstrap, SQL

---

## 🤝 Credits

This training was conducted by **Information Technology Institute (ITI)**.
All tasks and projects are my own implementations unless otherwise stated.

---

> ⭐ If you like this repository or found it helpful, feel free to star it!

```
