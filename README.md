# BudgetBuddy

Welcome to BudgetBuddy, your personal finance management tool developed as a part of the Event-Driven Programming course. This application aims to empower users in handling their finances efficiently and securely. Below, you'll find details about the project, features, technologies, and how we collaborate.

## About the Project
BudgetBuddy is a WinForms application built on the .NET framework, following the MVP (Model-View-Presenter) pattern, implementing the repository pattern, dependency injection, and the singleton pattern. It leverages a SQL Server database for robust and structured data storage.

## Features

### User Authentication

- **Login:** Secure user login with credentials.
- **Register:** New users can register for a BudgetBuddy account.
- **Recovery:** Password recovery through a secure process.

### One-Time Password

- **SMTP via Gmail:** Utilizes Gmail's SMTP server to send one-time passwords for enhanced security during user authentication.

### Security Features

- **Password Encryption:** Passwords are securely hashed using Rfc2898DeriveBytes and salted hash techniques for enhanced security.

### Transactions
- **Send and Request Money:** Seamlessly transfer money between users.
- **Payments:** Effortlessly make payments to vendors or friends.
- **Transaction List:** View a comprehensive list of transactions.

### Bank Integration
- **Checking and Savings Account:** Link and manage your bank accounts securely.

### Data Visualization
- **Expenses Visualization:** Utilize Guna Charts to visualize your expenses.

### Voucher System

- **Voucher Generation:** Implements a voucher system for managing discounts and special offers.

### User Profile
- **Profile Picture:** Customize your profile with a picture.
- **Profile Details:** Update and manage personal details.

## Technologies

- **Database:** SQL Server
- **UI Framework:** WinForms .NET
- **Charting Library:** Guna.Charts.WinForms, Guna.UI2.WinForms
- **Email Handling:** MailKit
- **Object-Relational Mapping:** LINQ to SQL
- **JSON Handling:** Newtonsoft.Json

## Concepts and Principles
- **MVP Pattern:** Implemented using the Model-View-Presenter pattern for a structured and maintainable architecture.
- **Repository Pattern:** Utilizes the repository pattern for efficient data access and manipulation.
- **Dependency Injection:** Promotes loose coupling and maintainability.
- **Singleton Pattern:** Ensures a single instance of key components for consistency.
- **REST API (Bank Integration):** Utilizes a fake JSON server ([metrobank](https://github.com/TimyVillarmia/metrobank)) for simulated bank integration.

## Getting Started

Follow these steps to set up and run BudgetBuddy locally:

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/TimyVillarmia/BudgetBuddy
   ```

2. **Database Setup:**
   - Set up a SQL Server database and update the connection string in the app.

3. **Build and Run:**
   - Open the solution in Visual Studio.
   - Build and run the application.

```sh
/
├─── BudgetBuddy/                             
│   ├─── Models/
│   ├─── Views/
│   │   └─── UserControls/
│   ├─── Presenters/
│   ├─── _Repositories/
│   ├─── Resources/
│   ├─── DataClasses1.dbml/                   
│   └─── Program.cs
├─── packages/                     
├─── BudgetBuddy.sln
└─── README.md

```

## Collaboration
**Design:** Figma for collaborative design.
**Development:** Git for version control.

## Team
- [@John Keith Bicare](https://github.com/jkBicare)
- [@Nhoriel Delima](https://github.com/localdisk54)
- [@Katrina Aton](https://github.com)

## License

This project is licensed under the [MIT License](LICENSE). Feel free to use, modify, and distribute the code for educational and non-commercial purposes. Refer to the license file for more details.




