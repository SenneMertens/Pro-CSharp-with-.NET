Console.WriteLine("** Arrays **");
Console.WriteLine();

ArrayCreation();
ArrayInitializationSyntax();
ImplicitlyTypedLocalArrays();
ArrayOfObjects();
RectangularMultidimensionalArray();
JaggedMultidimensionalArray();
UsingArraysAsArgumentsAndReturnValues();
SystemArrayClassMembers();
IndicesAndRanges();

static void ArrayCreation()
{
    Console.WriteLine("Array Creation:");
    // An array is a set of data items, accessed using a numerical index.

    // The number used in the array declaration represents the total number of items, not the upper bound.
    // If you declare an array but don't explicitly fill each index, each item will be set to the default value of the data type.
    int[] intArray1 = new int[3];

    // The lower bound of an array always begins at 0.
    intArray1[0] = 100;
    intArray1[1] = 200;
    intArray1[2] = 300;

    foreach (int number in intArray1)
    {
        Console.WriteLine($"{number}.");
    }

    // Create a 100 item string array, indexed 0 - 99.
    string[] stringArray1 = new string[100];

    Console.WriteLine();
}

static void ArrayInitializationSyntax()
{
    Console.WriteLine("Array Initialization Syntax:");

    // Array initialization syntax using the new keyword.
    string[] stringArray1 = new string[] { "One", "Two", "Three" };

    Console.WriteLine($"stringArray1 has {stringArray1.Length} elements.");

    // Array initialization syntax without using the new keyword.
    bool[] boolArray1 = { false, false, true };

    Console.WriteLine($"boolArray1 has {boolArray1.Length} elements.");

    // Array initialization syntax with the new keyword and a size.
    int[] intArray1 = new int[4] { 0, 20, 22, 23 };

    Console.WriteLine($"intArray1 has {intArray1.Length} elements.");

    Console.WriteLine();
}

static void ImplicitlyTypedLocalArrays()
{
    Console.WriteLine("Implicitly Typed Local Arrays:");

    // You must use the new keyword when initializing an implicitly typed array.
    var array1 = new[] { 1, 10, 100, 100 };

    Console.WriteLine($"array1 is a {array1}.");

    var array2 = new[] { 1, 1.5, 2, 2.5 };

    Console.WriteLine($"array2 is a {array2}.");

    var array3 = new[] { "Hello", null, "World" };

    Console.WriteLine($"array3 is a {array3}.");

    // Error! All the items in the array's initialization list must be of the same underlying type. An implicitly typed local array doesn't default to System.Object.
    // var array4 = new[] { 1, "One", 2, "Two" };

    Console.WriteLine();
}

static void ArrayOfObjects()
{
    Console.WriteLine("Array of Objects:");

    object[] objectArray1 = new object[4];

    // An array of objects can be anything at all.
    objectArray1[0] = 10;
    objectArray1[1] = false;
    objectArray1[2] = new DateTime(1969, 3, 24);
    objectArray1[3] = "Form & Void";

    foreach (object item in objectArray1)
    {
        Console.WriteLine($"Value: {item}. Type: {item.GetType().Name}.");
    }

    Console.WriteLine();
}

static void RectangularMultidimensionalArray()
{
    Console.WriteLine("Rectangular Multidimensional Arrays:");
    // C# supports 2 varieties of multidimensional arrays. The 1st being a rectangular array, which is an array of multiple dimensions where each row has the same length.

    int[,] rectangularMultidimensionalArray1 = new int[3, 4];

    // Populate a 3 * 4 array.
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            rectangularMultidimensionalArray1[i, j] = i * j;
        }
    }

    // Print a 3 * 4 array.
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            Console.Write($"{rectangularMultidimensionalArray1[i, j]}\t");
        }

        Console.WriteLine();
    }

    Console.WriteLine();
}

static void JaggedMultidimensionalArray()
{
    Console.WriteLine("Jagged Multidimensional Arrays:");
    // The 2nd type of multidimensional array is termed a jagged array (an array of arrays). A jagged array contains a number of inner arrays, which may have a different upper limit.

    // Here we have an array of 5 different arrays.
    int[][] jaggedmultidimensionalArray1 = new int[5][];

    // Create the jagged array.
    for (int i = 0; i < jaggedmultidimensionalArray1.Length; i++)
    {
        jaggedmultidimensionalArray1[i] = new int[i + 7];
    }

    // Print each row. Remember that each element is defaulted to 0.
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < jaggedmultidimensionalArray1.Length; j++)
        {
            Console.Write($"{jaggedmultidimensionalArray1[i][j]} ");
        }

        Console.WriteLine();
    }

    Console.WriteLine();
}

static void UsingArraysAsArguments(int[] intArray1)
{
    for (int i = 0; i < intArray1.Length; i++)
    {
        Console.WriteLine($"Item {i} is {intArray1[i]}.");
    }
}

static string[] UsingArraysAsReturnValues()
{
    string[] stringArray1 = { "Array", "As", "A", "Return", "Value" };

    return stringArray1;
}

static void UsingArraysAsArgumentsAndReturnValues()
{
    Console.WriteLine("Using Arrays as Arguments and Return Values:");

    int[] intArray1 = { 0, 20, 22, 23 };

    // Pass an array as an argument.
    UsingArraysAsArguments(intArray1);

    // Receive an array as a return value.
    string[] stringArray1 = UsingArraysAsReturnValues();

    foreach (string item in stringArray1)
    {
        Console.WriteLine($"{item}");
    }

    Console.WriteLine();
}

static void SystemArrayClassMembers()
{
    Console.WriteLine("System.Array Class Members:");

    string[] stringArray1 = { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };

    // The Length property returns the number of items within the array.
    for (int i = 0; i < stringArray1.Length; i++)
    {
        Console.WriteLine($"{stringArray1[i]}.");
    }

    // The static Array.Reverse() metgod reverses the contents of a one-dimensional array.
    Array.Reverse(stringArray1);

    for (int i = 0; i < stringArray1.Length; i++)
    {
        Console.WriteLine($"{stringArray1[i]}.");
    }

    // The static Array.Clear() method sets a range of elements in the array to empty values (0 for numbers, null for object references, false for Booleans).
    Array.Clear(stringArray1, 1, 2);

    for (int i = 0; i < stringArray1.Length; i++)
    {
        Console.WriteLine($"{stringArray1[i]}.");
    }

    Console.WriteLine();
}

static void IndicesAndRanges()
{
    Console.WriteLine("Indices and Ranges:");
    // The System.Index type represents and index into a sequence.
    // The index from end operator (^) specifies that the index is relative to the end of the sequence.
    // The System.Range type represents a subrange of indices.
    // The range operator (..) specifies the start and end index and allows for access to a subsequence within a list.

    string[] stringArray1 = { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };

    for (int i = 0; i < stringArray1.Length; i++)
    {
        Index index1 = i;

        Console.WriteLine($"{stringArray1[index1]}.");
    }

    // Remember that the last item in a sequence is 1 less than the actual length, so ^0 would cause an error.
    for (int i = 1; i <= stringArray1.Length; i++)
    {
        // Print the array in reverse.
        Index index1 = ^i;

        Console.WriteLine($"{stringArray1[index1]}.");
    }

    // The start of the range is inclusive, and the end of the range is exclusive.
    foreach (string item in stringArray1[0..2])
    {
        // Retrieve the first 2 items in the list.
        Console.WriteLine($"{item}.");
    }

    // Ranges can also be passed to a sequence using the Range data type.
    Range range1 = 0..2;

    foreach (string item in stringArray1[range1])
    {
        Console.WriteLine($"{item}.");
    }

    // Ranges can be defined using integers or Index variables.
    Index index2 = 0;
    Index index3 = 2;

    Range range2 = index2..index3;

    foreach (string item in stringArray1[range2])
    {
        Console.WriteLine($"{item}.");
    }

    // If the beginning of the range is left off, the beginning of the sequence is used. If the end of the range is left off, the length of the range is used. This doesn't cause an error because the value at the end of the range is exclusive.
    Console.WriteLine($"stringArray1 has a length of {stringArray1[..].Length}.");
    // All 3 of these ranges represent the same subset.
    Console.WriteLine($"stringArray1 has a length of {stringArray1[0..^0].Length}.");
    Console.WriteLine($"stringArray1 has a length of {stringArray1[0..3].Length}.");

    // The ElementAt() extension method (in the System.Linq namespace) retrieves the element from the array at the specified location.
    Console.WriteLine($"{stringArray1.ElementAt(^2)}.");
}
