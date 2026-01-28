// <summary>
// Day 5 - Advanced OOP and Polymorphism in C#
// 
// This program demonstrates core OOP principles including:
// - Encapsulation and data hiding
// - Inheritance (single, multilevel, hierarchical)
// - Method overloading (compile-time polymorphism)
// - Method overriding (runtime polymorphism)
// - Abstract classes and methods
// - Interfaces and implementation
// - Lambda expressions
// </summary>

using System;

class Program
{
    // ===== EXAMPLE 1: Encapsulation in C# =====
    // Encapsulation binds data and methods into a single unit
    // Restricts direct access to components, ensuring controlled interaction
    // Hides internal representation and exposes only necessary operations
    // Improves data security, code maintainability, and flexibility
    // 
    // class Amount
    // {
    //     private double balance;
    //     
    //     public void deposit(int amt)
    //     {
    //         balance += amt;
    //         Console.WriteLine("Amount of " + amt + " deposit successfully");
    //     }
    //     
    //     public void withdraw(int amt)
    //     {
    //         if (balance >= amt)
    //         {
    //             balance -= amt;
    //             Console.WriteLine("Amount of " + amt + " withdrawn successful");
    //         }
    //         else
    //         {
    //             Console.WriteLine("Insufficient balance");
    //         }
    //     }
    //     
    //     public void getBalance()
    //     {
    //         Console.WriteLine("Balance: " + balance);
    //     }
    // }
    // 
    // class M
    // {
    //     public static void Main()
    //     {
    //         Amount a = new Amount();
    //         a.deposit(500);
    //         a.getBalance();
    //         a.withdraw(200);
    //         a.getBalance();
    //         a.withdraw(500);
    //     }
    // }


    // ===== EXAMPLE 2: Encapsulation Using Properties =====
    // Encapsulation with get and set accessors for controlled access
    // Validates data before setting private fields
    // 
    // class Person
    // {
    //     private string name = "";
    //     
    //     public string Name
    //     {
    //         get
    //         {
    //             return name;
    //         }
    //         set
    //         {
    //             if (!string.IsNullOrEmpty(value))
    //             {
    //                 name = value;
    //             }
    //         }
    //     }
    //     
    //     public static void Main()
    //     {
    //         Person p = new Person();
    //         p.Name = "krrish";
    //         Console.WriteLine(p.Name);
    //     }
    // }


    // ===== EXAMPLE 3: Inheritance Basics =====
    // Inheritance allows one class to derive properties and behaviors from another
    // Promotes code reusability, extensibility, and hierarchical relationships
    // Base Class: The class whose features are inherited (parent/super class)
    // Derived Class: The class that inherits (child/sub class)
    // 
    // class Animal
    // {
    //     public void eat()
    //     {
    //         Console.WriteLine("Animal is eating");
    //     }
    // }
    // 
    // class Dog : Animal
    // {
    //     public void sound()
    //     {
    //         Console.WriteLine("Dog is barking");
    //     }
    // }
    // 
    // class P
    // {
    //     public static void Main()
    //     {
    //         Dog d = new Dog();
    //         d.eat();   // Inherited method
    //         d.sound(); // Derived class method
    //     }
    // }


    // ===== EXAMPLE 4: Multilevel Inheritance =====
    // A class derives from another derived class, creating a chain
    // Each derived class can serve as a base for another class
    // All classes in C# implicitly inherit from System.Object
    // 
    // class Animal
    // {
    //     public void eat()
    //     {
    //         Console.WriteLine("Animal is eating");
    //     }
    // }
    // 
    // class Dog : Animal
    // {
    //     public void sound()
    //     {
    //         Console.WriteLine("Dog is barking");
    //     }
    // }
    // 
    // class Cat : Dog
    // {
    //     public void name()
    //     {
    //         Console.WriteLine("My name is cat");
    //     }
    // }
    // 
    // class P
    // {
    //     public static void Main()
    //     {
    //         Cat c = new Cat();
    //         c.eat();   // From Animal
    //         c.sound(); // From Dog
    //         c.name();  // From Cat
    //     }
    // }


    // ===== EXAMPLE 5: Method Overloading - Parameter Count =====
    // Method overloading: Multiple methods with same name, different parameters
    // Also known as compile-time (static) polymorphism
    // Parameter lists can differ by type, number, or order
    // Cannot overload by only changing return type
    // 
    // public int Add(int a, int b)
    // {
    //     int sum = a + b;
    //     return sum;
    // }
    // 
    // // Adding three integer values
    // public int Add(int a, int b, int c)
    // {
    //     int sum = a + b + c;
    //     return sum;
    // }


    // ===== EXAMPLE 6: Method Overloading - Parameter Types =====
    // Overloading by changing data types of parameters
    // Same method name, different parameter types
    // 
    // public static int Add(int a, int b, int c)
    // {
    //     int sum = a + b + c;
    //     return sum;
    // }
    // 
    // // Adding three double values
    // public static double Add(double a, double b, double c)
    // {
    //     double sum = a + b + c;
    //     return sum;
    // }


    // ===== EXAMPLE 7: Method Overloading - Parameter Order =====
    // Overloading by changing the order of parameters
    // Different parameter order creates distinct method signatures
    // 
    // public void Identity(String name, int id)
    // {
    //     Console.WriteLine("Name1 : " + name + ", " + "Id1 : " + id);
    // }
    // 
    // public void Identity(int id, String name)
    // {
    //     Console.WriteLine("Name2 : " + name + ", " + "Id2 : " + id);
    // }


    // ===== EXAMPLE 8: Method Overriding =====
    // Method overriding: Derived class provides new implementation
    // Key feature of runtime polymorphism
    // 'virtual' keyword in base class allows overriding
    // 'override' keyword in derived class provides new implementation
    // 
    // class Animal
    // {
    //     public virtual void Move()
    //     {
    //         Console.WriteLine("Animal is moving.");
    //     }
    //     
    //     public void Eat()
    //     {
    //         Console.WriteLine("Animal is eating.");
    //     }
    // }
    // 
    // class Dog : Animal
    // {
    //     // Overriding the Move method from the base class
    //     public override void Move()
    //     {
    //         Console.WriteLine("Dog is running.");
    //     }
    //     
    //     public void Bark()
    //     {
    //         Console.WriteLine("Dog is barking.");
    //     }
    // }
    // 
    // class P
    // {
    //     static void Main()
    //     {
    //         Dog d = new Dog();
    //         d.Move();
    //         d.Eat();
    //         d.Bark();
    //     }
    // }


    // ===== EXAMPLE 9: Abstract Classes =====
    // Abstract classes cannot be instantiated directly
    // Define a common template for related classes
    // Abstract methods have no implementation, must be overridden
    // Can contain properties, fields, and concrete methods
    // 
    // abstract class Shape
    // {
    //     // Abstract method - no implementation
    //     public abstract int area();
    // }
    // 
    // // Square class inheriting the Shape class
    // class Square : Shape
    // {
    //     // Private data member
    //     private int side;
    //     
    //     // Method of square class
    //     public Square(int x = 0)
    //     {
    //         side = x;
    //     }
    //     
    //     // Overriding the abstract method using override keyword
    //     public override int area()
    //     {
    //         Console.Write("Area of Square: ");
    //         return (side * side);
    //     }
    // }
    // 
    // class P
    // {
    //     static void Main(string[] args)
    //     {
    //         // Creating reference of Shape class
    //         // which refers to Square class instance
    //         Shape sh = new Square(4);
    //         // Calling the method
    //         double result = sh.area();
    //         Console.Write("{0}", result);
    //     }
    // }


    // ===== EXAMPLE 10: Interfaces =====
    // Interface is declared using 'interface' keyword
    // Can create abstract methods similar to abstract classes
    // Derived classes implement the functionality
    // All interface members are implicitly public
    // 
    // interface inter1
    // {
    //     // Method with only declaration, no definition
    //     void display();
    // }
    // 
    // // Implementing interface in P
    // class P : inter1
    // {
    //     // Providing the body of function
    //     public void display()
    //     {
    //         Console.WriteLine("Demonstration of interface");
    //     }
    //     
    //     public static void Main(String[] args)
    //     {
    //         P t = new P();
    //         t.display();
    //     }
    // }


    // ===== EXAMPLE 11: Lambda Expressions =====
    // Lambda expressions provide a concise way to represent anonymous methods
    // Uses => operator (lambda operator)
    // Useful for inline function definitions and LINQ queries
    // 
    // class Program
    // {
    //     static readonly Func<int, int, int> add = (a, b) => a + b;
    //     
    //     public static void Main()
    //     {
    //         int sum = add(1, 2);
    //         Console.WriteLine(sum);
    //     }
    // }
}
