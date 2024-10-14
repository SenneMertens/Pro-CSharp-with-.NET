using System.Numerics;

Console.WriteLine("** Fundamental Data Types **");
Console.WriteLine();

LocalVariableDeclarations();
DefaultLiteral();
NewOperator();
SystemObjectInheritedMembers();
NumericalDataTypeMembers();
BooleanDataTypeMembers();
CharDataTypeMembers();
ParsingDataFromStrings();
ParsingDataFromStringsWithTryParse();
DateTimeAndTimeSpanDataTypes();
BigIntegerDataType();
DigitSeparators();
BinaryLiterals();

static void LocalVariableDeclarations()
{
    Console.WriteLine("Data Declarations:");

    // Local variables are declared and initialized as follows: dataType variableName = initialValue.
    int int1 = 0;

    // You can also declare and assign on 2 lines.
    string string1;
    string1 = "This is my character data.";

    // You can also declare and initialize multiple varibales of the same type on a single line.
    bool bool1 = true, bool2 = false, bool3 = bool1;

    // Since the C# keyword is simply a shorthand for the type structure in the System namespace, it's also possible to allocate any data type using its full name.
    System.Boolean bool4 = false;

    Console.WriteLine($"Your data: {int1}, {string1}, {bool1}, {bool2}, {bool3}, {bool4}.");

    Console.WriteLine();
}

static void DefaultLiteral()
{
    Console.WriteLine("Default Literal:");

    // The default literal assigns a variable the default value for its data type.
    int int1 = default;

    Console.WriteLine($"{int1}.");

    Console.WriteLine();
}

static void NewOperator()
{
    Console.WriteLine("Using the new Keyword to Create Variables:");

    // All intrinsic data types support a default constructor. This allows you to create a variable using the new keyword, which automatically sets the variable to its default value.
    bool bool1 = new();         // Set to false.
    int int1 = new();           // Set to 0.
    double double1 = new();     // Set to 0.
    DateTime dateTime1 = new(); // Set to 1/1/0001 12:00:00 AM.

    Console.WriteLine($"{bool1}, {int1}, {double1}, {dateTime1}.");

    Console.WriteLine();
}

static void SystemObjectInheritedMembers()
{
    Console.WriteLine("System.Object Inherited Members:");

    // A C# int is really a shorthand for System.Int32, which inherits the following members from System.Object.
    Console.WriteLine($"12.GetHashCode(): {12.GetHashCode()}.");
    Console.WriteLine($"12.Equals(23): {12.Equals(23)}.");
    Console.WriteLine($"12.ToString(): {12.ToString()}.");
    Console.WriteLine($"12.GetType(): {12.GetType()}.");

    Console.WriteLine();
}

static void NumericalDataTypeMembers()
{
    Console.WriteLine("Numerical Data Type Members:");

    Console.WriteLine($"Minimum of int: {int.MinValue}.");
    Console.WriteLine($"Maximum of int: {int.MaxValue}.");
    Console.WriteLine($"Minimum of double: {double.MinValue}.");
    Console.WriteLine($"Maximum of double: {double.MaxValue}.");

    Console.WriteLine($"double.Epsilon: {double.Epsilon}.");
    Console.WriteLine($"double.PositiveInfinity: {double.PositiveInfinity}.");
    Console.WriteLine($"double.NegativeInfinity: {double.NegativeInfinity}.");

    Console.WriteLine();
}

static void BooleanDataTypeMembers()
{
    Console.WriteLine("Boolean Data Type Members:");

    Console.WriteLine($"bool.TrueString: {bool.TrueString}.");
    Console.WriteLine($"bool.FalseString: {bool.FalseString}.");

    Console.WriteLine();
}

static void CharDataTypeMembers()
{
    Console.WriteLine("Char Data Type Members:");

    char char1 = 'A';

    Console.WriteLine($"char.IsDigit('A'): {char.IsDigit('A')}.");
    Console.WriteLine($"char.IsLetter('A'): {char.IsLetter('A')}.");
    Console.WriteLine($"char.IsWhiteSpace(\"Hello There\", 5): {char.IsWhiteSpace("Hello There", 5)}.");
    Console.WriteLine($"char.IsWhiteSpace(\"Hello There\", 6): {char.IsWhiteSpace("Hello There", 6)}.");
    Console.WriteLine($"char.IsPunctuation('?'): {char.IsPunctuation('?')}.");

    Console.WriteLine();
}

static void ParsingDataFromStrings()
{
    Console.WriteLine("Parsing Data from Strings:");

    bool bool1 = bool.Parse("True");
    Console.WriteLine($"Value of bool1: {bool1}.");

    double double1 = double.Parse("99.884");
    Console.WriteLine($"Value of double1: {double1}.");

    int int1 = int.Parse("8");
    Console.WriteLine($"Value of int1: {int1}.");

    char char1 = 'W';
    Console.WriteLine($"Value of char1: {char1}.");

    Console.WriteLine();
}

static void ParsingDataFromStringsWithTryParse()
{
    Console.WriteLine("Parsing Data from Strings with the TryParse() member:");

    if (bool.TryParse("True", out bool bool1))
    {
        Console.WriteLine($"Value of bool1: {bool1}.");
    }
    else
    {
        Console.WriteLine($"Default value of bool1: {bool1}.");
    }

    string string1 = "Hello";

    if (double.TryParse(string1, out double double1))
    {
        Console.WriteLine($"Value of double1: {double1}.");
    }
    else
    {
        Console.WriteLine($"Failed to convert the input ({string1}) to a double. The variable was instead assigned the default: {double1}.");
    }

    Console.WriteLine();
}

static void DateTimeAndTimeSpanDataTypes()
{
    Console.WriteLine("DateTime and TimeSpan Data Types:");

    // This constructor takes (Year, Month, Day).
    DateTime dateTime1 = new(2015, 10, 17);
    Console.WriteLine($"The day of {dateTime1.Date} is a {dateTime1.DayOfWeek}.");

    dateTime1 = dateTime1.AddMonths(2);
    Console.WriteLine($"Daylight Saving Time: {dateTime1.IsDaylightSavingTime()}.");

    // This constructor takes (Hours, Minutes, Seconds).
    TimeSpan timeSpan1 = new(4, 30, 0);
    Console.WriteLine($"timeSpan1: {timeSpan1}.");
    Console.WriteLine($"timeSpan1.Subtract(new TimeSpan(0, 15, 0)): {timeSpan1.Subtract(new TimeSpan(0, 15, 0))}.");

    // The DateOnly and TimeOnly structures each represent half of the DateTime type.
    DateOnly dateOnly1 = new DateOnly(2021, 07, 21);
    Console.WriteLine($"dateOnly1: {dateOnly1}.");

    TimeOnly timeOnly1 = new(13, 30, 0);
    Console.WriteLine($"timeOnly1: {timeOnly1}.");

    Console.WriteLine();
}

static void BigIntegerDataType()
{
    Console.WriteLine("BigInteger Data Type:");

    // The BigInteger data type resides in the System.Numerics namespace.
    BigInteger bigInteger1 = BigInteger.Parse("9999999999999999999999999999999999999999999999");

    Console.WriteLine($"Value of bigInteger1: {bigInteger1}.");
    Console.WriteLine($"Is bigInteger1 an even value? {bigInteger1.IsEven}.");
    Console.WriteLine($"Is bigInteger1 a power of 2? {bigInteger1.IsPowerOfTwo}.");

    BigInteger bigInteger2 = BigInteger.Multiply(bigInteger1, BigInteger.Parse("8888888888888888888888888888888888888888888"));
    Console.WriteLine($"Value of bigInteger2: {bigInteger2}.");

    Console.WriteLine();
}

static void DigitSeparators()
{
    Console.WriteLine("Digit Separators:");

    Console.WriteLine("Integer: 123_456.");
    Console.WriteLine("Long: 123_456_789L.");
    Console.WriteLine("Float: 123_456_1234F.");
    Console.WriteLine("Double: 123_456.12.");
    Console.WriteLine("Decimal: 123_456.12M.");
    // Hexadecimal values can begin with an _.
    Console.WriteLine("Hexadecimal: 0x_00_00_FF.");

    Console.WriteLine();
}

static void BinaryLiterals()
{
    Console.WriteLine("Binary Literals:");

    Console.WriteLine($"16: {0b_0001_0000}.");
    Console.WriteLine($"32: {0b_0010_0000}.");
    Console.WriteLine($"64: {0b_0100_0000}.");
}