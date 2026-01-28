# Day 9 - Generics in C#

## Topics Covered

### 1. **Why Generics? - The Problem**
   - Without generics, we'd use `object` type causing boxing/unboxing
   - Boxing/unboxing causes performance issues and no type safety
   - `ArrayList` allows mixing types - dangerous at runtime
   - Generics provide compile-time type safety
   - No casting needed when retrieving values

### 2. **Basic Generic Method**
   - Generic methods work with any type `T`
   - Type parameter `<T>` is specified after method name
   - Syntax: `static void MethodName<T>(T parameter)`
   - Compiler can infer type from arguments
   - Explicit type: `Swap<int>(ref x, ref y)`
   - Type inference: `Swap(ref s1, ref s2)`

### 3. **Generic Method with Return Type**
   - Generic methods can return generic types
   - Useful for creating utility functions
   - Example: `static T GetMax<T>(T a, T b)`
   - Works with any type that satisfies constraints

### 4. **Basic Generic Class**
   - Generic classes are type-parameterized containers
   - Create once, use with any type
   - Common naming conventions:
     - `T` for Type
     - `TKey`, `TValue` for key-value pairs
     - `TResult` for return types
   - Syntax: `class ClassName<T> { }`
   - Usage: `Box<int> intBox = new Box<int>();`

### 5. **Generic Class with Multiple Type Parameters**
   - Classes can have multiple type parameters
   - Useful for key-value pairs, tuples, etc.
   - Syntax: `class Pair<TFirst, TSecond> { }`
   - Each type parameter can be different
   - Example: `Pair<int, string>` for ID-Name pairs

### 6. **Generic Constraints - where Clause**
   - Constraints restrict which types can be used
   - **`where T : struct`** - T must be a value type (int, double, struct)
   - **`where T : class`** - T must be a reference type
   - **`where T : new()`** - T must have parameterless constructor
   - **`where T : BaseClass`** - T must inherit from BaseClass
   - **`where T : IInterface`** - T must implement interface

### 7. **IComparable\<T\> Constraint**
   - `where T : IComparable<T>` enables comparison operations
   - **CompareTo()** - Returns negative, zero, or positive
   - Allows using `<`, `>`, `==` logic in generic code
   - Required for sorting and finding max/min values

### 8. **The default Keyword with Generics**
   - `default(T)` gives default value for type `T`
   - Useful in generic methods and classes
   - Examples:
     - `default(int)` is `0`
     - `default(bool)` is `false`
     - `default(SomeClass)` is `null`
   - Can be used to initialize variables, parameters, or return values

### 9. **Covariance and Contravariance**
   - Covariance: `IEnumerable<out T>` - allows more derived types
   - Contravariance: `IComparer<in T>` - allows less derived types
   - Enables flexibility in assigning and using generic types
   - Useful in collections and delegate scenarios

### 10. **Generic Interfaces and Delegates**
   - Interfaces can be generic: `IRepository<T>`
   - Delegates can also be generic: `Func<T, TResult>`
   - Enables creating flexible and reusable components
   - Commonly used in LINQ and event handling

### 11. **Nested Generics**
   - Generics can be nested: `Dictionary<string, List<int>>`
   - Enables complex data structures
   - Can combine multiple generic types and collections

### 12. **Generic Methods in Interfaces and Abstract Classes**
   - Interfaces and abstract classes can have generic methods
   - Example: `IComparable<T>.CompareTo(T other)`
   - Implementing classes must provide type arguments

### 13. **Constraints on Generic Methods**
   - Generic methods can have constraints
   - Syntax: `where T : struct, new()`
   - Multiple constraints: `where T : BaseClass, IInterface`
   - Constraints can be applied to type parameters in methods

### 14. **Using Generics with Collections**
   - Collections in .NET are often generic
   - `List<T>`, `Dictionary<TKey, TValue>`, `HashSet<T>`
   - Provides type safety and performance benefits
   - Preferred over non-generic collections like `ArrayList`

### 15. **Performance Considerations**
   - Generics improve performance by eliminating boxing/unboxing
   - No need for type casting
   - Better memory management with fewer allocations
   - Overall, generics lead to faster and more efficient code

### 16. **Best Practices with Generics**
   - Use meaningful type parameter names (`T`, `TKey`, `TValue`)
   - Keep methods and classes focused and not overly generic
   - Prefer constraints to limit type parameters when possible
   - Leverage covariance and contravariance in interfaces and delegates