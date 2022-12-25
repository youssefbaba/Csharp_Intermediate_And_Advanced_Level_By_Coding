namespace Inheritance_Part2;

internal class Parent
{
    // Fields
    public string FirstName;
    public string LastName;
    public float Wealth;

    // Constructors
    public Parent() // Parameter less constructor
    {
        Console.WriteLine("Parent Parameter less constructor is called");
    }
    public Parent(string firstName, string lastName, float wealth)  // Parameterized constructor
    {
        Console.WriteLine("Parent Parameterized constructor is called");
        FirstName = firstName;
        LastName = lastName;
        Wealth = wealth;
    }

    // Methods
    public void Test1() // Public method
    {
        Console.WriteLine("Method 1");
    }
    public void Test2() // Public Method
    {
        Console.WriteLine("Method 2");
    }

    void Test3() // Private method
    {
        Console.WriteLine("Method 3");
    }

    public virtual void Display()
    {
        Console.WriteLine($"Name = {FirstName ?? "null"} {LastName ?? "null"}");
        Console.WriteLine($"Wealth = {Wealth}");
    }
}
