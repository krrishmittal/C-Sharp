
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
