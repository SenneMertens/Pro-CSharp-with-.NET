Console.WriteLine("** Local Functions **");
Console.WriteLine();

// A local function is a function declared inside another function. It must be private, can be static and doesn't support overloading. Local functions do support nesting, meaning that a local function can have a local function declared inside it.

Console.WriteLine($"{Add(10, 10)}.");
Console.WriteLine($"{AddWrapper(10, 10)}.");
Console.WriteLine($"{AddWrapperWithSideEffect(10, 10)}.");
Console.WriteLine($"{AddWrapperWithStaticLocalFunction(10, 10)}.");

// Recall that static methods can be called directly without creating a class instance.
// static returnType MethodName(Parameter List)
// {
//     Implementation
// }
static int Add(int number1, int number2)
{
    return number1 + number2;
}

static int AddWrapper(int number1, int number2)
{
    return Add();

    int Add()
    {
        return number1 + number2;
    }
}

static int AddWrapperWithSideEffect(int number1, int number2)
{
    return Add();

    // The local Add() function is referencing the variables from the parent function directly.
    int Add()
    {
        number1 += 1;

        return number1 + number2;
    }
}

static int AddWrapperWithStaticLocalFunction(int number1, int number2)
{
    return Add(number1, number2);

    // Adding a static access modifier prevents a local function from accessing the variables of the parent method directly.
    static int Add(int number1, int number2)
    {
        return number1 + number2;
    }
}
