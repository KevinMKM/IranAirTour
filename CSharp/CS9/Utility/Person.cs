namespace CS9.Utility;
#region Record structures

// immutable record with positional parameters
public record Person(string FirstName, string LastName);

// immutable record with init only properties
public record Person_2
{
    public string FirstName { get; init; } = default;
    public string LastName { get; init; } = default;
};

// mutable record with init only properties
public record Person_3
{
    public string FirstName { get; set; } = default;
    public string LastName { get; set; } = default;
};

#endregion



public record Student(string Name, string Surname, int Grade)
    : Person(Name, Surname);
