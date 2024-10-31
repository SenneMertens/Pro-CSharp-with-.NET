Console.WriteLine("** Nullable Value Types **");
Console.WriteLine();

// C# data types have a fixed range and are represented as a type in the System namespace. For example, the System.Boolean data type can be assigned a value from the set {true, false}.
// Recall that all numerical data types are value types. Value types can never be assigned the value of null, as that's used to establish an empty object reference.
//
// Error! Value types can't be set to null.
// bool bool1 = null;
// int int1 = null.
//
// C# supports the concept of nullable data types. A nullable data type can represent all the values of its underlying type, plus the value null. Thus, if you declare a nullable bool, it could be assigned a value from the set {true, false, null}.

DatabaseReader databaseReader1 = new();

int? int1 = databaseReader1.GetIntFromDatabase();

if (int1.HasValue)
{
    Console.WriteLine($"The value of int1 is {int1.Value}.");
}

bool? bool1 = databaseReader1.GetBoolFromDatabase();

if (bool1 != null)
{
    Console.WriteLine($"The value of bool1 is {bool1.Value}.");
}

Console.WriteLine();

Console.WriteLine("Null-Coalescing Operator:");
// The null-coalescing operator (??) allows you to assign a value to a nullable type if the retrieved value is in fact null.

// If the value from the GetIntFromDatabase() method is null, assign the local variable to 100.
int int2 = databaseReader1.GetIntFromDatabase() ?? 100;
Console.WriteLine($"int2 has a value of {int2}.");

int? int3 = databaseReader1.GetIntFromDatabase();
// The benefit of using the ?? is that it provides a more compact version of a traditional if/else condition.
if (!int3.HasValue)
{
    int3 = 100;
}

Console.WriteLine($"int3 has a value of {int3}.");

Console.WriteLine();

Console.WriteLine("Null-Coalescing Assignment Operator:");

// The null-coalescing assignment operator assigns the left-hand side to the right-hand side only if the left-hand side is null.
int? int4 = null;
int4 ??= 12;
int4 ??= 14;

Console.WriteLine($"int4 has a value of {int4}.");

NullConditionalOperator(null);

static void LocalNullableVariables()
{
    // To define a nullable variable type, the question mark symbol (?) is suffixed to the underlying data type.
    int? int1 = null;
    double? double1 = null;
    bool? bool1 = null;
    char? char1 = null;
    int?[] array1 = new int?[10];
}

static void LocalNullableVariablesUsingNullableGenericType()
{
    // The ? suffix notation is a shorthand for creating an instance of the generic System.Nullable<T> structure type.
    Nullable<int> int1 = null;
    Nullable<double> double1 = null;
    Nullable<bool> bool1 = null;
    Nullable<char> char1 = null;
    Nullable<int>[] array1 = new Nullable<int>[10];
}

static void NullConditionalOperator(string[] arguments)
{
    // if (arguments != null)
    // {
    //     Console.WriteLine($"You sent me {arguments.Length} arguments.");
    // }

    // C# includes the null conditional operator token, a ? placed after the variable but before the access operator(.).
    // If the arguments variable is null, its call to the Length property will not throw a runtime error.
    Console.WriteLine($"You sent me {arguments?.Length} arguments.");

    // If you want to print an actual value, you could leverage the null-coalescing operator to assign a default value.
    Console.WriteLine($"You sent me {arguments?.Length ?? 0} arguments.");
}

class DatabaseReader
{
    public int? numericValue = null;
    public bool? booleanValue = true;

    public int? GetIntFromDatabase()
    {
        return numericValue;
    }

    public bool? GetBoolFromDatabase()
    {
        return booleanValue;
    }
}
