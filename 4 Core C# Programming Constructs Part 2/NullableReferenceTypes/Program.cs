Console.WriteLine("** Nullable Reference Types **");
Console.WriteLine();

// Nullable reference types use the same symbol (?) to indicate that they're nullable. However, this isn't a shorthand for using System.Nullable<T> as only value types can be used in place of T.
// That's why nullable reference types don't have the Value and HasValue properties, as those are supplied by System.Nullable<T>.

// The project file settings makes the entire project a nullable context. The nullable context allows the declarations of the string and TestClass types to use the nullable annotation (?).
string? nullableString1 = null;
TestClass? nullableTestClass1 = null;

// The following line generates a warning due to the assignment of a null to a non-nullable type.
TestClass testClass1 = nullableTestClass1;

// For finer control of where the nullable contexts are in your project, you can use compiler directives to enable to disable the context.
// The following line turns off the nullable context.
#nullable disable

// Warning! The annotation for nullable reference types should only be used in code within a '#nullable' context.
TestClass nullableTestClass2 = null;
TestClass? nullableTestClass3 = null;
string nullableString2 = null;

// The following line turns the nullable context back on.
#nullable enable

// string? errorMessage = null;
// The errorMessage parameter doesn't have a default value set, so calling it like this will raise a compiler warning.
// Warning! Possible null reference argument for parameter 'errorMessage'.
// EnterLogData(errorMessage);

// Since this project has nullable reference types enabled, the errorMessage and owner parameters aren't nullable.
static void EnterLogData(string errorMessage, string owner = "Programmer")
{
    ArgumentNullException.ThrowIfNull(errorMessage);

    Console.WriteLine($"Error: {errorMessage}. Owner: {owner}.");
}

class TestClass
{
    public string Name { get; set; }
    public int Age { get; set; }
}
