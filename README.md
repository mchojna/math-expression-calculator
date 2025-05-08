# Math Expression Calculator

This project is a **Math Expression Calculator** implemented using the **Model-View-Presenter (MVP)** design pattern and **WinForms**. It provides a robust calculator application with advanced features such as equation parsing, history management, and file-based calculations.

## Features

### Core Functionality

- **Basic Arithmetic Operations**: Supports addition (`+`), subtraction (`-`), multiplication (`*`), division (`/`), and modulo (`%`).
- **Parentheses Support**: Handles complex expressions with parentheses, e.g., `2 * ((5 - 2) / 3 + 10) = 22`.
- **Division by Zero Validation**: Prevents invalid operations like division by zero and returns `ERROR`.

### History Management

- **Database Integration**: Asynchronously saves calculation history using **Entity Framework** to a database.
- **History Display**: Displays all saved calculations in a history tab.
- **Delete History**: Allows deletion of individual or multiple entries from the history.

### File Operations

- **File-Based Calculations**: Reads equations from a CSV file (`input.csv`), calculates results, and writes them to an output file (`output.csv`).
  - Example:
    - Input (`input.csv`):

      ```
      2+1
      3-2*2
      2/0
      ```

    - Output (`output.csv`)):

      ```
      2+1=3
      3-2*2=-1
      2/0=ERROR
      ```

- **Export History**: Exports the calculation history to a CSV file.

### User Interface

- **Responsive Design**: The calculator UI scales proportionally when the window is resized, similar to the default Windows Calculator.
- **WinForms-Based**: Built using **Windows Forms** for a familiar and intuitive user experience.

## Technical Details

### Design Pattern

The project follows the **Model-View-Presenter (MVP)** pattern:

- **Model**: Handles business logic and data operations (e.g., equation parsing, database interactions).
- **View**: Implements the user interface using WinForms.
- **Presenter**: Acts as the intermediary between the Model and the View, handling user input and updating the UI.

### Technologies Used

- **WinForms**: For the graphical user interface.
- **Entity Framework Core**: For database operations.
- **C#**: The programming language used for the application.
- **.NET 8.0**: The target framework.

### Key Functionalities

1. **Equation Parsing**: Custom implementation for parsing and evaluating mathematical expressions without using external libraries like `Expression`.
2. **Database Integration**: Stores calculation history in a database using **Entity Framework**.
3. **Asynchronous Operations**: Ensures smooth performance by performing database and file operations asynchronously.

## How to Run

1. Clone the repository:

   ```bash
   git clone https://github.com/your-username/math-expression-calculator.git
   cd math-expression-calculator
   ```

2. Open the solution file (Calculator.sln) in Visual Studio.
3. Build the project to restore dependencies.
4. Run the application.

## Requirements

- WinForms, which is Windows-specific.
- .NET 8.0 SDK: Ensure you have the .NET 8.0 SDK installed.
- SQL Server: The application is configured to use SQL Server for storing history.
