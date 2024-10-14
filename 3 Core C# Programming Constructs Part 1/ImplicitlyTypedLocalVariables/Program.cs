Console.WriteLine("** Implicitly Typed Local Variables **");
Console.WriteLine();

DeclaringImplicitlyTypedVariables();
DeclaringImplicitlyTypedNumerics();
ImplicitlyTypedDataIsStronglyTypedData();
LINQWithIntegers();

static void DeclaringImplicitlyTypedVariables()
{
    Console.WriteLine("Declaring Implicitly Typed Local Variables:");

    // Implicitly typed local variables are declared as follows: var variableName = initialValue.
    var int1 = 0;
    var bool1 = true;
    var string1 = "Time, marches on.";

    Console.WriteLine($"int1 is an {int1.GetType().Name}.");
    Console.WriteLine($"bool1 is a {bool1.GetType().Name}.");
    Console.WriteLine($"string1 is a {string1.GetType().Name}.");

    Console.WriteLine();
}

static void DeclaringImplicitlyTypedNumerics()
{
    Console.WriteLine("Declaring Implicitly Typed Local Numerics:");

    // Whole numbers default to integers, while floating-point numbers default to doubles.
    var int1 = 0;
    var uInt1 = 0u;
    var long1 = 0L;
    var double1 = 0.5;
    var float1 = 0.5F;
    var decimal1 = 0.5M;

    Console.WriteLine($"int1 is an {int1.GetType().Name}.");
    Console.WriteLine($"uInt1 is an {uInt1.GetType().Name}.");
    Console.WriteLine($"long1 is a {long1.GetType().Name}.");
    Console.WriteLine($"double1 is a {double1.GetType().Name}.");
    Console.WriteLine($"float1 is a {float1.GetType().Name}.");
    Console.WriteLine($"decimal1 is a {decimal1.GetType().Name}.");

    Console.WriteLine();
}

static void ImplicitlyTypedDataIsStronglyTypedData()
{
    // The compiler knows string1 is a System.String.
    var string1 = "This variable can only hold string data.";
    string1 = "This will assign correctly";

    // You can invoke any member of the underlying type.
    string string2 = string1.ToUpper();

    // Error! You can't assign numerical data to a string.
    // string1 = 44;
}

static void LINQWithIntegers()
{
    Console.WriteLine("LINQ with Integers:");

    int[] intArray1 = { 10, 20, 30, 40, 1, 2, 3, 4 };

    var subset1 = from number in intArray1 where number < 10 select number;

    Console.Write("Values in subset1: ");
    foreach (var number in subset1)
    {
        Console.Write($"{number} ");
    }
    Console.WriteLine();

    Console.WriteLine($"subset1 is a {subset1.GetType().Name}.");
    Console.WriteLine($"subset1 is defined in the {subset1.GetType().Namespace} namespace.");
}

// class ImplicitlyTypedVariableRestrictions
// {
//     Error! var can't be used as field data.
//     private var int1 = 10;
//
//     Error! var can't be used as a return value or as a parameter type.
//     public var MyMethod(var number1, var number2)
//     {
//
//     }
//
//     Error! You must assign a value at the exact time of declaration.
//     var int1;
//     int1 = 0;
//
//     Error! You can't assign null as the initial value.
//     var int1 = null;
//
//     It's allowed to assign an inferred local variable to null after its initial assignment, provided it's a reference type.
//     var sportsCar1 = new SportsCar();
//     sportsCar1 = null;
//
//     It's allowed to assign the value of an implicitly typed local variable to the value of other variables, implicitly typed or not.
//     var int1 = 0;
//     var int2 = int1;
//
//     It's allowed to return to an implicitly typed local variable to the caller, provided the method return type is the same underlying type as the var-defined data point.
//     static int MyMethod()
//     {
//         var int1 = 0;
//         return int1;
//     }    
// }
