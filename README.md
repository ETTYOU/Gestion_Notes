# Gestion_Notes

## Description
This project is a C# Windows Forms application designed for managing student grades (notes) within an academic institution. It provides functionalities for managing students, courses (matières), and grades, as well as generating statistics.

## Features
-   **Student Management:** Add, edit, delete, and view student information.
-   **Course Management:** Manage academic courses and their coefficients.
-   **Grade Entry:** Input and update student grades for various courses.
-   **Statistical Reports:** View statistical data related to student performance (e.g., average grades).
-   **User Authentication:** (Implied by `Utilisateur` and `Role` tables) Secure access to the application.

## Technologies Used
-   **Frontend:** C# Windows Forms (.NET)
-   **Backend/Logic:** C# Class Libraries (.NET)
-   **Database:** SQL Server (using `System.Data.SqlClient`)
-   **Language:** C#

## Getting Started

### Prerequisites
Before you begin, ensure you have the following installed:
-   **Visual Studio 2022** (or a compatible version) with .NET desktop development workload.
-   **.NET 8.0 SDK** (or the target framework version used in the project).
-   **SQL Server** (e.g., SQL Server Express, SQL Server Developer Edition) installed and running.
-   **SQL Server Management Studio (SSMS)** or a similar tool to execute SQL scripts.

### Installation

1.  **Clone the repository:**
    ```bash
    git clone https://github.com/YOUR_USERNAME/Gestion_Notes.git
    cd Gestion_Notes
    ```
    *(Replace `YOUR_USERNAME` with your GitHub username and `Gestion_Notes` with your repository name if different)*

2.  **Database Setup:**
    a.  Open **SQL Server Management Studio (SSMS)** and connect to your SQL Server instance.
    b.  Create a new database (e.g., `GestionNotesDB`).
    c.  Open the `SQLQuery2.sql` file located in the project root (`Gestion_Notes/SQLQuery2.sql`) in SSMS.
    d.  Execute the script against your newly created database. This script will create the necessary tables and populate them with initial data.

3.  **Configure Database Connection:**
    a.  Open the `Gestion_Notes.sln` solution file in Visual Studio.
    b.  Locate the `ConnexionDB.cs` file in the `GestionNotes.DAL` project.
    c.  Update the connection string in `ConnexionDB.cs` to point to your SQL Server instance and the `GestionNotesDB` database.
        *(Example connection string - adjust as per your SQL Server configuration)*
        ```csharp
        // In GestionNotes.DAL/ConnexionDB.cs
        public static SqlConnection GetConnection()
        {
            // Replace 'YOUR_SERVER_NAME' with your SQL Server instance name (e.g., DESKTOP-ABCDEF\SQLEXPRESS)
            // Replace 'GestionNotesDB' with the name of your database
            string connectionString = "Data Source=YOUR_SERVER_NAME;Initial Catalog=GestionNotesDB;Integrated Security=True;TrustServerCertificate=True";
            return new SqlConnection(connectionString);
        }
        ```
        *Note: If you are using SQL Server Authentication, your connection string will look different (e.g., `User ID=your_user;Password=your_password`).*

4.  **Build the Solution:**
    a.  In Visual Studio, go to `Build` > `Build Solution` (or press `Ctrl+Shift+B`).
    b.  Ensure there are no build errors.

### Running the Application
1.  After a successful build, you can run the application by pressing `F5` or by going to `Debug` > `Start Debugging`.
2.  The application's main form (likely a login screen or main dashboard) should appear.

## Usage
(This section can be expanded with more details on how to use the application's features once it's running.)
-   Log in with the provided test credentials (check `SQLQuery2.sql` for initial user data).
-   Navigate through the different forms (e.g., Student Management, Grade Entry, Statistics) to perform operations.

## Contributing
Contributions are welcome! If you'd like to contribute, please follow these steps:
1.  Fork the repository.
2.  Create a new branch (`git checkout -b feature/YourFeature`).
3.  Make your changes.
4.  Commit your changes (`git commit -m 'Add some feature'`).
5.  Push to the branch (`git push origin feature/YourFeature`).
6.  Open a Pull Request.

## License
This project is licensed under the [MIT License](LICENSE) - see the `LICENSE` file for details.
*(You might need to create a `LICENSE` file in your project root if you don't have one.)*

## Contact
For any questions or inquiries, please open an issue on this GitHub repository.
