using System;

namespace DelegatesDemo
{
    // 1. DECLARING A DELEGATE
    // Syntax: delegate return_type DelegateName(parameters);
    public delegate void SimpleDelegate();
    public delegate int MathDelegate(int a, int b);
    public delegate void MessageDelegate(string message);

    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("===== DELEGATES IN C# =====\n");

            // // ========================================
            // // 2. SINGLE-CAST DELEGATE
            // // ========================================
            // Console.WriteLine("--- Single-cast Delegate ---");
            
            // Instantiating delegate (Method 1 - Traditional)
            // SimpleDelegate del1 = new SimpleDelegate(SayHello);
            // del1();

            // // Instantiating delegate (Method 2 - Shorthand)
            // SimpleDelegate del2 = SayGoodbye;
            // del2();

            // // Delegate with parameters and return type
            // MathDelegate addDel = Add;
            // MathDelegate subDel = Subtract;
            
            // Console.WriteLine($"Add: 10 + 5 = {addDel(10, 5)}");
            // Console.WriteLine($"Subtract: 10 - 5 = {subDel(10, 5)}");

            // // ========================================
            // // 3. MULTICAST DELEGATE
            // // ========================================
            // Console.WriteLine("\n--- Multicast Delegate ---");
            
            // MessageDelegate msgDel = Message1;
            // msgDel += Message2;  // Adding another method
            // msgDel += Message3;  // Adding another method
            
            // // Invokes all three methods
            // msgDel("Hello from Multicast!");

            // // Removing a method from multicast
            // msgDel -= Message2;
            // Console.WriteLine("\nAfter removing Message2:");
            // msgDel("Hello again!");

            // // ========================================
            // // 4. ANONYMOUS METHODS
            // // ========================================
            // Console.WriteLine("\n--- Anonymous Methods ---");
            
            // MathDelegate multiply = delegate(int x, int y)
            // {
            //     return x * y;
            // };
            // Console.WriteLine($"Multiply: 10 * 5 = {multiply(10, 5)}");

            // // ========================================
            // // 5. LAMBDA EXPRESSIONS WITH DELEGATES
            // // ========================================
            // Console.WriteLine("\n--- Lambda Expressions ---");
            
            // // Lambda expression syntax
            // MathDelegate divide = (x, y) => x / y;
            // Console.WriteLine($"Divide: 10 / 5 = {divide(10, 5)}");

            // // Multi-line lambda
            // MathDelegate modulus = (x, y) =>
            // {
            //     Console.WriteLine("Calculating modulus...");
            //     return x % y;
            // };
            // Console.WriteLine($"Modulus: 10 % 3 = {modulus(10, 3)}");

            // // ========================================
            // // 6. BUILT-IN GENERIC DELEGATES
            // // ========================================
            // Console.WriteLine("\n--- Built-in Generic Delegates ---");

            // // Action<T> - Returns void, can have 0-16 parameters
            // Action greet = () => Console.WriteLine("Hello from Action!");
            // greet();

            // Action<string> greetPerson = (name) => Console.WriteLine($"Hello, {name}!");
            // greetPerson("John");

            // Action<int, int> printSum = (a, b) => Console.WriteLine($"Sum: {a + b}");
            // printSum(5, 3);

            // // Func<T, TResult> - Returns a value, last type is return type
            // Func<int, int, int> addFunc = (a, b) => a + b;
            // Console.WriteLine($"Func Add: {addFunc(10, 20)}");

            // Func<string, int> getLength = s => s.Length;
            // Console.WriteLine($"Length of 'Hello': {getLength("Hello")}");

            // // Predicate<T> - Returns bool, takes one parameter
            // Predicate<int> isEven = x => x % 2 == 0;
            // Console.WriteLine($"Is 4 even? {isEven(4)}");
            // Console.WriteLine($"Is 7 even? {isEven(7)}");

            // // ========================================
            // // 7. DELEGATE AS METHOD PARAMETER (CALLBACK)
            // // ========================================
            // Console.WriteLine("\n--- Delegate as Callback ---");
            
            // ProcessNumbers(10, 5, Add);
            // ProcessNumbers(10, 5, Subtract);
            // ProcessNumbers(10, 5, (a, b) => a * b);

            // // ========================================
            // // 8. DELEGATE WITH RETURN VALUES (MULTICAST)
            // // ========================================
            // Console.WriteLine("\n--- Multicast with Return Values ---");
            
            // MathDelegate multiMath = Add;
            // multiMath += Subtract;
            // multiMath += (a, b) => a * b;
            
            // // Only returns the last method's result
            // int result = multiMath(10, 5);
            // Console.WriteLine($"Multicast result (last method): {result}");

            // // Getting all return values
            // Console.WriteLine("All return values:");
            // foreach (MathDelegate d in multiMath.GetInvocationList())
            // {
            //     Console.WriteLine($"  Result: {d(10, 5)}");
            // }

            // // ========================================
            // // 9. PRACTICAL EXAMPLE - CALCULATOR
            // // ========================================
            // Console.WriteLine("\n--- Practical Example: Calculator ---");
            
            // Calculator calc = new Calculator();
            // calc.PerformOperation(100, 25, (a, b) => a + b, "Addition");
            // calc.PerformOperation(100, 25, (a, b) => a - b, "Subtraction");
            // calc.PerformOperation(100, 25, (a, b) => a * b, "Multiplication");
            // calc.PerformOperation(100, 25, (a, b) => a / b, "Division");
            Mydelegate me=MethodA;
            me+=MethodB;
            me();
        }

        // Methods for delegates
        // static void SayHello() => Console.WriteLine("Hello!");
        // static void SayGoodbye() => Console.WriteLine("Goodbye!");
        
        // static int Add(int a, int b) => a + b;
        // static int Subtract(int a, int b) => a - b;

        // static void Message1(string msg) => Console.WriteLine($"Message1: {msg}");
        // static void Message2(string msg) => Console.WriteLine($"Message2: {msg}");
        // static void Message3(string msg) => Console.WriteLine($"Message3: {msg}");

        // // Method accepting delegate as parameter (callback pattern)
        // static void ProcessNumbers(int a, int b, MathDelegate operation)
        // {
        //     int result = operation(a, b);
        //     Console.WriteLine($"Processing {a} and {b}: Result = {result}");
        // }
        public delegate void Mydelegate();
    
        public static void MethodB(){
            Console.WriteLine("Mehtond b");
        }
        public static void MethodA(){
            Console.WriteLine("Method a");
        }
        
    }
    
    // Calculator class demonstrating delegates
    // class Calculator
    // {
    //     public void PerformOperation(int a, int b, Func<int, int, int> operation, string opName)
    //     {
    //         int result = operation(a, b);
    //         Console.WriteLine($"{opName}: {a} and {b} = {result}");
    //     }
    // }
}