// <summary>
// Day 3 - Advanced C# Concepts Learning Program
// 
// This program demonstrates intermediate C# concepts including:
// - Working with string and multidimensional arrays
// - Jump statements (break, continue, goto)
// - Array sorting and searching methods
// - Classes and objects in C#
// - Method definitions and calling conventions
// - Parameter passing techniques (value, ref, out)
// </summary>

using System;

class Program
{
    // ===== EXAMPLE 1: String Arrays =====
    // Demonstrates creating and populating a string array with user input
    // 
    // string[] arr = new string[5];
    // for (int i = 0; i < arr.Length; i++)
    // {
    //     string name = Console.ReadLine();
    //     arr[i] = name;
    //     Console.WriteLine(arr[i]);
    // }


    // ===== EXAMPLE 2: Multidimensional Arrays (2D Arrays) =====
    // Shows how to work with 2D arrays using comma notation
    // A 2D array is created using a comma in the bracket [rows, columns]
    // 
    // int[,] arr = new int[4, 2];
    // 
    // // Input values into the 2D array
    // for (int i = 0; i < 4; i++)
    // {
    //     for (int j = 0; j < 2; j++)
    //     {
    //         arr[i, j] = Convert.ToInt32(Console.ReadLine());
    //     }
    // }
    // 
    // // Display the 2D array
    // for (int i = 0; i < 4; i++)
    // {
    //     for (int j = 0; j < 2; j++)
    //     {
    //         Console.Write(arr[i, j] + " ");
    //     }
    //     Console.WriteLine();
    // }


    // ===== EXAMPLE 3: Jump Statements - Break =====
    // Break statement stops the loop and exits from it
    // When i equals 2, the loop terminates immediately
    // 
    // for (int i = 0; i < 4; i++)
    // {
    //     if (i == 2)
    //     {
    //         break;
    //     }
    //     Console.WriteLine(i);
    // }


    // ===== EXAMPLE 4: Jump Statements - Continue =====
    // Continue statement skips the current iteration and goes to the next one
    // When i equals 2, that iteration is skipped
    // 
    // for (int i = 0; i < 4; i++)
    // {
    //     if (i == 2)
    //     {
    //         continue;
    //     }
    //     Console.WriteLine(i);
    // }


    // ===== EXAMPLE 5: Jump Statements - Goto =====
    // Goto statement transfers control to a labeled statement
    // Used here with switch-case to jump between cases
    // 
    // int i = 6;
    // switch (i)
    // {
    //     case 0:
    //         Console.Write(0);
    //         break;
    //     case 1:
    //         Console.Write(1);
    //         break;
    //     case 2:
    //         Console.Write(2);
    //         break;
    //     case 6:
    //         Console.Write(6);
    //         goto case 1;
    // }


    // ===== EXAMPLE 6: Array Sorting and Searching =====
    // Demonstrates Array.Sort() for sorting and Array.BinarySearch() for searching
    // Array.Sort() arranges elements in ascending order
    // Array.BinarySearch() finds the index of a specific element
    // 
    // int[] arr = new int[5] { 1, 5, 23, 33, 7 };
    // Array.Sort(arr);
    // 
    // foreach (int a in arr)
    // {
    //     Console.WriteLine(a);
    // }
    // 
    // Console.Write(Array.BinarySearch(arr, 23));


    // ===== EXAMPLE 7: Classes and Objects =====
    // Class: A user-defined type that contains fields, methods and members
    // Memory is allocated when an object of the class is created
    // This approach makes programs organized, reusable and maintainable
    // 
    // Object: An instance created from a class representing a real-world entity
    // All objects share the class's behavior but each has unique state
    // The 'new' keyword instantiates a class by allocating memory for a new object
    // 
    // class Num
    // {
    //     public int a, b;
    //     
    //     public void display(int a, int b)
    //     {
    //         this.a = a;
    //         this.b = b;
    //         Console.Write(a + " " + b);
    //     }
    // }
    // 
    // class Program
    // {
    //     static void Main()
    //     {
    //         Num n = new Num();
    //         n.display(4, 6);
    //     }
    // }


    // ===== EXAMPLE 8: Methods in C# =====
    // A method is a block of code that performs a specific task
    // Methods can take inputs, return results and make programs modular
    // 
    // Method Components:
    // - Access Modifier: Defines the visibility of the method
    // - Return Type: Specifies the type of value the method returns
    // - Method Name: The name used to call the method
    // - Parameters: A list of inputs (optional)
    // - Method Body: The code that defines what the method does
    // 
    // static int Add(int a, int b)
    // {
    //     return a + b;
    // }


    // ===== EXAMPLE 9: Direct Method Calling =====
    // Direct method calling: Invoke methods using an instance of the class
    // Requires creating an object first
    // 
    // class P
    // {
    //     public void print()
    //     {
    //         Console.WriteLine("Direct method calling");
    //     }
    // }
    // 
    // class M
    // {
    //     public static void Main()
    //     {
    //         P obj = new P();
    //         obj.print();
    //     }
    // }


    // ===== EXAMPLE 10: Static Method Calling =====
    // Static methods don't require creating an object
    // Can be called directly using the class name
    // 
    // class P
    // {
    //     public static int print(int value)
    //     {
    //         return value * value;
    //     }
    // }
    // 
    // class M
    // {
    //     public static void Main()
    //     {
    //         int res = P.print(4);
    //         Console.Write(res);
    //     }
    // }


    // ===== EXAMPLE 11: Method Parameters =====
    // Different types of parameter passing in C#
    // 
    // Value Parameter: Passes a copy of the argument
    //     void Display(int x) { }
    // 
    // Reference Parameter: Passes a reference to the argument
    //     void Update(ref int x) { }
    // 
    // Output Parameter: Used to return multiple values
    //     void GetValues(out int x) { }
}

