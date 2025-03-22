# HRManagement 🚀

A web-based **HR Management System** built with **ASP.NET Core MVC** to efficiently manage employees and departments.

## 📌 Features
✅ Employee & Department Management  
✅ Create, Read, Update, Delete (CRUD) operations  
✅ Responsive UI with Bootstrap 5  
✅ Active/Inactive Status Badges  
✅ Toast Notifications for Success Messages  
✅ Navbar with Active Page Highlighting  
✅ Secure & Optimized Routing  

---

## 🏗️ Tech Stack
- **Frontend**: Bootstrap 5, jQuery, Toastr.js  
- **Backend**: ASP.NET Core MVC 8  
- **Database**: SQL Server  
- **ORM**: Entity Framework Core  
- **Validation**: Data Annotations & jQuery Validation  

---

## ⚙️ Installation & Setup

### 1️⃣ Clone the Repository
```bash
git clone https://github.com/AnshdMishra/HRManagement.git
cd HRManagement
```

### 2️⃣ Configure the Database
- Update **`appsettings.json`** with your SQL Server connection string:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=HRManagementDB;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```
- Run the following command to apply migrations:
```bash
dotnet ef database update
```

### 3️⃣ Run the Project
```bash
dotnet run
```
- Open `http://localhost:5000/` in your browser.  
- By default, it will navigate to the **Home Page**.

---

## 📖 Usage Guide

### 🔹 Home Page
- Displays a **welcome message** and links to manage employees & departments.

### 🔹 Employee Management
- **Add, Edit, View, and Delete Employees**
- Assign employees to **departments**.
- View employee status (`Active` / `Inactive`).

### 🔹 Department Management
- **Create, Update, Delete Departments**.
- View the department list.

### 🔹 Navigation
- The **navbar highlights the active page** dynamically.
- **"Back to Home"** button on all pages for easy navigation.

---

## 🔧 Default Route Configuration

To ensure that the **Home Page loads by default**, the `Program.cs` file is configured as follows:

```csharp
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); // 👈 This ensures "Home/Index" is the default page
```

---

## 📜 Folder Structure
```
HRManagement/
│-- Controllers/
│   ├── HomeController.cs
│   ├── EmployeeController.cs
│   ├── DepartmentController.cs
│-- Models/
│   ├── Employee.cs
│   ├── Department.cs
│-- Views/
│   ├── Home/
│   │   ├── Index.cshtml
│   ├── Employee/
│   │   ├── Index.cshtml
│   │   ├── Create.cshtml
│   │   ├── Edit.cshtml
│   │   ├── Delete.cshtml
│   │   ├── Details.cshtml
│   ├── Department/
│-- wwwroot/
│   ├── css/
│   ├── js/
│-- appsettings.json
│-- Program.cs
│-- HRManagement.csproj
```

---

## 👥 Contributors
- **Ansh D Mishra** ([@AnshDMishra](https://github.com/AnshDMishra)) - Developer

Want to contribute? Feel free to submit a **Pull Request**! 😊

---

## 📜 License
This project is licensed under the **MIT License**.

---

🚀 **HRManagement** simplifies employee & department management with a **clean UI** and **efficient CRUD operations**. Happy coding! 🎉
