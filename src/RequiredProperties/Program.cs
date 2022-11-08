var person = new Person { FirstName = "Tracy", LastName = "Smith" };

[Person(FirstName = "Tracy", LastName = "Smith")]

public class Person : Attribute
{
    required public string FirstName { get; init; }
    public string? MiddleName { get; init; }
    required public string LastName { get; init; }
}
