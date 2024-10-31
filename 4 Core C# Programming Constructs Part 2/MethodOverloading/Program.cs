using static MethodOverloading.AddOperations;

Console.WriteLine("** Method Overloading **");
Console.WriteLine();

// This calls the integer version of the Add() method.
Console.WriteLine($"{Add(10, 10)}.");

// This calls the long version of the Add() method.
Console.WriteLine($"{Add(900_000_000_000, 900_000_000_000)}.");

// This calls the double version of the Add() method.
Console.WriteLine($"{Add(4.3, 4.4)}.");
