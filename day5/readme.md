# Day 5 - Encapsulation, Inheritance, Polymorphism, Interfaces, and Lambda Expressions

## Topics Covered

### 1. **Encapsulation in C#**
   - Binding data (fields) and methods into a single unit
   - Restricting direct access to internal components
   - Hiding internal representation and exposing only necessary operations
   - Fields kept private with public properties/methods for controlled access
   - Benefits: Improved data security, code maintainability, and flexibility
   - Using access modifiers (private, public, protected, internal) to control visibility

### 2. **Inheritance in C#**
   - Allows one class to derive properties and behaviors from another class
   - Promoted code reusability, extensibility, and establishes hierarchical relationships
   - Achieved using `:` (colon) symbol
   - **Terminology:**
     - Derived Class (Subclass): Inherits from another class
     - Parent Class (Base Class): Class whose features are inherited
     - C# supports single inheritance only (a class derives from one base class directly)
   
   **Types of Inheritance:**
   - **Single Inheritance** - One class derives from one base class
   - **Multilevel Inheritance** - A class derives from another derived class
   - **Hierarchical Inheritance** - Multiple classes derive from a single base class
   - **Multiple Inheritance (Through Interfaces)** - Class implements multiple interfaces
   - All classes implicitly inherit from `System.Object`

### 3. **Method Overloading (Compile-Time Polymorphism)**
   - Defining multiple methods with the same name but different parameter lists
   - Parameter lists can differ by:
     - Type of parameters
     - Number of parameters
     - Order of parameters
   - Improves readability and allows related tasks to use the same method name
   - Cannot overload by only changing return type (compile-time error)

### 4. **Method Overriding (Runtime Polymorphism)**
   - Derived class provides new implementation of method from base class
   - **virtual keyword** - Used in base class to define overridable methods
   - **override keyword** - Used in derived class to implement the method
   - Enables runtime polymorphism and flexible code design

### 5. **Abstract Classes**
   - Cannot be directly instantiated
   - Used to define common template for related classes
   - Abstract methods have no implementation (declared but not defined)
   - Derived classes must implement abstract methods
   - Can contain properties, fields, constructors, and concrete methods
   - Cannot support multiple inheritance
   - Cannot be static

### 6. **Interfaces**
   - Declared using `interface` keyword
   - Similar to abstract classes but only contain method declarations
   - No direct implementation in interface definition
   - Derived classes must implement all interface methods
   - Enable contract-based programming
   - Multiple interfaces can be implemented by a single class

### 7. **Lambda Expressions**
   - Concise way to define anonymous methods
   - Syntax: `(parameters) => expression`
   - Used with delegate types and LINQ queries
   - Improves code readability and reduces boilerplate
   - Example: `Func<int, int, int> add = (a, b) => a + b;`
