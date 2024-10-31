Console.WriteLine("** Enumerations **");
Console.WriteLine();

// Because enumerations are a user-defined data type, you can use enumerations as function return values, method parameters, local variables, etc.
EmployeeTypeEnumeration employeeTypeEnumeration1 = EmployeeTypeEnumeration.Contractor;
// Error! You must scope the enumeration name (EmployeeTypeEnumeration) to the value of the enumeration (Contractor).
// EmployeeTypeEnumeration employeeTypeEnumeration2 = Contractor;

AskForBonus(employeeTypeEnumeration1);

Console.WriteLine();

Console.WriteLine("System.Enum Class Members:");

Console.WriteLine($"EmployeeTypeEnumeration uses a {Enum.GetUnderlyingType(employeeTypeEnumeration1.GetType())} for storage.");

// The ToString() method returns the name of the enumeration's value. So the following prints out "Contractor".
Console.WriteLine($"employeeTypeEnumeration1 has the name {employeeTypeEnumeration1.ToString()}.");

// To retrieve an enumeration's value, you cast the enumeration variable against the underlying data type. So the following prints out "100".
Console.WriteLine($"employeeTypeEnumeration1 has a value of {(byte)employeeTypeEnumeration1}.");

// These types are enumerations found in the System namespace.
DayOfWeek dayOfWeek1 = DayOfWeek.Monday;
ConsoleColor consoleColor1 = ConsoleColor.Gray;

EnumerationDetails(employeeTypeEnumeration1);
EnumerationDetails(dayOfWeek1);
EnumerationDetails(consoleColor1);

// An enumeration as a parameter.
static void AskForBonus(EmployeeTypeEnumeration employeeType)
{
    switch (employeeType)
    {
        case EmployeeTypeEnumeration.Manager:
            Console.WriteLine("How about stock options instead?");
            break;
        case EmployeeTypeEnumeration.Grunt:
            Console.WriteLine("You've got to be kidding.");
            break;
        case EmployeeTypeEnumeration.Contractor:
            Console.WriteLine("You already get enough cash.");
            break;
        case EmployeeTypeEnumeration.VicePresident:
            Console.WriteLine("Yes, Sir!");
            break;
    }
}

static void EnumerationDetails(Enum enumeration)
{
    Console.WriteLine($"Information about {enumeration.GetType().Name}.");

    // The static Enum.GetUnderlyingType() method returns the data type to store the values of the given enumeration.
    Console.WriteLine($"Underlying data type: {Enum.GetUnderlyingType(enumeration.GetType())}.");

    // The static Enum.GetValues() method returns an array. Each item in the returned array corresponds to a member of the given enumeration.
    Array enumerationDetailsArray = Enum.GetValues(enumeration.GetType());
    Console.WriteLine($"enumerationDetailsArray has {enumerationDetailsArray.Length} members.");

    // Display the string name and the associated value by using the D format flag.
    for (int i = 0; i < enumerationDetailsArray.Length; i++)
    {
        Console.WriteLine($"Name: {enumerationDetailsArray.GetValue(i)}. Value: {enumerationDetailsArray.GetValue(i):D}.");
    }

    Console.WriteLine();
}

// An enumeration is a custom data type of name-value pairs.
// By default, the storage type used to hold the values of an enumeration is an integer. However, you are free to change this to your liking.
enum EmployeeTypeEnumeration : byte
{
    // The enumeration defines 4 named constants, corresponding to discrete numerical values. By default, the 1st element is set to 0, followed by an n + 1 progression.
    // Enumerations don't necessarily need to follow a sequentiel ordering.
    Manager = 10,
    Grunt = 1,
    Contractor = 100,
    VicePresident = 9
}
