
/// <summary>
/// Day 2 - C# Intermediate Concepts Learning Program
/// 
/// This program demonstrates intermediate C# concepts including:
/// - Classes and object instantiation
/// - Inheritance and derived classes
/// - If-else conditional statements
/// - Out parameters for multiple return values
/// - Array creation and iteration (foreach loops)
/// - Params keyword for variable arguments
/// </summary>

using System;

class Program
{
    public static void Main(){
    // ===== EXAMPLE 1: Classes and Object Instantiation =====
    // Demonstrates creating a class and instantiating multiple objects
    // 
    // class Car
    // {
    //     public string name = "beep";
    // }
    // 
    // static void Main()
    // {
    //     Car car1 = new Car();
    //     Car car2 = new Car();
    //     
    //     Console.WriteLine(car1.name);  // Output: beep
    //     Console.WriteLine(car2.name);  // Output: beep
    // }


    // ===== EXAMPLE 2: Inheritance =====
    // Shows how to create a derived class that inherits from a base class
    // 
    // class Car
    // {
    //     public void StartEngine()
    //     {
    //         Console.WriteLine("Engine started");
    //     }
    // }
    // 
    // class Test : Car
    // {
    //     static void Main()
    //     {
    //         Test vehicle = new Test();
    //         vehicle.StartEngine();
    //     }
    // }


    // ===== EXAMPLE 3: If-Else Conditional Statements =====
    // Demonstrates decision-making based on age criteria
    // 
    // int age = 20;
    // if (age > 18)
    // {
    //     Console.WriteLine("Voting Eligible");
    // }
    // else
    // {
    //     Console.WriteLine("Voting Not Eligible");
    // }


    // ===== EXAMPLE 4: Out Parameters (Multiple Return Values) =====
    // Shows how to use the 'out' keyword to return multiple values from a method
    // 
    // void GetNumbers(out int num1, out int num2)
    // {
    //     num1 = 20;
    //     num2 = 30;
    // }
    // 
    // int number1, number2;
    // GetNumbers(out number1, out number2);
    // Console.WriteLine($"Number 1: {number1}");  // Output: 20
    // Console.WriteLine($"Number 2: {number2}");  // Output: 30


    // ===== EXAMPLE 5: Arrays with Foreach Loop =====
    // Demonstrates array creation and iteration using foreach
    // 
    // int[] numbers = { 1, 2, 3, 4, 5 };
    // 
    // foreach (int num in numbers)
    // {
    //     Console.WriteLine(num);
    // }


    // ===== EXAMPLE 6: Taking Array Input from User =====
    // Shows how to dynamically populate an array from user input
    // 
    // int[] numbers = new int[5];
    // 
    // for (int i = 0; i < numbers.Length; i++)
    // {
    //     Console.WriteLine($"Enter number {i + 1}: ");
    //     int value = Convert.ToInt32(Console.ReadLine());
    //     numbers[i] = value;
    // }
    // 
    // Console.WriteLine("Array elements:");
    // foreach (int num in numbers)
    // {
    //     Console.WriteLine(num);
    // }


    // ===== EXAMPLE 7: Params Keyword (Variable Arguments) =====
    // Demonstrates using 'params' to accept a variable number of arguments
    // This allows passing any number of values to a method
    // 
    // static int AddNumbers(params int[] numbers)
    // {
    //     int total = 0;
    //     foreach (int num in numbers)
    //     {
    //         total += num;
    //     }
    //     return total;
    // }
    // 
    // // Method can be called with different numbers of arguments
    // int sum = AddNumbers(1, 2, 3, 4, 5, 6);
    // Console.WriteLine($"Sum: {sum}");  // Output: 21
    }
}
