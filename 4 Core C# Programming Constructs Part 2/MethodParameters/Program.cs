Console.WriteLine("** Method Parameters **");
Console.WriteLine();

int int1 = 9;
int int2 = 10;

Console.WriteLine("Default Behavior for Value Types:");
Console.WriteLine($"Before the method call: int1: {int1}, int2: {int2}.");
Console.WriteLine($"The answer is {DefaultBehaviorForValueTypes(int1, int2)}.");
Console.WriteLine($"After the method call: int1: {int1}, int2: {int2}.");

Console.WriteLine();

Console.WriteLine("Output Parameters:");
// Local variables that are passed as output variables are not required to be assigned before passing them in as output arguments (if you did, then the original value will be lost after the method call).
int answer1;
OutputParameters(int1, int2, out answer1);

// Output parameters don't need to be declared before using them. They can be declared inside the method call.
OutputParameters(int1, int2, out int answer2);
Console.WriteLine($"{int1} + {int2} is {answer2}.");

MultipleOutputParameters(out int int3, out string string1, out bool bool1);
Console.WriteLine($"int3 is {int3}.");
Console.WriteLine($"string1 is {string1}.");
Console.WriteLine($"bool1 is {bool1}.");

// If you don't care about the value of an out parameter, you can use a discard as a placeholder. Discards are dummy variables that are intentionally unused.
MultipleOutputParameters(out _, out _, out _);

Console.WriteLine();

Console.WriteLine("Reference Parameters with Value Types:");

// Reference parameters must be initialized before the are passed to the method. If you don't assign an initial value, that would be the equavalent of operating on an unassigned local variable.
string string2 = "Flip";
string string3 = "Flop";
Console.WriteLine($"Before: string1: {string2}, string2: {string3}.");

ReferenceParametersWithValueTypes(ref string2, ref string3);

Console.WriteLine($"After: string1: {string2}, string2: {string3}.");

Console.WriteLine();

Console.WriteLine("In Modifier:");

// The in modifier passes a value by reference (for both value types and reference types) and prevents the called methods from modifying the values.
Console.WriteLine($"The answer is {InModifier(in int1, in int2)}.");

Console.WriteLine();

Console.WriteLine("Params Modifier:");

double double1;

// You can pass in a comma-delimited list of doubles when using the params modifier.
double1 = ParamsModifier(4.0, 3.2, 5.7, 64.22, 87.2);
Console.WriteLine($"The average is {double1}.");

// Or you could also pass in an array.
double[] doubleArray1 = { 4.0, 3.2, 5.7 };
double1 = ParamsModifier(doubleArray1);
Console.WriteLine($"The average is {double1}.");

Console.WriteLine();

Console.WriteLine("Optional Arguments:");

OptionalArguments("Can't find grid data");
OptionalArguments("Can't find grid data", "Programmer");

Console.WriteLine();

Console.WriteLine("Named Arguments:");

NamedArguments(message: "Message 1", foregroundColor: ConsoleColor.DarkRed, backgroundColor: ConsoleColor.White);
NamedArguments(backgroundColor: ConsoleColor.Green, message: "Message 2", foregroundColor: ConsoleColor.DarkBlue);

// Named and unnamed parameters can be mixed as long as the parameters are in the correct order.

// This works because the positional arguments are listed before the named arguments.
NamedArguments(ConsoleColor.White, foregroundColor: ConsoleColor.Blue, message: "Message 3");

// This also works because all the arguments are in the correct order.
NamedArguments(ConsoleColor.White, foregroundColor: ConsoleColor.Blue, "Message 4");

// Error! The positional arguments are listed after the named arguments.
// NamedArguments(message: "Message 5", backgroundColor: ConsoleColor.White, ConsoleColor.Blue);

// The default way a value type parameter is sent into a function is by value. If you don't mark the argument with a modifier, a copy of the data is passed into the function.
static int DefaultBehaviorForValueTypes(int number1, int number2)
{
    int int1 = number1 + number2;

    // The caller won't see these changes as you're modifying a copy of the original data.
    number1 = 10000;
    number2 = 88888;

    return int1;
}

// Methods that have been defined to take output parameters (via the out keyword) are under obligation to assign them to an appropriate value before exiting the method scope.
static void OutputParameters(int number1, int number2, out int answer)
{
    answer = number1 + number2;
}

static void MultipleOutputParameters(out int int3, out string string1, out bool bool1)
{
    int3 = 9;
    string1 = "Enjoy your string.";
    bool1 = true;
}

static void ReferenceParametersWithValueTypes(ref string string1, ref string string2)
{
    string string3 = string1;
    string1 = string2;
    string2 = string3;
}

static int InModifier(in int number1, in int number2)
{
    // Error! You can't assign a different value to a parameter with an in modifier because it's now a read-only variable.
    // number1 = 10000;

    int answer = number1 + number2;

    return answer;
}

// C# supports the use of parameter arrays using the params keyword. The params keyword allows you to pass a variable number of identically typed parameters as a single parameter into a method.
// C# demands that a method only supports 1 params argument, which must be the final argument in the parameter list.
static double ParamsModifier(params double[] doubleArray)
{
    Console.WriteLine($"You sent me {doubleArray.Length} numbers.");

    double sum = 0;

    if (doubleArray.Length == 0)
    {
        return sum;
    }

    for (int i = 0; i < doubleArray.Length; i++)
    {
        sum += doubleArray[i];
    }

    double average = sum / doubleArray.Length;

    return average;
}

// C# allows you to create methods that can take optional arguments. This technique allows the caller to invoke a method while leaving out arguments deemed unnecesarry.
// To avoid any ambiguity, optional parameters must always be placed at the end of the method signature.
static void OptionalArguments(string errorMessage, string owner = "Default Optional Argument")
{
    Console.WriteLine($"Error: {errorMessage}. Owner: {owner}.");
}

// Named arguments allow you to invoke a method by specifying parameter values in any order you choose. Thus, rather than passing parameters solely by position, you can choose to specify each argument by name using a colon operator.
static void NamedArguments(ConsoleColor backgroundColor, ConsoleColor foregroundColor, string message)
{
    Console.BackgroundColor = backgroundColor;
    Console.ForegroundColor = foregroundColor;

    Console.WriteLine($"{message}.");
}
