using System.Runtime.CompilerServices;
using System.Text;

Console.WriteLine("** Strings **");
Console.WriteLine();

BasicStringMembers();
StringConcatenation();
EscapeCharacters();
StringInterpolation();
StringInterpolationWithDefaultInterpolatedStringHandler();
VerbatimStrings();
StringEquality();
StringEqualityWithStringComparison();
StringsAreImmutable();
StringsWithStringBuilder();

static void BasicStringMembers()
{
    Console.WriteLine("Basic String Members:");

    string string1 = "Freddy";

    Console.WriteLine($"Value of string1: {string1}.");
    Console.WriteLine($"string1 has {string1.Length} characters.");
    Console.WriteLine($"string1 in lowercase: {string1.ToLower()}.");
    Console.WriteLine($"string1 in uppercase: {string1.ToUpper()}.");
    Console.WriteLine($"Does string1 contain the letter 'y'? {string1.Contains('y')}.");
    Console.WriteLine($"New string1: {string1.Replace("Dy", "")}.");

    Console.WriteLine();
}

static void StringConcatenation()
{
    Console.WriteLine("String Concatenation:");

    string string1 = "Programming the ";
    string string2 = "Psychodrill (PTP).";
    // The + symbol is processed by the compiler to emit a call to the static String.Concat() method.
    string string3 = string1 + string2;
    Console.WriteLine($"{string3}");

    string string4 = string.Concat(string1, string2);
    Console.WriteLine($"{string4}");

    Console.WriteLine();
}

static void EscapeCharacters()
{
    Console.WriteLine("Escape Characters:");

    string string1 = "Model\tColor\tSpeed\tName";
    Console.WriteLine($"{string1}");

    Console.WriteLine("\"Hello World\"");
    Console.WriteLine("C:\\MyApp\\bin\\Debug");
    Console.WriteLine("All finished.\n\n\n");
    Console.WriteLine($"All finished for real this time.{Environment.NewLine}{Environment.NewLine}{Environment.NewLine}");
}

static void StringInterpolation()
{
    Console.WriteLine("String Interpolation:");

    // Some local variables which we'll plug into our string.
    string string1 = "Soren";
    int int1 = 4;

    string string2 = $"Hello {string1.ToUpper()}, you are {int1} years old.";
    Console.WriteLine($"{string2}");

    Console.WriteLine();
}

static void StringInterpolationWithDefaultInterpolatedStringHandler()
{
    Console.WriteLine("String Interpolation with the DefaultInterpolatedStringHandler class:");

    string string1 = "Soren";
    int int1 = 4;

    // The compiler uses the DefaultInterpolatedStringHanlder class behind the scenes when using string interpolation.
    DefaultInterpolatedStringHandler defaultInterpolatedStringHandler1 = new();

    defaultInterpolatedStringHandler1.AppendLiteral("Hello ");
    defaultInterpolatedStringHandler1.AppendFormatted($"{string1}, ");
    defaultInterpolatedStringHandler1.AppendLiteral("you are ");
    defaultInterpolatedStringHandler1.AppendFormatted($"{int1} ");
    defaultInterpolatedStringHandler1.AppendLiteral("years old.");

    string string2 = defaultInterpolatedStringHandler1.ToStringAndClear();

    Console.WriteLine($"{string2}");

    Console.WriteLine();
}

static void VerbatimStrings()
{
    Console.WriteLine("Verbatim Strings:");

    // The following string is printed verbatim, thus all escape characters are displayed.
    Console.WriteLine(@"C:\MyApp\bin\Debug");

    // Whitespace is preserved with verbatim strings.
    string string1 = @"This is a very
            very
                very
                    long string.";
    Console.WriteLine($"{string1}");

    // Using verbatim strings, you can directly insert a double quote into a string literal by doubling the " token.
    Console.WriteLine(@"Cerebus said: ""Darrr! Pret-ty sun-sets.""");

    // Verbatim strings can also be interpolated strings by specifying both the interpolation operator ($) and the verbatim operator (@).
    string string2 = "interpolation";
    string string3 = $@"This is a very
            very
                very
                    long string with {string2}.";
    Console.WriteLine($"{string3}");

    Console.WriteLine();
}

static void StringEquality()
{
    Console.WriteLine("String Equality:");

    string string1 = "Hello!";
    string string2 = "HELLO!";
    Console.WriteLine($"string1: {string1}");
    Console.WriteLine($"string2: {string2}");

    // Even though the string data type is a reference type, the equality operators have been redefined to compare the value of string objects and not the object in memory to which they refer.
    Console.WriteLine($"string1 == string2: {string1 == string2}.");
    Console.WriteLine($"string1 == Hello!: {string1 == "Hello!"}.");
    Console.WriteLine($"string2 == HELLO!: {string2 == "HELLO!"}");
    Console.WriteLine($"string1 == hello!: {string1 == "hello!"}");
    Console.WriteLine($"string1.Equals(string2): {string1.Equals(string2)}.");
    Console.WriteLine($"Hey!.Equals(string2): {"Hey".Equals(string2)}.");

    Console.WriteLine();
}

static void StringEqualityWithStringComparison()
{
    Console.WriteLine("String Equality with the StringComparison class:");

    string string1 = "Hello!";
    string string2 = "HELLO!";
    Console.WriteLine($"string1: {string1}");
    Console.WriteLine($"string2: {string2}");

    Console.WriteLine($"Default rules: string1.Equals(string2): {string1.Equals(string2)}.");
    Console.WriteLine($"Ignore case: string1.Equals(string2, StringComparison.OrdinalIgnoreCase): {string1.Equals(string2, StringComparison.OrdinalIgnoreCase)}.");
    Console.WriteLine($"Ignore case, invariant culture: string1.Equals(string2, StringComparison.InvariantCultureIgnoreCase): {string1.Equals(string2, StringComparison.InvariantCultureIgnoreCase)}.");

    Console.WriteLine($"Default rules: string1.IndexOf(\"E\"): {string1.IndexOf("E")}.");
    Console.WriteLine($"Ignore case: string1.IndexOf(\"E\", StringComparison.OrdinalIgnoreCase): {string1.IndexOf("E", StringComparison.OrdinalIgnoreCase)}.");
    Console.WriteLine($"Ignore case, invariant culture: string1.IndexOf(\"E\", StringComparison.InvariantCultureIgnoreCase): {string1.IndexOf("E", StringComparison.InvariantCultureIgnoreCase)}.");

    Console.WriteLine();
}

static void StringsAreImmutable()
{
    Console.WriteLine("Strings Are Immutable:");

    string string1 = "This is my string.";
    Console.WriteLine($"string1 = {string1}");

    // Will string1 be in uppercase?
    string string2 = string1.ToUpper();
    Console.WriteLine($"string2 = {string2}");

    // No, string1 remains in the same format.
    Console.WriteLine($"string1 = {string1}");

    string string3 = "My other string.";
    // The compiler loads a new string object on the managed heap. The previous string object that contained the value "My other string." will eventually be garbage collected.
    string3 = "New string value.";
    Console.WriteLine($"{string3}");

    Console.WriteLine();
}

static void StringsWithStringBuilder()
{
    Console.WriteLine("Creating Strings with the StringBuilder class:");

    // Create a StringBuilder object with an initial size of 256.
    StringBuilder stringBuilder1 = new("Fantastic Games", 256);

    // The StringBuilder class directly modifies the object's internal character data instead of obtaining a copy of the data in a modified format, making it more efficient.
    stringBuilder1.Append("\n");
    stringBuilder1.AppendLine("Half-Life");
    stringBuilder1.AppendLine("Morrowind");
    stringBuilder1.AppendLine("Deus Ex " + "2");
    stringBuilder1.AppendLine("System Shock");

    Console.WriteLine($"{stringBuilder1}");

    stringBuilder1.Replace("2", "Invisible War");

    Console.WriteLine($"{stringBuilder1}");
    Console.WriteLine($"stringBuilder1 has {stringBuilder1.Length} characters.");
}
