Console.WriteLine("** Console I/O **");
Console.WriteLine();

UserData();
FormatNumericalData();

static void UserData()
{
    Console.Write("Enter your name: ");
    string name1 = Console.ReadLine();

    Console.Write("Enter your age: ");
    string age1 = Console.ReadLine();

    ConsoleColor previousForegroundColor1 = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Yellow;

    Console.WriteLine($"Hello, {name1}! You are {age1} years old.");

    Console.ForegroundColor = previousForegroundColor1;

    Console.WriteLine();
}

static void FormatNumericalData()
{
    Console.WriteLine("The value 99999 in various formats:");

    Console.WriteLine($"c format: {99999:c}.");
    Console.WriteLine($"d9 format: {99999:d9}.");
    Console.WriteLine($"f3 format: {99999:f3}.");
    Console.WriteLine($"n format: {99999:n}.");

    // Notice that uppercasing or lowercasing for hexadecimal values determines if the letters or uppercase or lowercase.
    Console.WriteLine($"E format: {99999:E}.");
    Console.WriteLine($"e format: {99999:e}.");
    Console.WriteLine($"X format: {99999:X}.");
    Console.WriteLine($"x format: {99999:x}.");
}
