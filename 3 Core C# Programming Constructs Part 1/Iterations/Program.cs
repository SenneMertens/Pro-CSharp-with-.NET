Console.WriteLine("** Iterations **");
Console.WriteLine();

ForLoop();
ForEachLoop();
WhileLoop();
DoWhileLoop();
Scope();
IfElse();
IfElseWithPatternMatching();
TernaryConditionalOperator();
TernaryConditionalOperatorWithReference();
LogicalOperators();
Switch();
SwitchWithString();
SwitchWithEnumeration();
SwitchWithGoTo();
SwitchWithPatternMatching();
SwitchWithPatternMatchingAndWhen();
Console.WriteLine(SwitchExpressions("Red"));
Console.WriteLine(SwitchExpressionsWithTuples("Rock", "Paper"));

static void ForLoop()
{
    Console.WriteLine("For Loop:");
    // The for statement is well suited when you need to iterate over a block of code a fixed number of times.

    // Note that i is only visible within the scope of the for loop.
    for (int i = 0; i < 4; i++)
    {
        Console.WriteLine($"The number is {i}.");
    }
    // i isn't visible here.
    Console.WriteLine();
}

static void ForEachLoop()
{
    Console.WriteLine("For Each Loop:");
    // The foreach keyword allows you to iterate over all items in a container without the need to test for an upper limit.

    int[] intArray1 = { 10, 20, 30, 40 };

    // Notice that the data type before the in keyword represents the type of data in the container.
    foreach (int number in intArray1)
    {
        Console.WriteLine(number);
    }

    Console.WriteLine();
}

static void WhileLoop()
{
    Console.WriteLine("While Loop:");

    string string1 = "";

    while (string1.ToLower() != "yes")
    {
        Console.WriteLine("In while loop.");

        Console.Write("Are you done? ");
        string1 = Console.ReadLine();
    }

    Console.WriteLine();
}

static void DoWhileLoop()
{
    Console.WriteLine("Do/While Loop:");

    string string1 = "";

    do
    {
        Console.WriteLine("In do/while loop.");

        Console.Write("Are you done? ");
        string1 = Console.ReadLine();
    } while (string1.ToLower() != "yes"); // Note the semicolon at the end.

    Console.WriteLine();
}

static void Scope()
{
    Console.WriteLine("Scope:");

    // A scope is created using curly braces.
    for (int i = 0; i < 4; i++)
    {
        Console.WriteLine($"The number is {i}.");
    }

    // For 1 line statements, it's allowed to leave out the curly braces.
    for (int i = 0; i < 4; i++)
        Console.WriteLine($"The number is {i}.");

    // The 2nd statement isn't part of the for loop and will result, if you're lucky, in a compilation error.
    // for (int i = 0; i < 4; i++)
    //     Console.WriteLine($"The number is {i}.");
    //     Console.WriteLine($"The number + 1 is {i + 1}.");

    Console.WriteLine();
}

static void IfElse()
{
    Console.WriteLine("If/Else:");

    string string1 = "My textual data.";

    // Unlike in some other programming languages, the if/else statement in C# operates only on Boolean expressions and not ad hoc values such as -1 or 0.
    if (string1.Length > 0)
    {
        Console.WriteLine("The string is greater than 0 characters.");
    }
    else
    {
        Console.WriteLine("The string isn't greater than 0 characters.");
    }

    Console.WriteLine();
}

static void IfElseWithPatternMatching()
{
    Console.WriteLine("If/Else with Pattern Matching:");

    object object1 = "Hello";
    object object2 = 123;

    // You can check the type of an object using the is keyword, assign that object to a variable and then use that variable.
    if (object1 is string string1)
    {
        Console.WriteLine($"{object1} is a string.");
    }

    if (object2 is int int1)
    {
        Console.WriteLine($"{object2} is an int.");
    }

    Type type1 = typeof(string);
    char char1 = 'F';

    // Type patterns check if a variable is a type.
    if (type1 is Type)
    {
        Console.WriteLine($"{type1} is a Type.");
    }

    // Parenthesized patterns enforce or emphasize the precedence of pattern combinations.
    if (char1 is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',')
    {
        Console.WriteLine($"{char1} is a character or a separator.");
    }

    // Negated (NOT) patterns require that a pattern doesn't match.
    if (object2 is not string)
    {
        Console.WriteLine($"{object2} is not a string.");
    }

    if (object2 is not null)
    {
        Console.WriteLine($"{object2} is not null.");
    }

    // Conjunctive (AND) patterns require both patterns to match.
    // Disjunctive (OR) patterns require either pattern to match.
    // Relational patterns require input to be less than, less than or equal, greater than, or greater than or equal.
    if (char1 is >= 'a' and <= 'z' or >= 'A' and <= 'Z')
    {
        Console.WriteLine($"{char1} is a character.");
    }

    Console.WriteLine();
}

static void TernaryConditionalOperator()
{
    Console.WriteLine("Ternary Conditional Operator:");
    // The conditional operator (?:), also known as the ternary conditional operator, is a shorthand method of writing an if/else statement.

    string string1 = "My textual data.";

    string string2 = string1.Length > 0 ? "The string is greater than 0 characters." : "The string isn't greater than 0 characters.";
    Console.WriteLine($"{string2}");

    // Error! The ternary conditional operator can only be used in assignment calls.
    // string1.Length > 0 ? Console.WriteLine("The string is greater than 0 characters.") : Console.WriteLine("The string isn't greater than 0 characters.");

    Console.WriteLine();
}

static void TernaryConditionalOperatorWithReference()
{
    Console.WriteLine("Ternary Conditional Operator with Reference:");

    int[] intArray1 = new int[] { 1, 2, 3, 4, 5 };
    int[] intArray2 = new int[] { 10, 20, 30, 40, 50 };
    int index = 7;

    ref int referenceValue = ref ((index < 5) ? ref intArray1[index] : ref intArray2[index - 5]);

    referenceValue = 0;
    index = 2;

    ((index < 5) ? ref intArray1[index] : ref intArray2[index - 5]) = 100;

    Console.WriteLine($"{string.Join(" ", intArray1)}.");
    Console.WriteLine($"{string.Join(" ", intArray2)}.");

    Console.WriteLine();
}

static void LogicalOperators()
{
    Console.WriteLine("Logical Operators:");
    // The && and || operators both short-circuit when necesarry. This means that after a complex expression has been determined to be false, the remaining subexpressions won't be checked. If your require all expressions to be tested regardless, you can use the & and | operators.

    bool bool1 = true;
    bool bool2 = false;

    Console.WriteLine($"{bool1} && {bool1}: {bool1 && bool1}."); // True
    Console.WriteLine($"{bool1} && {bool2}: {bool1 && bool2}."); // False
    Console.WriteLine($"{bool1} || {bool1}: {bool1 || bool1}."); // True
    Console.WriteLine($"{bool1} || {bool2}: {bool1 || bool2}."); // True
    Console.WriteLine($"{bool2} || {bool2}: {bool1 || bool2}."); // False
    Console.WriteLine($"!{bool1}: {!bool1}.");                   // False
    Console.WriteLine($"!{bool2}: {!bool2}.");                   // True

    Console.WriteLine();
}

static void Switch()
{
    Console.WriteLine("Switch:");

    Console.WriteLine("1: [C#] 2: [VB]");
    Console.Write("Choose a language: ");
    string string1 = Console.ReadLine();
    int int1 = int.Parse(string1);

    switch (int1)
    {
        case 1:
            Console.WriteLine("You have chosen C#.");
            // C# demands that each case (including default) that contains executable statements have a terminating return, break, or goto to avoid falling through to the next statement.
            break;
        case 2:
            Console.WriteLine($"You have chosen VB.");
            break;
        default:
            Console.WriteLine($"Invalid choice.");
            break;
    }

    Console.WriteLine();
}

static void SwitchWithString()
{
    Console.WriteLine("Switch with a String:");

    Console.WriteLine("[C#] or [VB]");
    Console.Write("Choose a language: ");
    string string1 = Console.ReadLine();

    switch (string1.ToUpper())
    {
        case "C#":
            Console.WriteLine("You chose C#.");
            break;
        case "VB":
            Console.WriteLine($"You chose VB.");
            break;
        default:
            Console.WriteLine($"Invalid choice.");
            break;
    }

    Console.WriteLine();
}

static void SwitchWithEnumeration()
{
    Console.WriteLine("Switch with an Enumeration:");

    DayOfWeek dayOfWeek1 = default;

    Console.Write("Enter your favorite day of the week: ");

    try
    {
        dayOfWeek1 = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
    }
    catch (Exception exception)
    {
        Console.WriteLine("Choose a valid day of the week.");
    }

    switch (dayOfWeek1)
    {
        case DayOfWeek.Monday:
            Console.WriteLine($"Your favorite day is Monday.");
            break;
        case DayOfWeek.Tuesday:
            Console.WriteLine($"Your favorite day is Tuesday.");
            break;
        case DayOfWeek.Wednesday:
            Console.WriteLine($"Your favorite day is Wednesday.");
            break;
        case DayOfWeek.Thursday:
            Console.WriteLine($"Your favorite day is Thursday.");
            break;
        case DayOfWeek.Friday:
            Console.WriteLine($"Your favorite day is Friday.");
            break;
        case DayOfWeek.Saturday:
        case DayOfWeek.Sunday:
            Console.WriteLine($"Your favorite day is in the weekend.");
            break;
    }

    Console.WriteLine();
}

static void SwitchWithGoTo()
{
    Console.WriteLine("Switch with GoTo:");
    // The goto keyword allows you to exit a case condition and execute another case statement.

    int int1 = 5;

    switch (int1)
    {
        case 1:
            // Do something.
            goto case 2;
        case 2:
            // Do something.
            break;
        case 3:
            // Do something.
            goto default;
        default:
            // The default action.
            break;
    }

    Console.WriteLine();
}

static void SwitchWithPatternMatching()
{
    Console.WriteLine("Switch with Pattern Matching:");

    Console.WriteLine("1: [Integer (5)] 2: [String (\"Hi\") 3: [Decimal (2.5)]");

    Console.Write("Choose an option: ");
    string string1 = Console.ReadLine();

    object object1 = null;

    // This is the standard constant pattern switch statement.
    switch (string1)
    {
        case "1":
            object1 = 5;
            break;
        case "2":
            object1 = "Hi";
            break;
        case "3":
            object1 = 2.5M;
            break;
    }

    // This is the new pattern matching switch statement. Based on the type of the variable, different case statements are matched.
    switch (object1)
    {
        // In addition to checking the data type of the variable, a variable is assigned in each of the case statements.
        case int int1:
            Console.WriteLine($"You chose an integer: {int1}.");
            break;
        case string string2:
            Console.WriteLine($"You chose a string: {string2}.");
            break;
        case decimal decimal1:
            Console.WriteLine($"You chose a decimal: {decimal1}.");
            break;
    }

    Console.WriteLine();
}

static void SwitchWithPatternMatchingAndWhen()
{
    Console.WriteLine("Switch with Pattern Matching and When:");
    // The when clause can be added to the case statement to evaluate a condition on the variable.

    Console.WriteLine("1: [C#] 2: [VB]");

    Console.Write("Choose a language: ");
    object object1 = Console.ReadLine();

    var choice = int.TryParse(object1.ToString(), out int int3) ? int3 : object1;

    switch (choice)
    {
        // In addition to checking the type, the value of the converted type ie also checked for a match.
        case int int1 when int1 == 1:
        case string string1 when string1.Equals("C#", StringComparison.OrdinalIgnoreCase):
            Console.WriteLine("You chose C#.");
            break;
        case int int2 when int2 == 2:
        case string string2 when string2.Equals("VB", StringComparison.OrdinalIgnoreCase):
            Console.WriteLine("You chose VB.");
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }

    Console.WriteLine();
}

static string SwitchExpressions(string color)
{
    Console.WriteLine("Switch Expressions:");
    // Switch expressions allow the assignment of a variable in a more concise statement.

    // The old way of this method takes in a color and returns a hex value for the color name.
    // switch (color)
    // {
    //     case "Red":
    //         return "#FF0000";
    //     case "Orange":
    //         return "#FF7F00";
    //     case "Yellow":
    //         return "#FFFF00";
    //     case "Green":
    //         return "#00FF00";
    //     case "Blue":
    //         return "#0000FF";
    //     case "Indigo":
    //         return "#4B0082";
    //     case "Violet":
    //         return "#9400D3";
    //     default:
    //         return "#FFFFFF";
    // }

    // The modern way of this method, using the switch expression, is much more concise.
    return color switch
    {
        "Red" => "#FF0000",
        "Orange" => "#FF7F00",
        "Yellow" => "#FFFF00",
        "Green" => "#00FF00",
        "Blue" => "#0000FF",
        "Indigo" => "#4B0082",
        "Violet" => "#9400D3",
        _ => "#FFFFFF",
    };
}

static string SwitchExpressionsWithTuples(string string1, string string2)
{
    Console.WriteLine("Switch Expressions with Tuples:");

    // The 2 values passed into this method are converted to a tuple.
    return (string1, string2) switch
    {
        // The switch expression evaluates the 2 values in a single expression. This pattern allows for comparing more than 1 value during a switch statement.
        ("Rock", "Paper") => "Paper wins.",
        ("Rock", "Scissors") => "Rock wins.",
        ("Paper", "Rock") => "Paper wins.",
        ("Paper", "Scissors") => "Scissors wins",
        ("Scissors", "Rock") => "Rock wins.",
        ("Scissors", "Paper") => "Scissors wins.",
        (_, _) => "Tie.",
    };
}
