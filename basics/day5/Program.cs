// Encapsulation in C# It refers to the practice of binding data (fields) and the methods that operate on that data into a single unit, while restricting direct access to some components. This ensures controlled interaction with an object’s internal state

// hides the internal representation of an object and exposes only necessary operations.
// Fields are often kept private while access is provided through public properties or methods.
// It improves data security, code maintainability and flexibility.
// Access modifiers (private, public, protected, internal) control visibility of members.

// class Amount
// {
//     private double balance;
//     public void deposit(int amt)
//     {
//         balance+=amt;
//         Console.WriteLine("Amount of "+amt+" deposit successfully");
//     }
//     public void withdraw(int amt)
//     {
//         if (balance >= amt)
//         {
//             balance-=amt;
//             Console.WriteLine("Amount of "+amt+" withdrawn successfull");
//         }
//         else
//         {
//             Console.WriteLine("Insufficient balance");
//         }
//     }
//     public void getBalance()
//     {
//         Console.WriteLine("Balance: "+balance);
//     }
// }
// class M
// {
//     public static void Main()
//     {
//         Amount a=new Amount();
//         a.deposit(500);
//         a.getBalance();
//         a.withdraw(200);
//         a.getBalance();
//         a.withdraw(500);
//     }
// }

// encapsulation usiong get and set method of properties
// class Person
// {
//     private string name="";
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
//                 name=value;
//             }
//         }
//     }
//     public static void Main()
//     {

//         Person p=new Person();
//         p.Name="krrish";
//         Console.WriteLine(p.Name);
//     }
// }

// inheritance in C# eature that allows one class to derive properties and behaviors from another class. It promotes code reusability, extensibility and establishes a natural hierarchical relationship between classes.

// class Animal
// {
//     public void eat()
//     {
//         Console.WriteLine("Animal is eating");
//     }
// }
// class Dog : Animal
// {
//     public void sound()
//     {
//         Console.WriteLine("Dop is barking");
//     }
// }
// class P
// {
//     public static void Main()
//     {
//         Dog d=new Dog();
//         d.eat(); // inherited methods
//         d.sound(); // derived class method
//     }
// }


// Inheritance is achieved using the : (colon) symbol.
// Derived Class: The class that inherits the other class is known as a subclass ( or a derived class, extended class or child class).
// Parent Class: The class whose features are inherited is known as a superclass (or a base class or a parent class).
// C# supports single inheritance (a class can directly inherit from only one class).
// A derived class can itself serve as a base for another class.
// All classes in C# implicitly inherit from the System.Object class.

// C# directly supports the following inheritance forms:
// Single Inheritance: One class derives from one base class. example above

// Multilevel Inheritance: A class derives from another derived class.
// class Animal
// {
//     public void eat()
//     {
//         Console.WriteLine("Animal is eating");
//     }
// }
// class Dog : Animal
// {
//     public void sound()
//     {
//         Console.WriteLine("Dop is barking");
//     }
// }
// class Cat : Dog
// {
//     public void name()
//     {
//         Console.WriteLine("My name is cat");
//     }
// }
// class P
// {
//     public static void Main()
//     {
//         Cat c=new Cat();
//         c.eat();
//         c.sound();
//         c.name();
//     }
// }

// Hierarchical Inheritance: Multiple classes derive from a single base class.


// Multiple Inheritance (Through Interfaces): A class can implement multiple interfaces, achieving multiple inheritance indirectly, since C# does not allow multiple base class es.

// Method Overloading in C# is the ability to define multiple methods with the same name but different parameter lists.

// Parameter lists can differ by type, number or order of parameters.
// Improves readability and lets related tasks use the same method name.
// Cannot overload methods by only changing the return type (causes compile-time error).
// Also known as compile-time (static) polymorphism.

// Changing the number of Parameters
    // public int Add(int a, int b)
    // {
    //     int sum = a + b;
    //     return sum;
    // }

    // // adding three integer values.
    // public int Add(int a, int b, int c)
    // {
    //     int sum = a + b + c;
    //     return sum;
    // }

// Changing the Data types of the parameters
    // public static int Add(int a,int b,int c)
    // {
    //     int sum = a + b + c;
    //     return sum;
    // }

    // // adding three double values
    // public static double Add(double a, double b, double c)
    // {
    //     double sum = a + b + c;
    //     return sum;
    // }

// Changing the Order of the parameters
    // public void Identity(String name, int id)
    // {
    //     Console.WriteLine("Name1 : " + name + ", "+ "Id1 : " + id);
    // }

    // public void Identity(int id, String name)
    // {
    //     Console.WriteLine("Name2 : " + name + ", " + "Id2 : " + id);
    // }

// Method overriding in C# allows a derived class to provide a new implementation of a method that is already defined in its base class. It is a key feature of runtime polymorphism.
// virtual Keyword is used in the base class to define a method that can be overridden in a derived class.

// class Animal { 
//     public virtual void Move()
//     {
//         Console.WriteLine("Animal is moving.");
//     }
//     public void Eat()
//     {
//         Console.WriteLine("Animal is eating.");
//     }
// }

// class Dog : Animal {
  
//     Overriding the Move method from the base class
//     public override void Move()
//     {
//         Console.WriteLine("Dog is running.");
//     }

//     public void Bark()
//     {
//         Console.WriteLine("Dog is barking.");
//     }
// }

// class P{
//     static void Main()
//     {
//         Dog d = new Dog();
//         d.Move();
//         d.Eat();
//         d.Bark();
//     }
// }

// abstract class is a class that cannot be instantiated directly. Abstract classes are used when we want to define a common template for a group of related classes but leave some methods or properties to be implemented by derived classes.
// An abstract class cannot be directly instantiated. We can only create objects of derived classes.
// Abstract methods are declared in the abstract classes but do not have implementation, derived classes are required to implement them.
// An abstract class also contains properties and fields which can be accessed by derived classes.

    // abstract class Shape
	// {

	// 	// abstract method
    //     // No direct access
	// 	public abstract int area();
	// }

	// square class inheriting
	// the Shape class
	// class Square : Shape
	// {

	// 	// private data member
	// 	private int side;

	// 	// method of square class
	// 	public Square(int x = 0)
	// 	{
	// 		side = x;
	// 	}

	// 	// overriding of the abstract method of Shape
	// 	// class using the override keyword
	// 	public override int area()
	// 	{
	// 		Console.Write("Area of Square: ");
	// 		return (side * side);
	// 	}
	// }
	// class P
	// {
	// 	static void Main(string[] args)
	// 	{
    //         creating reference of Shape class
	// 		which refer to Square class instance
	// 		Shape sh = new Square(4);
	// 		// calling the method
	// 		double result = sh.area();
	// 		Console.Write("{0}", result);

	// 	}
	// }

// The interface is declared using the interface keyword. We can create abstract methods inside the interface similar to abstract classes and declare their functionality in the derived class. From the derived class we can access those properties using the derived class by creating the Instance of the derived class.

// interface inter1{
// 	// method having only declaration with no definition
// 	void display();
// }

// // Implementing inteface in Geeks
// class P : inter1{
    
// 	// providing the body part of function 
// 	public void display(){
// 		Console.WriteLine("Demonstration of interface");
// 	}

// 	public static void Main(String[] args){
// 		Geeks t = new Geeks();
// 		t.display();
// 	}
// }

// lambda expression
// class Program
// {
//     static readonly Func<int, int, int> add = (a, b) => a + b;
//     public static void Main()
//     {
//         int sum=add(1,2);
//         Console.WriteLine(sum);
//     }
// }