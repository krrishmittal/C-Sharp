// See https://aka.ms/new-console-template for more information

// printing statetent
// Console.WriteLine("Enter your name:");

// taking input from user and printing it
// string name =Console.ReadLine();  
// Console.WriteLine($"hello {name}");


// integer calculations and how to use the class that we create outside the program main file

// Calc  c = new Calc();
// int res=c.add(5,10);  //Addition
// Console.WriteLine($"The sum is {res}");
// int res1=c.sub(5,10);  //substraction
// Console.WriteLine($"The sum is {res1}");
// int res2=c.mul(5,10);  //multiplication
// Console.WriteLine($"The sum is {res2}");
// int res3=c.div(5,10);  //division
// Console.WriteLine($"The sum is {res3}");

// Control Statements 

// In i=new In();
// int age=i.Inp1();
// if (age > 10)
// {
//     Console.WriteLine("Eligible");
// }
// else
// {
//     Console.WriteLine("Not eligible");
// }

// loops in c#
// for(int i = 0; i < 10; i++)
// {
//     Console.WriteLine($"value :{i}");
// }

//class in c# 
// class Program
// {
//     static void greet(String name)
//     {
//         Console.WriteLine($"Hello :{name}");
//     }
//     static void main()
//     {
//        greet("krrish");
//        greet("madhuarya"); 
//     }
// }


// variables in c#
// int age=18;
// string name="Krrish";
// bool flag=true;
// double pi=3.14;

// arrays in c#
// string[] students={"krrish","nitin","abhishek","nikhil"};
// for(int i = 0; i < students.Length; i++)
// {
//     Console.WriteLine($"Name: {students[i]}");
// }


// class Car
// {
//     public string name="beep";

    // static void Main()
    // {   
    //     Car c =new Car();
    //     Car c1=new Car();

    //     Console.WriteLine(c.name);
    // }
// }

// class Test :Car
// {
//     static void Main()
//     {
//         Hell h=new Hell();
//         h.print();
//     }
// }

// if else statements
// int age=10;
// if (age > 18)
// {
//     Console.WriteLine("Voting Eligible");
// }
// else
// {
//     Console.WriteLine("Voting not eligible");
// }

//out parameter used to return multiple values from a method
// void hi(out int num1,out int num2){
//     num1=20;
//     num2=30;
// }
// int num1,num2;
// hi(out num1,out num2);
// Console.WriteLine(num1);
// Console.WriteLine(num2);

// Arrays in C#

// int[] arr={1,2,3,4,5};
// foreach (int a in arr)
// {
//     Console.WriteLine(a);
// }

// taking input for the array in the integer array
// int[] arr=new int[5];
// for(int i=0;i<arr.Length;i++)
// {
//     int val=Convert.ToInt32(Console.ReadLine());
//     arr[i]=val;
// }
// foreach (int a in arr)
// {
//     Console.WriteLine(a);
// }

// use of params we can pass any number of values in the function parameter
// int[] arr={1,2,3,4,5};
// static int add(params int[] arr)
// {
//     int total=0;
//     foreach (int a in arr)
//     {
//         total+=a;
//     }
//     return total;
// }
// // int total=add(arr); simple way of passing the value to the method in the form of array
// int total=add(1,2,3,4,5,6);
// Console.WriteLine(total);







