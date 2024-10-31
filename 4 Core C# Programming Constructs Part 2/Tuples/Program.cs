Console.WriteLine("** Tuples **");
Console.WriteLine();

// Tuples are lightweight data structures that contain multiple fields. Tuples use the ValueTuple data type which creates different structures based on the number of properties of the tuple.

// Enclose the values to be assigned to the tuple in parentheses. Notice that they don't all have to be the same data type.
(string, int, string) tuple1 = ("A", 5, "C");
// You can also use the var keyword which causes the compiler to assign the data types for you.
var tuple2 = ("A", 5, "C");

// By default, the compiler assigns each property the name ItemN, where N represents the position in the tuple.
Console.WriteLine($"Item1: {tuple1.Item1}.");
Console.WriteLine($"Item2: {tuple1.Item2}.");
Console.WriteLine($"Item3: {tuple1.Item3}.");

// Specific names can also be added to each property in the tuple on either the left side or the right side of the statement.
(string FirstLetter, int FirstNumber, string SecondLetter) tuple3 = ("A", 5, "C");
var tuple4 = (FirstLetter: "A", FirstNumber: 5, SecondLetter: "C");

// Now the properties on the tuple can be accessed using the field names as well as the ItemN notation.
Console.WriteLine($"FirstLetter: {tuple3.FirstLetter}.");
Console.WriteLine($"FirstNumber: {tuple3.FirstNumber}.");
Console.WriteLine($"SecondLetter: {tuple3.SecondLetter}.");

Console.WriteLine();

Console.WriteLine("Nested Tuples:");

// Tuples can also be nested inside of other tuples. Since each property is a tuple is a data type and a tuple is a data type.
var tuple5 = (4, 5, ("A", "B"));

Console.WriteLine($"Nested Item: {tuple5.Item3}.");

Console.WriteLine();

Console.WriteLine("Inferred Tuple Names:");

// C# has the ability to infer the variable names of tuples.
var tuple6 = new { Property1 = "First", Property2 = "Second" };
var tuple7 = (tuple6.Property1, tuple6.Property2);

Console.WriteLine($"{tuple7.Property1}. {tuple7.Property2}.");

Console.WriteLine();

Console.WriteLine("Tuple Equality and Inequality:");
// When testing for equality, the comparison operators will perform implicit conversions on data types within tuples, including comparing nullable and non-nullable tuples and/or properties.

var tuple8 = (A: 5, B: 10);
(int? A, int? B) tuple9 = (5, 10);
Console.WriteLine($"{tuple8 == tuple9}.");      // True.

(long A, long B) tuple10 = (5, 10);
Console.WriteLine($"{tuple8 == tuple10}.");     // True.

(long A, int B) tuple11 = (5, 10);
(int A, long B) tuple12 = (5, 10);
Console.WriteLine($"{tuple11 == tuple12}.");    // True.

Console.WriteLine();

Console.WriteLine("Tuples as Return Values");

var tuple13 = TuplesAsReturnValues();

Console.WriteLine($"Item1: {tuple13.Item1}.");
Console.WriteLine($"Item2: {tuple13.Item2}.");
Console.WriteLine($"Item3: {tuple13.Item3}.");

Console.WriteLine();

Console.WriteLine("Using Discards with Tuples:");

// By providing variable names for the values you want returned and filling in the unwanted values with an underscore (_) placeholder, you can refine the return value.
var (firstName, _, lastName) = TuplesAsReturnValues();

Console.WriteLine($"{firstName} {lastName}.");

Console.WriteLine();

Console.WriteLine("Tuple Pattern Matching with the Switch Expression:");

string string1 = TuplePatternMatchingWithSwitchExpression("Rock", "Paper");

Console.WriteLine($"{string1}");

(string FirstChoice, string SecondChoice) tuple14 = ("Paper", "Rock");
string string2 = SwitchExpressionWithTupleArgument(tuple14);

Console.WriteLine($"{string2}");

Console.WriteLine();

Console.WriteLine("Deconstructing Tuples:");
// Deconstructing is the term given when separating out the properties of a tuple to be used individually.

(int X, int Y) tuple15 = (4, 5);
// The variables can be pre-initialized.
int int3 = 0;
int int4 = 0;

(int3, int4) = tuple15;
Console.WriteLine($"int3 is {int3}.");
Console.WriteLine($"int4 is {int4}.");

// Or they can be initialized while deconstrucing the tuple.
(int int5, int int6) = tuple15;
Console.WriteLine($"int5 is {int5}.");
Console.WriteLine($"int6 is {int6}.");

// Or they assignment and declaration can also be mixed.
int int7 = 0;

(int7, int int8) = tuple15;
Console.WriteLine($"int7 is {int7}.");
Console.WriteLine($"int8 is {int8}.");

Point point1 = new(7, 5);

var tuple16 = point1.Deconstruct();

Console.WriteLine($"XPosition is {tuple16.XPosition}.");
Console.WriteLine($"YPosition is {tuple16.YPosition}.");

Console.WriteLine();

Console.WriteLine("Deconstructing Tuples with Positional Pattern Matching:");

Point point2 = new(8, 4);
int int9 = 0;
int int10 = 0;

// When tuples have an accessible Deconstruct() method, the deconstruction can happen implicitly without having to call the Deconstruct() method.
(int9, int10) = point2;

Console.WriteLine($"{TupleDeconstructionWithSwitchExpression(point2)}");


// You've used the out parameter to return more than 1 value earlier.
// static void OutParameter(out int int1, out string string1, out bool bool1)
// {
//     int1 = 9;
//     string1 = "Enjoy your string.";
//     bool1 = true;
// }
// By using a tuple, you can remove the out parameters and still get the 3 values back.
static (int Int1, string String1, bool Bool1) TuplesAsReturnValues()
{
    return (9, "Enjoy your string.", true);
}

static (string FirstName, string MiddleName, string LastName) DiscardsWithTuples(string name)
{
    return ("Philip", "F", "Japikse");
}

static string TuplePatternMatchingWithSwitchExpression(string string1, string string2)
{
    // The 2 method parameters are converted into a tuple as they're passed into the switch expression.
    return (string1, string2) switch
    {
        ("Rock", "Paper") => "Paper wins.",
        ("Rock", "Scissors") => "Rock wins.",
        ("Paper", "Rock") => "Paper wins.",
        ("Paper", "Scissors") => "Scissors wins.",
        ("Scissors", "Rock") => "Rock wins.",
        ("Scissors", "Paper") => "Scissors wins",
        (_, _) => "Tie.",
    };
}

// The above method could also be written to take in a tuple as an argument.
static string SwitchExpressionWithTupleArgument((string string1, string string2) tupleArgument)
{
    // The 2 method parameters are converted into a tuple as they're passed into the switch expression.
    return tupleArgument switch
    {
        ("Rock", "Paper") => "Paper wins.",
        ("Rock", "Scissors") => "Rock wins.",
        ("Paper", "Rock") => "Paper wins.",
        ("Paper", "Scissors") => "Scissors wins.",
        ("Scissors", "Rock") => "Rock wins.",
        ("Scissors", "Paper") => "Scissors wins",
        (_, _) => "Tie.",
    };
}

static string TupleDeconstructionWithSwitchExpression(Point point1)
{
    return point1.Deconstruct() switch
    {
        (0, 0) => "Origin.",
        var (X, Y) when X > 0 && Y > 0 => "One.",
        var (X, Y) when X < 0 && Y > 0 => "Two.",
        var (X, Y) when X < 0 && Y < 0 => "Three.",
        var (X, Y) when X > 0 && Y < 0 => "Four.",
        var (_, _) => "Border.",
    };
}

struct Point
{
    public int X;
    public int Y;

    public Point(int xPosition, int yPosition)
    {
        X = xPosition;
        Y = yPosition;
    }

    // The Deconstruct() method has been added to return the individual properties of the Point instance as a tuple, with properties named XPosition and YPosition.
    // This method can be named anything, but by convention it's named Deconstruct(). This allows a single method call to get the individual values of the structure by returning a tuple.
    public (int XPosition, int YPosition) Deconstruct() => (X, Y);

    public void Deconstruct(out int XPosition, out int YPosition) => (XPosition, YPosition) = (X, Y);
}
