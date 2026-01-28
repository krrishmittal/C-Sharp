// <summary>
// Day 9 - Generics in C#
// This program demonstrates generic programming including:
// - Generic methods for type-safe reusable code
// - Generic classes for type-parameterized containers
// - Generic interfaces for flexible contracts
// - Generic constraints (where clause)
// - Multiple type parameters
// - Generic delegates
// - Covariance and Contravariance
// - Default keyword with generics
// </summary>

using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        // ===== EXAMPLE 1: Why Generics? - The Problem =====
        // Without generics, we'd use object type (boxing/unboxing)
        // This causes performance issues and no type safety
        // Generics provide type safety at compile time
        // 
        // // Without generics - NOT recommended
        // ArrayList list = new ArrayList();  // Requires: using System.Collections;
        // list.Add(1);        // Boxing: int to object
        // list.Add("hello");  // Can add any type - no type safety!
        // // list.Add(2);
        // // list.Add(3); 
        // // list.Add(4); 
        // // list.Add(5); 
        // // // int num = list[0];  // Unboxing: object to int
        // foreach(var x in list)
        // {
        //     Console.WriteLine(x);
        // }
        // // With generics - RECOMMENDED
        // List<int> numbers = new List<int>();
        // numbers.Add(1);
        // // numbers.Add("hello");  // Compile error! Type safety
        // int num = numbers[0];     // No casting needed


        // ===== EXAMPLE 2: Basic Generic Method =====
        // Generic methods work with any type T
        // Type parameter <T> is specified after method name
        // Compiler infers type from arguments
        // 
        // static void Swap<T>(ref T a, ref T b)
        // {
        //     T temp = a;
        //     a = b;
        //     b = temp;
        // }
        
        // 
        // // Usage:
        // int x = 10, y = 20;
        // Swap<int>(ref x, ref y);  // Explicit type
        // Console.WriteLine($"x = {x}, y = {y}");  // x = 20, y = 10
        // 
        // string s1 = "Hello", s2 = "World";
        // Swap(ref s1, ref s2);  // Type inference
        // Console.WriteLine($"s1 = {s1}, s2 = {s2}");  // s1 = World, s2 = Hello


        // ===== EXAMPLE 3: Generic Method with Return Type =====
        // Generic methods can return generic types
        // Useful for creating utility functions
        // 
        // static T GetMax<T>(T a, T b) where T : IComparable<T>
        // {
        //     return a.CompareTo(b) > 0 ? a : b;
        // }
        // 
        // // Usage:
        // int maxInt = GetMax(10, 20);
        // Console.WriteLine($"Max int: {maxInt}");  // 20
        // 
        // string maxStr = GetMax("apple", "banana");
        // Console.WriteLine($"Max string: {maxStr}");  // banana
        // 
        // double maxDouble = GetMax(3.14, 2.71);
        // Console.WriteLine($"Max double: {maxDouble}");  // 3.14


        // ===== EXAMPLE 4: Basic Generic Class =====
        // Generic classes are type-parameterized
        // Create once, use with any type
        // Common naming: T for Type, TKey, TValue, TResult
        // 
        // class Box<T>
        // {
        //     private T _value;
        //     
        //     public void Store(T value)
        //     {
        //         _value = value;
        //     }
        //     
        //     public T Retrieve()
        //     {
        //         return _value;
        //     }
        // }
        // 
        // // Usage:
        // Box<int> intBox = new Box<int>();
        // intBox.Store(42);
        // Console.WriteLine(intBox.Retrieve());  // 42
        // 
        // Box<string> stringBox = new Box<string>();
        // stringBox.Store("Hello Generics!");
        // Console.WriteLine(stringBox.Retrieve());  // Hello Generics!
        

        // ===== EXAMPLE 5: Generic Class with Multiple Type Parameters =====
        // Classes can have multiple type parameters
        // Useful for key-value pairs, tuples, etc.
        // 
        // class Pair<TFirst, TSecond>
        // {
        //     public TFirst First { get; set; }
        //     public TSecond Second { get; set; }
        //     
        //     public Pair(TFirst first, TSecond second)
        //     {
        //         First = first;
        //         Second = second;
        //     }
        //     
        //     public void Display()
        //     {
        //         Console.WriteLine($"First: {First}, Second: {Second}");
        //     }
        // }
        // 
        // // Usage:
        // Pair<int, string> student = new Pair<int, string>(101, "John");
        // student.Display();  // First: 101, Second: John
        // 
        // Pair<string, double> product = new Pair<string, double>("Laptop", 999.99);
        // product.Display();  // First: Laptop, Second: 999.99


        // ===== EXAMPLE 6: Generic Constraints - where T : struct =====
        // Constrains T to be a value type (int, double, struct, etc.)
        // Cannot use reference types like string, class
        // 
        // class Calculator<T> where T : struct
        // {
        //     public T Value { get; set; }
        //     
        //     public bool IsDefault()
        //     {
        //         return Value.Equals(default(T));
        //     }
        // }
        // 
        // // Usage:
        // Calculator<int> calc = new Calculator<int>();
        // calc.Value = 0;
        // Console.WriteLine(calc.IsDefault());  // True
        // 
        // Calculator<double> calcDouble = new Calculator<double>();
        // calcDouble.Value = 3.14;
        // Console.WriteLine(calcDouble.IsDefault());  // False
        // 
        // // Calculator<string> calcString;  // Error! string is reference type

        // ===== RUNNABLE DEMO =====
        // Uncomment the examples above one at a time to test them
        // Here's a simple demo you can run:
        
        // Console.WriteLine("===== Day 9: Generics Demo =====\n");
        
        // // Demo: Generic Swap Method
        // int a = 10, b = 20;
        // Console.WriteLine($"Before swap: a = {a}, b = {b}");
        // Swap(ref a, ref b);
        // Console.WriteLine($"After swap: a = {a}, b = {b}\n");
        
        // // Demo: Generic Box Class
        // Box<string> messageBox = new Box<string>();
        // messageBox.Store("Hello, Generics!");
        // Console.WriteLine($"Box contains: {messageBox.Retrieve()}\n");
        
        // // Demo: Generic Pair Class
        // Pair<int, string> student = new Pair<int, string>(101, "John Doe");
        // Console.WriteLine($"Student ID: {student.First}, Name: {student.Second}\n");
        
        // // Demo: Using default keyword
        // Console.WriteLine($"Default int: {GetDefault<int>()}");
        // Console.WriteLine($"Default bool: {GetDefault<bool>()}");
        // Console.WriteLine($"Default string: {GetDefault<string>() ?? "null"}\n");
        
        // // Demo: Generic with constraint
        // int maxValue = GetMax(100, 250);
        // Console.WriteLine($"Max of 100 and 250: {maxValue}");
    }
    
    // Generic Swap Method
    // static void Swap<T>(ref T a, ref T b)
    // {
    //     T temp = a;
    //     a = b;
    //     b = temp;
    // }
    
    // // Generic method returning default value
    // static T GetDefault<T>()
    // {
    //     return default(T);
    // }
    
    // // Generic method with IComparable constraint
    // static T GetMax<T>(T a, T b) where T : IComparable<T>
    // {
    //     return a.CompareTo(b) > 0 ? a : b;
    // }
}

// Generic Box Class
// class Box<T>
// {
//     private T _value;
    
//     public void Store(T value)
//     {
//         _value = value;
//     }
    
//     public T Retrieve()
//     {
//         return _value;
//     }
// }

// Generic Pair Class with Multiple Type Parameters
// class Pair<TFirst, TSecond>
// {
//     public TFirst First { get; set; }
//     public TSecond Second { get; set; }
    
//     public Pair(TFirst first, TSecond second)
//     {
//         First = first;
//         Second = second;
//     }
// }
