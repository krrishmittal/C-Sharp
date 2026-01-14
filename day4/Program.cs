// <summary>
// Day 4 - Object-Oriented Programming in C#
// 
// This program demonstrates advanced OOP concepts including:
// - Properties with get/set accessors
// - Constructors (default, parameterized, copy, static, private)
// - Destructors for resource cleanup
// - Exception handling (try, catch, finally, throw)
// - Custom exception classes
// - Abstract classes and methods
// - Polymorphism and inheritance
// </summary>

using System;

class Program
{
    // ===== EXAMPLE 1: Properties in C# =====
    // Properties allow reading, writing, or computing private field values
    // Uses get and set accessors to control access to private fields
    // Helps enforce encapsulation and data validation
    // 
    // class Program
    // {
    //     private int age;
    //     
    //     public int Get_Age
    //     {
    //         get { return age; }
    //     }
    //     
    //     public int Set_Age
    //     {
    //         set
    //         {
    //             if (value >= 0) { age = value; }
    //             else
    //             {
    //                 Console.WriteLine("Age cannot be negative");
    //             }
    //         }
    //     }
    // }
    // 
    // class C
    // {
    //     public static void Main()
    //     {
    //         Program p = new Program();
    //         p.Set_Age = -25;
    //         Console.WriteLine(p.Get_Age);
    //     }
    // }


    // ===== EXAMPLE 2: Auto-Implemented Properties =====
    // Simplified syntax for properties when no validation logic is needed
    // C# automatically creates a backing field
    // 
    // class Prog
    // {
    //     public string name { get; set; } = "Krrish";
    // }
    // 
    // class M
    // {
    //     public static void Main()
    //     {
    //         Prog p = new Prog();
    //         Console.WriteLine(p.name);
    //         p.name = "Mittal";
    //         Console.WriteLine(p.name);
    //     }
    // }


    // ===== EXAMPLE 3: Constructors in C# =====
    // Constructors are automatically called when an object is created
    // Has the same name as the class and no return type
    // Used to initialize object data members
    // 
    // class P
    // {
    //     public P()
    //     {
    //         Console.WriteLine("Constructor Called");
    //     }
    // }
    // 
    // class M
    // {
    //     public static void Main()
    //     {
    //         P obj = new P();
    //     }
    // }


    // ===== EXAMPLE 4: Parameterized Constructor =====
    // Constructor that accepts parameters for initialization
    // Allows customization during object creation
    // 
    // class Program
    // {
    //     int n;
    //     
    //     Program(int n)
    //     {
    //         this.n = n;
    //         Console.WriteLine(n);
    //     }
    //     
    //     public static void Main()
    //     {
    //         Program p = new Program(3);
    //     }
    // }


    // ===== EXAMPLE 5: Copy Constructor =====
    // Creates a new object by copying values from an existing object
    // Useful for creating duplicate objects with same initial values
    // 
    // class Program
    // {
    //     string month;
    //     int year;
    //     
    //     // Copy constructor
    //     Program(Program obj)
    //     {
    //         month = obj.month;
    //         year = obj.year;
    //     }
    //     
    //     // Parameterized constructor
    //     Program(string month, int year)
    //     {
    //         this.month = month;
    //         this.year = year;
    //     }
    //     
    //     public string details
    //     {
    //         get
    //         {
    //             return "month: " + month + " year: " + year.ToString();
    //         }
    //     }
    //     
    //     public static void Main()
    //     {
    //         Program p1 = new Program("January", 2004);
    //         Program p2 = new Program(p1);
    //         Console.WriteLine(p2.details);
    //     }
    // }


    // ===== EXAMPLE 6: Private Constructor =====
    // Prevents external instantiation of the class
    // Useful for classes with only static members
    // Used in singleton pattern implementations
    // 
    // class Prog
    // {
    //     private Prog()
    //     {
    //         Console.WriteLine("Private constructor");
    //     }
    //     
    //     public static int cnt;
    //     
    //     public static int inc()
    //     {
    //         return cnt++;
    //     }
    //     
    //     public static void Main()
    //     {
    //         Prog.cnt = 10;
    //         Console.WriteLine(Prog.cnt);
    //         Prog.inc();
    //         Console.WriteLine(Prog.cnt);
    //     }
    // }


    // ===== EXAMPLE 7: Destructors in C# =====
    // Automatically called when an object is destroyed
    // Used to release unmanaged resources (file handles, database connections)
    // Denoted by tilde (~) before class name
    // 
    // class P
    // {
    //     P()
    //     {
    //         Console.WriteLine("Constructor called");
    //     }
    //     
    //     ~P()
    //     {
    //         Console.WriteLine("Destructor called");
    //     }
    //     
    //     public static void Main()
    //     {
    //         P obj = new P();
    //     }
    // }


    // ===== EXAMPLE 8: Exception Handling Basics =====
    // Exception handling responds to runtime errors in a controlled way
    // try: Contains code that might throw an exception
    // catch: Handles exceptions thrown in the try block
    // finally: Always executes for cleanup tasks
    // throw: Manually raises an exception
    // 
    // class M
    // {
    //     public static void Main()
    //     {
    //         try
    //         {
    //             int res = 10 / 0;
    //             Console.WriteLine(res);
    //         }
    //         catch (DivideByZeroException e)
    //         {
    //             Console.WriteLine("Exception: " + e);
    //         }
    //     }
    // }


    // ===== EXAMPLE 9: Multiple Catch Blocks =====
    // Demonstrates handling different exception types
    // Multiple catch blocks for specific exception handling
    // General Exception catch block as fallback
    // 
    // class P
    // {
    //     public static void Main()
    //     {
    //         try
    //         {
    //             int[] arr = new int[6] { 1, 2, 3, 4, 5, 10 / 0 };
    //             Console.WriteLine(arr[5]);
    //         }
    //         catch (IndexOutOfRangeException e)
    //         {
    //             Console.WriteLine("Exception " + e);
    //         }
    //         catch (Exception e)
    //         {
    //             Console.WriteLine(e);
    //         }
    //         finally
    //         {
    //             Console.WriteLine("This always executes");
    //         }
    //     }
    // }


    // ===== EXAMPLE 10: Custom Exception Classes =====
    // Creating user-defined exceptions by inheriting from Exception class
    // Allows domain-specific error handling
    // 
    // class M
    // {
    //     class AgeOutOfBound : Exception
    //     {
    //         public AgeOutOfBound(String message) : base(message) { }
    //     }
    //     
    //     class P
    //     {
    //         public static void Main()
    //         {
    //             try
    //             {
    //                 int age = 10;
    //                 if (age < 18)
    //                 {
    //                     throw new AgeOutOfBound("Age is less than 18");
    //                 }
    //             }
    //             catch (AgeOutOfBound e)
    //             {
    //                 Console.WriteLine(e.Message);
    //             }
    //         }
    //     }
    // }


    // ===== EXAMPLE 11: Abstract Classes and Methods =====
    // Abstract classes cannot be directly instantiated
    // Abstract methods have no implementation, must be overridden in derived classes
    // Provides a blueprint for derived classes
    // 
    // public abstract class Animal
    // {
    //     public abstract string sound { get; }
    //     
    //     public virtual void Move()
    //     {
    //         Console.WriteLine("Animal is moving");
    //     }
    // }
    // 
    // public class Cat : Animal
    // {
    //     public override string sound => "Meow";
    //     
    //     public override void Move()
    //     {
    //         Console.WriteLine("Cat is moving");
    //     }
    // }
    // 
    // public class Dog : Animal
    // {
    //     public override string sound => "Woof";
    //     
    //     public override void Move()
    //     {
    //         Console.WriteLine("Dog is moving");
    //     }
    // }
    // 
    // class P
    // {
    //     public static void Main()
    //     {
    //         Animal a = new Dog();
    //         Animal b = new Cat();
    //         Console.WriteLine(a.sound);
    //         a.Move();
    //         Console.WriteLine(b.sound);
    //         b.Move();
    //     }
    // }


    // ===== EXAMPLE 12: Abstract Class Features =====
    // Key characteristics of abstract classes:
    // - Used with inheritance
    // - Derived classes must override abstract methods using 'override' keyword
    // - Can contain constructors and destructors
    // - Can implement non-abstract methods
    // - Cannot support multiple inheritance
    // - Cannot be static
    // 
    // public abstract class Base
    // {
    //     public abstract void display();
    // }
    // 
    // public class Child1 : Base
    // {
    //     public override void display()
    //     {
    //         Console.WriteLine("Child1");
    //     }
    // }
    // 
    // public class Child2 : Base
    // {
    //     public override void display()
    //     {
    //         Console.WriteLine("Child2");
    //     }
    // }
    // 
    // class M
    // {
    //     public static void Main()
    //     {
    //         Base b = new Child1();
    //         b.display();
    //         b = new Child2();
    //         b.display();
    //     }
    // }
}
