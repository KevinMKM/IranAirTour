#region Generic Attributes

//Allows creating custom attributes with generic parameters
public class MyAttribute<T> : Attribute
{
    public T? Value { get; set; }
}

[MyAttribute<int>(Value = 42)]
public class MyClass
{
}

#endregion

#region Raw String Literals

// Supports multi-line strings without the need for escape sequences
// Raw string literals allow you to include special characters without needing to escape them. They are delimited by three double quotes.
public class Sample1
{
    public void Sample()
    {
        var rawString = """This is a "raw" string literal!""";
        Console.WriteLine(rawString);
    }
}

#endregion

#region UTF-8 String Literals

//Allows specifying strings in UTF-8 encoding directly
public class Sample2
{
    public string Utf8String = "\u00C3\u00A9"; // "é"
}

#endregion

#region Interpolated Verbatim Strings

//Combines interpolated strings with verbatim strings
public class Sample3
{
    public void Sample()
    {
        string name = "World";
        string message = $@"Hello, {name}!";
    }
}

#endregion

#region Generic Math Support

// C# 11 introduces several features to support generic math, including static virtual members in interfaces and checked user-defined operators.
public interface IAddable<T>
{
    static abstract T operator +(IAddable<T> a, T b);
}

#endregion

#region List Patterns

// List patterns allow you to match lists or arrays of elements
public class Sample5
{
    public void Sample()
    {
        int[] numbers = { 1, 2, 3 };

        var pattern1 = numbers is [1, 2, 3];
        var pattern2 = numbers is [1, 2];
        var pattern3 = numbers is [1, 2, _];
        var pattern4 = numbers is [1, 2, > 2];
        var pattern5 = numbers is [0 or 1, <= 2, > 3];
        Console.WriteLine($"[{string.Join(',', numbers)}] is [1, 2, 3]: {pattern1}"); // true
        Console.WriteLine($"[{string.Join(',', numbers)}] is [1, 2]: {pattern2}"); // false
        Console.WriteLine($"[{string.Join(',', numbers)}] is [1, 2, _]: {pattern3}"); // true
        Console.WriteLine($"[{string.Join(',', numbers)}] is [1, 2, >2]: {pattern4}"); // true
        Console.WriteLine($"[{string.Join(',', numbers)}] is [0 or 1, <= 2, > 3]: {pattern5}"); // false
    }
}

#endregion

#region File-Local Types

// You can now declare types that are local to a file, improving encapsulation
file class FileLocalClass
{
    // This class is only accessible within this file.
}

#endregion

#region Required Members

// You can now specify required members in your classes, ensuring they are initialized
public class Person
{
    public required string Name { get; init; }
}

#endregion

#region Auto-Default Structs

// Structs can now have default values automatically assigned
public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        // not require any more :
        X = x;
        Y = y;
    }
}

#endregion

#region Pattern Match Span<char> on a Constant String

// You can now pattern match Span<char> on a constant string
public class Sample7
{
    public void Sample()
    {
        var span = "hello".AsSpan();
        if (span is "hello")
        {
            Console.WriteLine("Matched!");
        }
    }
}

#endregion

#region Ref Fields and Scoped Ref

// You can now use ref fields and scoped ref for better memory management
public ref struct RefStruct
{
    public ref int Value;
}

#endregion

#region Improved Method Group Conversion to Delegate

// Method group conversions to delegates have been improved for better performance
public class Sample8
{
    public void Sample()
    {
        Func<int, int> add = Math.Abs;
        var result = add(-3);
    }
}

#endregion
