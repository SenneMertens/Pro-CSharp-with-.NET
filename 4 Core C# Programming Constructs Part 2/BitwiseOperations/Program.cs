using BitwiseOperations;

Console.WriteLine("** Bitwise Operations **");
Console.WriteLine();

// The & (AND) operator copies a bit if it exists in both operands.
Console.WriteLine($"0110 & 0100 = {0110 & 0100}.");
// The | (OR) operator copies a bit if it exists in either operands.
Console.WriteLine($"0110 | 0100 = {0110 | 0100}.");
// The ^ (XOR) operator copies a bit if ot exists in 1 but not both operands.
Console.WriteLine($"0110 ^ 0100 = {0110 ^ 01000}.");
// The ~ (ones' compliment) operator flips the bits.
Console.WriteLine($"~0110 = {~0110}.");
// The << (left shift) operator shifts the bits left.
Console.WriteLine($"0110 << 1 = {0110 << 1}.");
// The >> (right shift) operator shifts the bits right.
Console.WriteLine($"0110 >> 1 = {0110 >> 1}.");

Console.WriteLine();

// Because the ContactPreferenceEnum enumeration is marked with a Flags attributen, you can combine multiple values into a single variable.
ContactPreferenceEnum contactPreferenceEnum1 = ContactPreferenceEnum.Email | ContactPreferenceEnum.Phone;

Console.WriteLine($"None: {(contactPreferenceEnum1 | ContactPreferenceEnum.None) == contactPreferenceEnum1}.");
Console.WriteLine($"Email: {(contactPreferenceEnum1 | ContactPreferenceEnum.Email) == contactPreferenceEnum1}.");
Console.WriteLine($"Phone: {(contactPreferenceEnum1 | ContactPreferenceEnum.Phone) == contactPreferenceEnum1}.");
Console.WriteLine($"Text: {(contactPreferenceEnum1 | ContactPreferenceEnum.Text) == contactPreferenceEnum1}.");
