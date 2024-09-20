using CS9.Utility;

// ReSharper disable All

namespace CS9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region #1: Target-Typed Object Creation

            Product oldProduct = new Product();

            Product newProduct = new();

            Product newProduct2 = new("IPhone 13 Pro Max", "Apple");

            #endregion

            #region #2: Init-Only Setters in Properties

            //Whilst we are on the subject of initialisation, we can now set a property setter as "init".
            // What that means is that we can only set the property when an instance of the type is created

            Product_2 myProduct = new Product_2 { Name = "IPhone 13 Pro Max", Description = "Apple" };

            //myProduct.Name = "My Product 2"; // This would throw an error

            #endregion

            #region #3: Record types

            //Description in Person File

            #endregion

            #region #4: Patterns Type

            var isLetterResult = TypePatterns.IsLetter('A');

            var isLetterOrSeparator = TypePatterns.IsLetterOrSeparator('4');

            #endregion

            #region #5: With-expressions

            Person firstPerson = new("Aref", "Kanaanpour");

            var otherPerson = firstPerson with { LastName = "Kanaanpoor" };

            #endregion

            #region #6: Top-level programs

            // using System;
            // class Program
            // {
            //     static void Main()
            //     {
            //         Console.WriteLine("Hello World!");
            //     }
            // }
            
            
            // using System;
            //
            // Console.WriteLine("Hello World!");

            #endregion
            
            #region #7: Value equality
            
            // As we know, structures do not have overridden comparison operators.
            // When comparing class instances, we do not compare data inside objects, but references to them.
            // Now let's take a look at how this happens for records
            
            var first = new Person("Hermit", "Purple");
            
            var second = new Person("Hermit", "Purple");
            
            Console.WriteLine(first == second);
            //True
            
            Console.WriteLine(ReferenceEquals(first, second));
            //False
            
            #endregion

            #region #7: Static lambda expressions and anonymous functions

            const double RequiredScore = 3;
            var students = new List<Student>() 
            { 
                new Student("Hermit", "Purple", Grade: 2),
                new Student("Hierophant", "Green", Grade: 3),
                new Student("Silver", "Chariot", Grade: 4)
            };

            var highScoreStudents =
                students.Where(static x => x.Grade > RequiredScore);

            #endregion
            
            #region #:The End

            // C# 9 adds many other small features that improve developer productivity, both writing and reading code:
            //
            // Improved ToString method
            // Target-type new expressions
            // static anonymous functions
            // Extension GetEnumerator() support for foreach loops
            // Lambda expressions can declare discard parameters
            // Attributes can be applied to local functions

            #endregion

            

            Console.WriteLine("The End");
            Console.ReadKey();
        }
    }
}