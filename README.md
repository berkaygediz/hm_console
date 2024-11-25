# HM Console - C++ Command Line Calculator

**HM Console** is a simple C++ command-line application that allows users to perform basic calculator operations.

## Prerequisites

Ensure that you have a C++ compiler installed, such as GCC or Clang, to compile and run the application.

## Usage

1. **Clone the repository:**

   ```bash
   git clone https://github.com/berkaygediz/hm_console.git
   cd hm_console
   ```

2. **Compile the code:**

   If you're using GCC or Clang, run:

   ```bash
   g++ main.cpp -o hm_console
   ```

3. **Run the program:**

   ```bash
   ./hm_console
   ```

## Commands

The following commands are available in the **HM Console**:

- `calcu`: Access the calculator functionality.
- `help`: Display a list of available commands and their descriptions.

### Subcommands for Calculator

Once in the calculator mode, you can use the following subcommands:

- `plus`: Perform addition.
- `minus`: Perform subtraction.
- `multiplication`: Perform multiplication.
- `division`: Perform division.
- `modulus`: Perform modulus operation.
- `exit`: Exit from the calculator or program.

### Example Use Case

```plaintext
------------------
**HM_CONSOLE**
Commands: calcu, help, exit
Enter a command:
calcu

------------------
**SUB-COMMANDS**
Commands: plus, minus, multiplication, division, modulus, exit
Enter a sub-command:
plus

**ADDITION**
Enter the first number:
5
Enter the second number:
3

Result: 8
```

## License

This project is licensed under the Apache License 2.0 - see [LICENSE](LICENSE) for details.
