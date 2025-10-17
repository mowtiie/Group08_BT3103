# 👚 Saleling: Sales & Inventory Management System

**Saleling** is a comprehensive **Point-of-Sale (POS) and Inventory Management System** specifically designed for a **clothing apparel business**. Developed as a **Windows Forms application**, it utilizes an **event-driven** approach and strictly adheres to the **UI-Model-Controller-Repository (UMCR)** architectural pattern to ensure scalability, maintainability, and a clear separation of concerns.

---

## ✨ Core Features

This system provides all the essential functionalities needed for retail operations, with robust technical and data-integrity features.

### Business Functionalities

| Feature Area | Description | Requirement |
| :--- | :--- | :--- |
| **User & Access** | Secure **Login** with role-based access. Includes **Users Management (CRUD)** **reserved for Admins** to control system access. | Login, User Role Management, Users Management |
| **Dashboards** | Dedicated **Admin Dashboard** for high-level oversight and a streamlined **Cashier Dashboard** for sales operations. | Admin Dashboard, Cashier Dashboard |
| **Product Management** | Complete **Product Maintenance (CRUD)** functionality, initialized with **50 product records**. Products can be searched efficiently by **name or category**. | Product Maintenance, Product Search |
| **Inventory Control** | Real-time tracking of the **Number of Inventory Items**. Automated **Stock Level Alerts** notify staff when apparel stock is low. | Inventory Items, Stock Level Alerts |
| **Sourcing & Structure** | Dedicated **Suppliers Management (CRUD)** and **Categories Management (CRUD)** screens for efficient vendor and product structure control. | Supplier Database, Category Database, Suppliers Management, Categories Management |
| **Sales & Transactions** | Core **Cashiering/Sales** module. Every transaction is saved to the **Transaction History** for auditing. | Cashiering/Sales, Transaction History |
| **Reporting** | Generation of detailed **Inventory and Sales Reports** based on collected sales and stock data. | Inventory & Sales Report |

---

## 🛠️ Technical Implementation

### Architecture: UI-Model-Controller-Repository (UMCR)

The project separates concerns across four distinct layers:

* **UI (User Interface):** Built with **Windows Forms** to display data and handle all **event-driven programming** interactions.
* **Model:** Simple C\# objects that define the data structure (e.g., `Apparel`, `User`, `Transaction`).
* **Controller:** Contains the application's **business logic**. It receives input from the UI and coordinates data flow with the Repository.
* **Repository:** Manages all **data access** operations (CRUD) against the database, abstracting the data source from the Controller.

### Code & Security Principles

* **Secure Password Hashing:** User passwords are secured using the **BCrypt algorithm**, providing strong, slow hashing to protect against brute-force attacks.
* **Error Management:** Extensive use of **`try-catch` / `throw exception`** throughout the application to handle and log errors gracefully, especially in data access and critical business logic.
* **Data Structures:** **C\# Collections** (e.g., `List<T>`) are used to efficiently store and manage groups of related objects, like the product catalog or items in a shopping cart.

### Data Integrity & Database Features

* **Transaction Management:** Implementation of **Database Transact / Rollback** logic ensures data integrity during multi-step operations (e.g., if inventory update fails, the sale record rolls back).
* **Performance:** Utilizes **Stored Procedure** for complex or frequently executed queries.
* **Views:** Employs **Database View** to simplify complex reporting queries and enhance data security.

### Configuration & Logging

* **Configuration File:** An external configuration file holds the **database connection string** and other application settings, allowing for easy updates without code changes.
* **Log File:** All application events, errors, and critical transaction details are saved to the file named **`Saleling.logs`**. This file can be found in the application's runtime directory: `\bin\Debug\net8.0-windows`.

---

## 👥 Team / Collaborators

This project was developed by the following students:

| Role | Name | Email | Course | Year Level |
| :--- | :--- | :--- | :--- | :--- |
| **Leader** | Vrixzandro Eliponga | vrixzandro.jm8b9@slmail.me | BSIT | 3rd Year |
| **Member** | Mark Kerwin Ballelos | markkerwinballelos@gmail.com | BSIT | 3rd Year ||
| **Member** | James Carl Villalobos | villalobosjamescarl30@gmail.com | BSIT | 3rd Year |
| **Member** | Adrienne Jalocon | jaloconadrienne@gmail.com | BSIT | 3rd Year |

---

## 🎓 Instructor / Professor

| Role | Name | Email |
| :--- | :--- | :--- |
| **Professor** | Ervin Abiad | N/A |

---

## 🛠️ Tech Stack

* **Programming Language:** C# (.NET / WinForms or ASP.NET)
* **Database:** Microsoft SQL Server
* **Version Control:** Git & Github
* **IDE:** Microsoft Visual Studio & SQL Server Management Studio

---

## 🚀 Setup & Execution

1.  **Clone the Repository:**
    ```bash
    git clone [Your-Repository-Link-Here]
    ```
2.  **Database Configuration:**
    * Set up your SQL Server database.
    * Update the **connection string** in the application's configuration file to match your local database settings.
3.  **Run the Project:**
    * Open the solution file (`.sln`) in Visual Studio.
    * Build the solution and run the application (F5).

### Default Login Credentials

*Note: Passwords are BCrypt-hashed in the database. These are the plaintext values for login.*

| Role | Username | Password |
| :--- | :--- | :--- |
| **Admin** | `sysadmin` | `sysadminpass` |
| **Cashier** | `john.doe` | `123456789` |
