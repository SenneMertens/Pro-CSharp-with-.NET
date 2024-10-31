using System.Xml.Linq;

Console.WriteLine("** Structures **");
Console.WriteLine();

// You can think of a structure as a lightweight class type, given that structures provide a way to define a type that supports encapsulation but can't be used to build a family of related types. Structures can't inherit from other class or structure types and can't be used as the base of a class. Structures, however, can implement interfaces.

// Here you simply create a Point variable and assign each piece of public field data before invoking its members. If you don't assign each piece of public field data before using the structure, you'll receive a compiler error.
Point point1;
point1.X = 349;
point1.Y = 76;

point1.Display();

point1.Increment();
point1.Decrement();

point1.Display();

// Using the C# new keyword, you'll invoke the structure's default constructor. A default constructor doesn't take any arguments. The benefit of invoking a default constructor is that each piece of field data is automatically set to its default value.
Point point2 = new();

// Because we used a default constructor, the values of the X and Y fields will be set to its default value of 0.
point2.Display();

// Call the custom constructor.
Point point3 = new(50, 60);

point3.Display();

Console.WriteLine();

Console.WriteLine("Read-Only Structure:");

ReadOnlyPoint readOnlyPoint1 = new(50, 60);

// Error! Because the stucture is read-only, you can no longer modify any fields.
// readOnlyPoint1.X = 40;

readOnlyPoint1.Display();

Console.WriteLine();

Console.WriteLine("Structure with Read-Only Members:");

PointWithReadOnlyMembers pointWithReadOnlyMembers1 = new(50, 60, "Point with Read-Only");

// Because the individual members are marked as read-only instead of the entire structure, it's still possible to modify certain fields.
pointWithReadOnlyMembers1.X = 70;
// pointWithReadOnlyMembers1.Y = 90:

pointWithReadOnlyMembers1.Display();

Console.WriteLine();

Console.WriteLine("Disposable Reference Structures:");

DisposableReferenceStructure disposableReferenceStructure1 = new(50, 60);

disposableReferenceStructure1.Display();
disposableReferenceStructure1.Dispose();

// Structure types are well suited for modeling mathematical, geometrical, and other atomic entities.
struct Point
{
    // Structure fields can be initiaized when declared.
    public int X = 5;
    public int Y = 7;

    // Because we initialzed the fields, the parameterless (default) constructor is no longer needed.
    // public Point()
    // {
    //     X = 0;
    //     Y = 0;
    // }

    // A custom constructor allows you to specify the vaues of field data upon variable creation, rather than having to set each data member field by field.
    public Point(int xPosition, int yPosition)
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

// Structures can be marked as read-only if there's a need for them to be immutable.
readonly struct ReadOnlyPoint
{
    // When declaring a read-only structure, all the properties must also be read-only. So instead of setting them up as fields, they're created using read-onlu automatoc properties.
    public int X { get; }
    public int Y { get; }

    // The values of the properties of a read-only structure must be set during construction.
    public ReadOnlyPoint(int xPosition, int yPosition)
    {
        X = xPosition;
        Y = yPosition;
    }

    public void Display()
    {
        Console.WriteLine($"X: {X}. Y: {Y}.");
    }
}

struct PointWithReadOnlyMembers
{
    // You can also declare individual fields of a structure as read-only instead of making the entire structure read-only.
    // The readonly modifier can be applied to properties, methods, and property accessors.
    public int X;
    public readonly int Y;
    public readonly string Name;

    public PointWithReadOnlyMembers(int xPosition, int yPosition, string name)
    {
        X = xPosition;
        Y = yPosition;
        Name = name;
    }

    public readonly void Display()
    {
        Console.WriteLine($"X: {X}. Y: {Y}. Name: {Name}.");
    }
}

// The reference modifier can be used when defining a structure. This requires all instances of the structure to be stack allocated. Reference structures can't be assigned as a property of another class and can't implement any interfaces.
ref struct PointWithReferenceModifier
{
    public int X;
    public readonly int Y;
    public readonly string Name;

    public PointWithReferenceModifier(int xPosition, int yPosition, string name)
    {
        X = xPosition;
        Y = yPosition;
        Name = name;
    }

    public readonly void Display()
    {
        Console.WriteLine($"X: {X}. Y: {Y}. Name: {Name}.");
    }
}

// Error! This won't compile because the PointWithReferenceModifier property is a reference structure.
// struct PointWithReferenceStructureMember
// {
//     public PointWithReferenceModifier PointWithReferenceModifier { get; set; }
// }

// Reference structures can't implement any interfaces and therefore can't implement the IDiposable interface.
ref struct DisposableReferenceStructure
{
    public int X;
    public readonly int Y;

    public DisposableReferenceStructure(int xPosition, int yPosition)
    {
        X = xPosition;
        Y = yPosition;

        Console.WriteLine("Created.");
    }

    public readonly void Display()
    {
        Console.WriteLine($"X: {X}. Y: {Y}.");
    }

    // Add a public Dispose() method to make the reference structure disposable.
    public void Dispose()
    {
        // Clean up any resources here.

        Console.WriteLine("Disposed.");
    }
}
