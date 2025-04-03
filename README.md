# Customer Bill

## Overview
Customer Bill is a command-line-based application written in C#. It is designed to calculate customer electricity bills using complex logic. This application is ideal for utility companies or any organization that needs to manage and compute electricity bills for their customers.

## Features
- Command-line interface for easy interaction.
- Complex logic to accurately calculate electricity bills.
- Handles various tariff rates and billing periods.
- Generates detailed billing reports.

## Getting Started

### Prerequisites
- .NET Core SDK 3.1 or later.

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/OneSAHDEVSINH/CustomerBill.git
   ```
2. Navigate to the project directory:
   ```bash
   cd CustomerBill
   ```
3. Build the project:
   ```bash
   dotnet build
   ```

### Running the Application
1. Navigate to the `bin` directory where the compiled application resides:
   ```bash
   cd bin/Debug/netcoreapp3.1
   ```
2. Run the application:
   ```bash
   dotnet CustomerBill.dll
   ```

### Usage
Upon running the application, you will be prompted to enter customer details and electricity usage information. Follow the on-screen instructions to input the required data. The application will then compute and display the electricity bill.

### Example
```plaintext
Enter customer name: John Doe
Enter electricity usage (kWh): 150
Calculating bill...
Customer: John Doe
Usage: 150 kWh
Total Bill: $45.00
```

## Project Structure
- `Program.cs`: The main entry point of the application.
- `BillCalculator.cs`: Contains the logic for calculating the electricity bill.
- `Customer.cs`: Represents a customer entity.
- `README.md`: This file.

## Contributing
Contributions are welcome! Please fork the repository and submit a pull request.

## License
This project is licensed under the MIT License. See the `LICENSE` file for more details.

## Contact
If you have any questions or suggestions, feel free to reach out to the repository owner.

---

Thank you for using Customer Bill!
