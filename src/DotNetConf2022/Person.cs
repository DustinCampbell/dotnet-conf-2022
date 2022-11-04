public class Person
{
    public string FirstName { get; init; }
    public string? MiddleName { get; init; }
    public string LastName { get; init; }
    public Person(string firstName, string? middleName, string lastName)
    {
        (FirstName, MiddleName, LastName) = (firstName, middleName, lastName);
    }
    public Person(string firstName, string lastName)
    {
        (FirstName, LastName) = (firstName, lastName);
    }
}