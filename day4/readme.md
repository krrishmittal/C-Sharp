# Day 4 - Properties, Constructors, Exception Handling, and Abstraction

## Topics Covered

### 1. **Properties in C#**
   - Using `get` and `set` accessors to read and write private fields
   - Validation logic in setters
   - Restricting accessibility of properties

### 2. **Auto-Implemented Properties**
   - Simplified syntax for get/set without manual backing fields
   - Default value initialization with properties

### 3. **Constructors**
   - Automatically called when object is created
   - Same name as class, no return type
   - Used to initialize object data members
   
   **Types of Constructors:**
   - **Default Constructor** - No parameters
   - **Parameterized Constructor** - One or more parameters
   - **Copy Constructor** - Creates new object by copying values from existing object
   - **Static Constructor** - Initializes static members
   - **Private Constructor** - Prevents instantiation of the class

### 4. **Destructors**
   - Automatically called when object is destroyed
   - Used to release unmanaged resources (file handles, database connections)
   - Syntax: `~ClassName()`

### 5. **Exception Handling in C#**
   - **try block** - Contains code that might throw an exception
   - **catch block** - Handles specific exception types (multiple catch blocks allowed)
   - **finally block** - Always executes, used for cleanup tasks
   - **throw keyword** - Manually raise exceptions
   - Prevents programs from crashing due to runtime errors

### 6. **Custom Exceptions**
   - Creating user-defined exception classes by extending `Exception`
   - Passing custom error messages to exceptions

### 7. **Abstraction in C#**
   - **Abstract Classes** - Cannot be directly instantiated
   - **Abstract Methods** - Declared but not implemented, derived classes must implement them
   - **Virtual Methods** - Can be overridden in derived classes
   - **Override Keyword** - Used to implement abstract methods in derived classes
   - **Abstract Properties** - Define properties that derived classes must implement
   
   **Rules for Abstract Classes:**
   - Cannot support multiple inheritance
   - Can contain constructors and destructors
   - Can implement non-abstract methods
   - Can have abstract and virtual methods
   - Cannot be static
