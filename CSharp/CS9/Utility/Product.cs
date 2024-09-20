namespace CS9.Utility;

public class Product
{
    public Product()
    {

    }

    public Product(string name, string description)
    {
        Name = name;
        Description = description;
    }
    
    public string Name { get; set; }
    
    public string Description { get; set; }
}

public class Product_2
{
    public Product_2()
    {

    }
    
    public string Name { get; init; }
    
    public string Description { get; init; }
}

public static class TypePatterns
{
    public static bool IsLetter(this char c) =>
        c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';
    
    public static bool IsLetterOrSeparator(this char c) =>
        c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',';
}
