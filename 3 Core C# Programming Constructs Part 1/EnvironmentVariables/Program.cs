Console.WriteLine("** Environment Variables **");
Console.WriteLine();

// Process any incoming arguments.
for (int i = 0; i < args.Length; i++)
{
    Console.WriteLine($"Argument: {args[i]}.");
}

// Process any incoming arguments using a foreach loop.
foreach (string argument in args)
{
    Console.WriteLine($"Argument: {argument}.");
}

// Get the arguments using the GetCommandLineArgs() method from System.Environment.
string[] argumentsArray1 = Environment.GetCommandLineArgs();

foreach (string argument in argumentsArray1)
{
    Console.WriteLine($"Argument: {argument}.");
}

// A local method within the top-level statements.
EnvironmentDetails();

static void EnvironmentDetails()
{
    foreach (string drive in Environment.GetLogicalDrives())
    {
        Console.WriteLine($"Drive: {drive}.");
    }

    Console.WriteLine($"Operating System: {Environment.OSVersion}.");
    Console.WriteLine($"Number of processors: {Environment.ProcessorCount}.");
    Console.WriteLine($".NET version: {Environment.Version}.");
}
