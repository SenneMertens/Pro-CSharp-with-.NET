Console.WriteLine("** Reference Types with Value Type Parameters **");
Console.WriteLine();

Console.WriteLine("Passing a Reference Type by Value:");
// If a reference type is passed by value, the callee may change the values of the object's state data but not the object it's referencing.

Person person1 = new("Fred", 12);

Console.Write("Before the method call, person1 is: ");
person1.Display();

PassingReferenceTypeByValue(person1);

Console.Write("After the method call, person1 is: ");
person1.Display();

Console.WriteLine();

Console.WriteLine("Passing a Reference Type by Reference:");
// If a reference type is passed by reference, the callee may change the values of the object's state data as well as the object it's referencing.

Person person2 = new("Mel", 23);

Console.WriteLine("Before the method call with a reference modifier, person2 is:");
person2.Display();

PassingReferenceTypeByReference(ref person2);

Console.WriteLine("After the method call with a reference modifier, person2 is:");
person2.Display();

static void PassingReferenceTypeByValue(Person person)
{
    // A copy of the reference to the caller's object is copied into this method. Therefore, as this method is pointing to the same object as the caller, it's possible to alter the object's state data.
    person.Age = 99;
    // What's not possible is to reassign what the reference is pointing to.
    person = new("Nikki", 99);
}

static void PassingReferenceTypeByReference(ref Person person)
{
    // By adding a reference modifier you allow complete flexibility of how the callee is able to manipulate the incoming parameter.
    // Not only can the callee change the state of the object.
    person.Age = 50;

    // It may also reassign the reference to a new (Person) object.
    person = new("Nikki", 100);
}

class Person
{
    public string Name;
    public int Age;

    public Person()
    {

    }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}. Age: {Age}.");
    }
}
