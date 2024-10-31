using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading;
public class AddOperations
{
    // When you define a set of identically named methods that differ by the number or type of parameters, the method in question is said to be overloaded.
    // The key is to ensure that each version of the method has a unique set of arguments. Methods differing only by return type aren't unique enough.

    public static int Add(int int1, int int2)
    {
        return int1 + int2;
    }

    // If the optional argument isn't passed in by the caller, the compiler will match the method without the optional parameter.
    public static int Add(int int1, int int2, int int3 = 0)
    {
        return int1 + (int2 * int3);
    }

    public static double Add(double double1, double double2)
    {
        return double1 + double2;
    }

    public static long Add(long long1, long long2)
    {
        return long1 + long2;
    }

    // Error! The in, ref, and out modifier aren't considered a part of the signature for method overloading when more than 1 method uses a modifier.
    // static int Add(ref int int1)
    // {
    //     
    // }
    //
    // static int Add(out int int1)
    // {
    //     
    // }
    //
    // However, if only 1 method uses an in, ref, or out modifier, the compiler can distinguish between the signature.
    // static int Add(ref int int1)
    // {
    //     
    // }
    //
    // static int Add(int int1)
    // {
    //     
    // }
}
