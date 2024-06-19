# Expense Tracker ASP.NET MVC Project

This is an ASP.NET MVC project for tracking expenses. The project includes features such as adding income and expenses, categorizing them, and viewing summaries.

## Prerequisites

Before you begin, ensure you have met the following requirements:

- **.NET SDK**: Download and install the [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later).
- **Visual Studio**: Install [Visual Studio](https://visualstudio.microsoft.com/) with the ASP.NET and web development workload.
- **Mysql Server**: 
- **Git**: Install [Git](https://git-scm.com/downloads) to clone the repository.

## Cloning the Repository

To clone the repository, follow these steps:

1. Open a terminal or command prompt.
2. Navigate to the directory where you want to clone the project.
3. Run the following command to clone the repository:

    ```bash
    git clone https://github.com/danujav/expense-tracker.git
    ```

4. Navigate into the project directory:

    ```bash
    cd expense-tracker
    ```

## Running the Project

To run the project, follow these steps:

1. Open the project in Visual Studio:
   - Open Visual Studio.
   - Click on `File` -> `Open` -> `Project/Solution`.
   - Navigate to the `expense-tracker` directory and open the `.sln` file.

2. Restore NuGet packages:
   - Visual Studio will automatically restore the NuGet packages when you open the solution. If not, go to `Tools` -> `NuGet Package Manager` -> `Package Manager Console` and run the command:

    ```powershell
    Update-Package -reinstall
    ```

3. Update the database connection string:
   - Open the `appsettings.json` file.
   - Locate the `ConnectionStrings` section and update the `DefaultConnection` string to match your MySQL server instance. Example:

    ```json
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Database=ExpenseTracker;User=root;Password=yourpassword;"
    }
    ```


4. Apply migrations and create the database:
   - Open the `Package Manager Console` from `Tools` -> `NuGet Package Manager` -> `Package Manager Console`.
   - Run the following commands:

    ```powershell
    Add-Migration InitialCreate
    Update-Database
    ```

5. Build and run the project:
   - Press `F5` or click on `Debug` -> `Start Debugging` to build and run the project.

## Usage

- Once the project is running, navigate to `http://localhost:<port>/` in your web browser.
- Use the navigation bar to access different sections of the application.
- Add, edit, and view your expenses and income entries.

