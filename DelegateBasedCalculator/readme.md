# Delegate-Based Calculator

A simple console calculator application demonstrating the use of **delegates** in C#.


## 🎯 Concepts Demonstrated

### 1. **Custom Delegate Declaration**
```csharp
public delegate double MathOperation(double x, double y);
```
- Defines a delegate type that accepts two `double` parameters and returns a `double`
- Acts as a type-safe function pointer for math operations

### 2. **Delegate as Method Parameter**
```csharp
public double Execute(double x, double y, MathOperation operation)
{
    return operation(x, y);
}
```
- The `Calculator` class accepts a delegate as a parameter
- Enables flexible operation selection at runtime
- Demonstrates the **callback pattern**

### 3. **Static Methods Matching Delegate Signature**
The `Operations` class contains static methods that match the `MathOperation` delegate:
- `Add(double a, double b)` - Addition
- `Subtract(double a, double b)` - Subtraction
- `Multiply(double a, double b)` - Multiplication
- `Divide(double a, double b)` - Division with zero-check

### 4. **Delegate Assignment with Switch Statement**
```csharp
MathOperation operation = null;
switch(choice)
{
    case "+": operation += Operations.Add; break;
    case "-": operation += Operations.Subtract; break;
    // ...
}
```
- Dynamically assigns the appropriate method to the delegate based on user input

## 🚀 How to Run

```bash
cd DelegateBasedCalculator
dotnet run
```

## 📝 Sample Output

```
Enter first number:
10
Enter second number:
5
Choose Operation: + - * /
+
Result: 15
```

## 🔑 Key Takeaways

- **Delegates** enable passing methods as parameters
- **Type safety** - Only methods matching the delegate signature can be assigned
- **Separation of concerns** - Operations are separate from the calculator logic
- **Extensibility** - New operations can be added without modifying the Calculator class
- **Division by zero** is handled gracefully in the `Divide` method
