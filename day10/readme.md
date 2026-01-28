# Day 10 - Delegates in C#

## Topics Covered

### 1. **Declaring a Delegate**
   - Delegates are type-safe function pointers
   - Syntax: `delegate return_type DelegateName(parameters);`
   - Examples:
     - `public delegate void SimpleDelegate();`
     - `public delegate int MathDelegate(int a, int b);`
     - `public delegate void MessageDelegate(string message);`

### 2. **Single-cast Delegate**
   - A delegate that references a single method
   - **Traditional instantiation**: `SimpleDelegate del1 = new SimpleDelegate(SayHello);`
   - **Shorthand instantiation**: `SimpleDelegate del2 = SayGoodbye;`
   - Invoke using `del1()` or `del1.Invoke()`

### 3. **Delegates with Parameters and Return Types**
   - Delegates can accept parameters and return values
   - Example: `MathDelegate addDel = Add;`
   - Calling: `addDel(10, 5)` returns the result
   - Methods must match delegate signature exactly

### 4. **Multicast Delegate**
   - A delegate that can reference multiple methods
   - **Adding methods**: Use `+=` operator
   - **Removing methods**: Use `-=` operator
   - All referenced methods are invoked in order when delegate is called
   - Example:
     ```csharp
     MessageDelegate msgDel = Message1;
     msgDel += Message2;  // Adding another method
     msgDel += Message3;  // Adding another method
     msgDel("Hello!");    // Invokes all three methods
     ```

### 5. **Anonymous Methods**
   - Methods defined inline without a name
   - Useful for short, one-time use methods
   - Syntax: `delegate(parameters) { body };`
   - Example:
     ```csharp
     MathDelegate multiply = delegate(int x, int y)
     {
         return x * y;
     };
     ```

### 6. **Lambda Expressions with Delegates**
   - Concise syntax for anonymous methods
   - **Expression lambda**: `(x, y) => x / y`
   - **Statement lambda**: `(x, y) => { statements; return value; }`
   - Preferred over anonymous methods for readability
   - Example: `MathDelegate divide = (x, y) => x / y;`

### 7. **Built-in Generic Delegates**
   - **Action<T>** - Returns void, can have 0-16 parameters
     - `Action greet = () => Console.WriteLine("Hello!");`
     - `Action<string> greetPerson = (name) => Console.WriteLine($"Hello, {name}!");`
     - `Action<int, int> printSum = (a, b) => Console.WriteLine($"Sum: {a + b}");`
   - **Func<T, TResult>** - Returns a value, last type parameter is return type
     - `Func<int, int, int> addFunc = (a, b) => a + b;`
     - `Func<string, int> getLength = s => s.Length;`
   - **Predicate<T>** - Returns bool, takes one parameter
     - `Predicate<int> isEven = x => x % 2 == 0;`

### 8. **Delegate as Method Parameter (Callback)**
   - Pass delegates as parameters to methods
   - Enables callback pattern and strategy pattern
   - Example:
     ```csharp
     static void ProcessNumbers(int a, int b, MathDelegate operation)
     {
         int result = operation(a, b);
         Console.WriteLine($"Result = {result}");
     }
     ```
   - Usage: `ProcessNumbers(10, 5, Add);`
   - Can pass lambda: `ProcessNumbers(10, 5, (a, b) => a * b);`

### 9. **Multicast Delegate with Return Values**
   - When multicast delegate has return type, only last method's result is returned
   - Use `GetInvocationList()` to get all return values
   - Example:
     ```csharp
     foreach (MathDelegate d in multiMath.GetInvocationList())
     {
         Console.WriteLine($"Result: {d(10, 5)}");
     }
     ```

### 10. **Key Points to Remember**
   - Delegates provide type safety for method references
   - Delegates can be chained (multicast)
   - Lambda expressions are the modern way to use delegates
   - Built-in delegates (Action, Func, Predicate) reduce custom delegate definitions
   - Delegates are foundation for events in C#
   - Delegates enable loose coupling and callback patterns
