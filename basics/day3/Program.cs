// string array
// string[] arr=new string[5];
// for(int i = 0; i < arr.Length; i++)
// {
//     string name=Console.ReadLine();
//     arr[i]=name;
//     Console.WriteLine(arr[i]);
// }


// 2d array we create using a comma in the bracket
// int[,] arr=new int[4,2];
// for(int i = 0; i < 4; i++)
// {
//     for(int j = 0; j < 2; j++)
//     {
//         arr[i,j]=Convert.ToInt32(Console.ReadLine());
//     }
// }

// for(int i = 0; i < 4; i++)
// {
//     for(int j = 0; j < 2; j++)
//     {
//         Console.Write(arr[i,j]+" ");
//     }
//     Console.WriteLine();
// }


// jump statements
//break stops the loop and come out of it
// for(int i = 0; i < 4; i++)
// {
//     if (i == 2)
//     {
//         break;
//     }
//     Console.WriteLine(i);
// }

//continue omiit the iteration and comes to the top of that loop
// for(int i = 0; i < 4; i++)
// {
//     if (i == 2)
//     {
//         continue;
//     }
//     Console.WriteLine(i);
// }

//go to used to give transfer to the labeled statement
// int i=6;
// switch (i)
// {
//     case 0:
//         Console.Write(0);
//         break;
//     case 1:
//         Console.Write(1);
//         break;
//     case 2:
//         Console.Write(2);
//         break;
//     case 6:
//         Console.Write(6);
//         goto case 1;
// }

// sorting an array Array.Sort() is the method for sorting the array in C#
// int[] arr=new int[5]{1,5,23,33,7};
// Array.Sort(arr);
// foreach(int a in arr)
// {
//     Console.WriteLine(a);
// }
// Console.Write(Array.BinarySearch(arr,23));


// Class and object in C#
// class is the user defined type that contains fields, methods and its members memory are allocated when the object of the class is being created

// class ClassName{
//     // Fields
//     // Properties
//     // Methods
// }

// here we have used the classes and object to display the values that were being passed as the parameters. the new keyword is used for instantiating a class by allocation memory for new object
// class Num
// {
//     public int a,b;
//     public void display(int a,int b)
//     {
//         this.a=a;
//         this.b=b;
//         Console.Write(a+ " "+b);
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         Num n=new Num();
//         n.display(4,6);
//     }
// }

// Methods in C#
