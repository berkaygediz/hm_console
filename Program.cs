string calcu = "-calcu(int)";
string help = "-help(string)";

start:
Console.WriteLine("****HM Console***");
Console.WriteLine("Commands: " + calcu + " , " + help);

#pragma warning disable CS8600
string command = Console.ReadLine();
#pragma warning restore CS8600

if (command == calcu)
{
    Console.WriteLine("**Calculator**");
    string plus = "-hm plus";
    string minus = "-hm minus";
    string multi = "-hm multiplication";
    string division = "-hm division";
    string modulus = "-hm modulus";

    Console.WriteLine("Commands:" + plus + " , " + minus + " , " + multi + " , " + division + " , " + modulus);
#pragma warning disable CS8600
    string cmd = Console.ReadLine();
#pragma warning restore CS8600

    if (cmd == plus)
    {
        Console.WriteLine("**ADDITION**");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        int sum = x + y;
        Console.WriteLine("Result: " + sum);
    }
    else if (cmd == minus)
    {
        Console.WriteLine("**MINUS**");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        int sum = x - y;
        Console.WriteLine("Result: " + sum);
    }
    else if (cmd == multi)
    {
        Console.WriteLine("**MULTIPLICATION**");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        int sum = x * y;
        Console.WriteLine("Result: " + sum);
    }
    else if (cmd == division)
    {
        Console.WriteLine("**DIVISION**");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        if (y != 0)
        {
            int sum = x / y;
            Console.WriteLine("Result: " + sum);
        }
        else
        {
            Console.WriteLine("Partition is invalid. Second number cannot be zero.");
        }
    }
    else if (cmd == modulus)
    {
        Console.WriteLine("**MODULUS**");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        if (y != 0)
        {
            int sum = x % y;
            Console.WriteLine("Result: " + sum);
        }
        else
        {
            Console.WriteLine("Modulus operation invalid. Second number cannot be zero.");
        }
    }
    else
    {
        Console.WriteLine("Invalid command. Please try again.");
        goto start;
    }
    goto start;
}
else if (command == help)
{
    Console.WriteLine("**HELP**");
    Console.WriteLine("Commands: " + calcu + " , " + help);
}
else
{
    Console.WriteLine("Invalid command. Please try again.");
    goto start;
}