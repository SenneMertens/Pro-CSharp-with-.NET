Console.WriteLine("Data Type Conversions:");
Console.WriteLine();

// The below code works because there is no possibility for loss of data, given that the maximum value of a short is well within the maximum range of an int, the compiler implicitly widens each short to and int.
// Widening is the term used to define an implicit upward cast that does not result in a loss of data.
// short short1 = 9;
// short short2 = 10;
// Console.WriteLine($"Add(short1, short2).");

short short1 = 30000;
short short2 = 30000;

// This produces a compiler error.
// short short3 = Add(short1, short2);

// Explicitly cast the int into a short (and allow loss of data).
short short3 = (short)Add(short1, short2);
Console.WriteLine($"{short1} + {short2} = {short3}.");
Console.WriteLine();

NarrowingConversion();
CheckedAndUncheckedKeywords();

static int Add(int number1, int number2)
{
    return number1 + number2;
}

static void NarrowingConversion()
{
    // Narrowing is the logical opposite of widening, in that a larger value is stored within a smaller data type variable.

    byte byte1 = 0;
    int int1 = 200;

    // Narrowing conversions result in a compiler error, even when you can reason that the narrowing conversion should succeed.
    // byte1 = int1;

    // To inform the compiler that you are willing to deal with a possible loss of data, you must apply an explicit cast.
    byte1 = (byte)int1;
    Console.WriteLine($"{byte1}.");

    Console.WriteLine();
}

static void CheckedAndUncheckedKeywords()
{
    byte byte1 = 100;
    byte byte2 = 250;

    try
    {
        // When you wrap a statement (or a block of statements) within the scope of the checked keyword, the compiler emits additional CIL instructions that test for possible overflow conditions.
        byte byte3 = checked((byte)Add(byte1, byte2));
        Console.WriteLine($"Sum: {byte3}.");
    }
    // If an overflow has occured, you will receive a the runtime exception System.OverflowException.
    catch (OverflowException overflowException)
    {
        Console.WriteLine($"{overflowException.Message}");
    }

    // Assuming project-wide overflow checking is enabled, the unchecked keyword will allow overflow/underflow without throwing a runtime exception.
    unchecked
    {
        byte byte3 = (byte)Add(byte1, byte2);
    }

    Console.WriteLine();
}
