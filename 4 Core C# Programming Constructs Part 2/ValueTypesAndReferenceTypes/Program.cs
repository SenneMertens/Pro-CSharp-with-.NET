Console.WriteLine("** Value Types and Reference Types **");
Console.WriteLine();

// The role of System.ValueType is to ensure that the derived type is allocated on the stack, rather than the garbage-collected heap. Data allocated on the stack can be created and destroyed quickly, as its lifetime is determined by the defining scope. Heap-allocated data, however, is monitored by the .NET garbage collector and has a lifetime that's determined by many factors.

// Given that value types are using value-based semantics, the lifetime of a structure (which includes all numerical data types as well as enumerations and structures) is predictable. When a value type variable falls out of the defining scope, it's removed from memory immediately.
// static void LocalValueTypes()
// {
//     Recall that int is really a System.Int32 structure.
//     int int1 = 0;
//
//     Recall that Point is a structure type.
//     Point point1 = new Point();
// } int1 and point1 are popped off the stack here.

ValueTypeAssignment();
ReferenceTypeAssignment();
ValueTypeContainingReferenceType();

static void ValueTypeAssignment()
{
    Console.WriteLine("Value Type Assigment:");

    // Assigning 2 intrinsic value types results in 2 independent variables on the stack.
    // When you assign one value type to another, a member-by-member copy of the field data is achieved.
    PointStructure pointStructure1 = new(10, 10);
    PointStructure pointStructure2 = pointStructure1;

    pointStructure1.Display();
    pointStructure2.Display();

    // Changes in pointStructure1 don't affect pointStructure2.
    pointStructure1.X = 100;

    Console.WriteLine("Changed the value of pointStructure1.X:");

    pointStructure1.Display();
    pointStructure2.Display();

    Console.WriteLine();
}

static void ReferenceTypeAssignment()
{
    Console.WriteLine("Reference Type Assignment:");

    // In contract to value types, when you apply the assignment operator to reference types (meaning all class instances), you're redirecting what the reference variable points to in memory.
    PointClass pointClass1 = new(10, 10);
    PointClass pointClass2 = pointClass1;

    pointClass1.Display();
    pointClass2.Display();

    // Changes in pointClass1 do affect pointClass2.
    pointClass1.X = 100;

    Console.WriteLine("Changed the value of pointClass1.X:");

    pointClass1.Display();
    pointClass2.Display();

    Console.WriteLine();
}

static void ValueTypeContainingReferenceType()
{
    Console.WriteLine("Value Type Containing a Reference Type:");

    Rectangle rectangle1 = new("1st Rectangle", 10, 10);
    // By default, when a value type contains other reference types, assignment results in a copy of its references.
    Rectangle rectangle2 = rectangle1;

    // Changing the value of the (reference type) info string using the rectangle2 reference, the rectangle1 reference displays the same value. In this way, you have 2 independent structures, each of which contains a reference pointing to the same 
    rectangle2.ShapeInfo.InfoString = "2nd Rectangle";
    rectangle2.X = 100;

    Console.WriteLine("Changed the values of rectangle2.ShapeInfo.InfoString and rectangle2.X:");

    rectangle1.Display();
    rectangle2.Display();
}

struct PointStructure
{
    public int X;
    public int Y;

    public PointStructure(int xPosition, int yPosition)
    {
        X = xPosition;
        Y = yPosition;
    }

    public void Decrement()
    {
        X--;
        Y--;
    }

    public void Increment()
    {
        X++;
        Y++;
    }

    public void Display()
    {
        Console.WriteLine($"X: {X}. Y: {Y}.");
    }
}

class PointClass
{
    public int X;
    public int Y;

    public PointClass(int xPosition, int yPosition)
    {
        X = xPosition;
        Y = yPosition;
    }

    public void Decrement()
    {
        X--;
        Y--;
    }

    public void Increment()
    {
        X++;
        Y++;
    }

    public void Display()
    {
        Console.WriteLine($"X: {X}. Y: {Y}.");
    }
}

class ShapeInfo
{
    public string InfoString;

    public ShapeInfo(string infoString)
    {
        InfoString = infoString;
    }
}

struct Rectangle
{
    // The Rectangle structure contains a reference type member.
    public ShapeInfo ShapeInfo;
    public int X;
    public int Y;

    public Rectangle(string infoString, int xPosition, int yPosition)
    {
        ShapeInfo = new ShapeInfo(infoString);
        X = xPosition;
        Y = yPosition;
    }

    public void Display()
    {
        Console.WriteLine($"Info string: {ShapeInfo.InfoString}. X: {X}. Y: {Y}.");
    }
}
