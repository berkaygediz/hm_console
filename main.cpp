#include <iostream>
#include <string>
#include <limits>

// commands
const std::string calcu = "calcu";
const std::string help = "help";

// calcu
const std::string plus = "plus";
const std::string minus = "minus";
const std::string multi = "multiplication";
const std::string division = "division";
const std::string modulus = "modulus";

int getIntInput()
{
  int value;
  while (true)
  {
    std::cin >> value;
    if (std::cin.fail())
    {
      std::cin.clear();
      std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
      std::cout << "Invalid input. Please enter a valid integer: ";
    }
    else
    {
      return value;
    }
  }
}

void showHelp()
{
  std::cout << "\n------------------\n**HELP**" << std::endl;
  std::cout << "Commands: " << calcu << ", " << help << "\n------------------\n";
}

void calcuHM()
{
  int x, y, sum;
  std::string subcmd;

  while (true)
  {
    std::cout << "\n------------------\n**SUB-COMMANDS**" << std::endl;
    std::cout << "Commands: " << plus << ", " << minus << ", " << multi << ", " << division << ", " << modulus << ", exit\n--------------\nEnter a sub-command:\n";
    std::cin >> subcmd;

    if (subcmd == plus)
    {
      std::cout << "\n**ADDITION**\nEnter the first number:\n";
      x = getIntInput();
      std::cout << "\nEnter the second number:\n";
      y = getIntInput();
      sum = x + y;
      std::cout << "\nResult: " << sum << std::endl;
    }
    else if (subcmd == minus)
    {
      std::cout << "\n**SUBTRACTION**\nEnter the first number:\n";
      x = getIntInput();
      std::cout << "\nEnter the second number:\n";
      y = getIntInput();
      sum = x - y;
      std::cout << "\nResult: " << sum << std::endl;
    }
    else if (subcmd == multi)
    {
      std::cout << "\n**MULTIPLICATION**\nEnter the first number:\n";
      x = getIntInput();
      std::cout << "\nEnter the second number:\n";
      y = getIntInput();
      sum = x * y;
      std::cout << "\nResult: " << sum << std::endl;
    }
    else if (subcmd == division)
    {
      std::cout << "\n**DIVISION**\nEnter the first number:\n";
      x = getIntInput();
      std::cout << "\nEnter the second number:\n";
      y = getIntInput();
      if (y != 0)
      {
        double divResult = static_cast<double>(x) / y;
        std::cout << "\nResult: " << divResult << std::endl;
      }
      else
      {
        std::cout << "\nError: Division by zero is not allowed!" << std::endl;
      }
    }
    else if (subcmd == modulus)
    {
      std::cout << "\n**MODULUS**\nEnter the first number:\n";
      x = getIntInput();
      std::cout << "\nEnter the second number:\n";
      y = getIntInput();
      if (y != 0)
      {
        sum = x % y;
        std::cout << "Result: " << sum << std::endl;
      }
      else
      {
        std::cout << "Error: Modulus by zero is not allowed!" << std::endl;
      }
    }
    else if (subcmd == "exit")
    {
      return;
    }
    else
    {
      std::cout << "******Invalid command. Please try again.*******" << std::endl;
    }
  }
}

void consoleHM()
{
  std::string cmd;

  while (true)
  {
    std::cout << "\n------------------\n**HM_CONSOLE**" << std::endl;
    std::cout << "Commands: " << calcu << ", " << help << ", exit\nEnter a command:\n";
    std::cin >> cmd;

    if (cmd == calcu)
    {
      calcuHM();
    }
    else if (cmd == help)
    {
      showHelp();
    }
    else if (cmd == "exit")
    {
      break;
    }
    else
    {
      std::cout << "******Invalid command. Please try again.*******" << std::endl;
    }
  }
}

int main()
{
  consoleHM();
  return 0;
}
