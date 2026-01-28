using System;
namespace DelegateBasedCalculator{
    class Program{
        public static void Main(){
            Calculator calc=new Calculator();
            Console.WriteLine("Enter first number:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose Operation: + - * /");
            string choice=Console.ReadLine();
            MathOperation operation=null;
            switch(choice){
                case "+":
                    operation+=Operations.Add;
                    break;
                case "-":
                    operation+=Operations.Subtract;
                    break;
                case "*":
                    operation+=Operations.Multiply;
                    break;
                case "/":
                    operation+=Operations.Divide;
                    break;
                default:
                    Console.WriteLine("Invalid operation selected.");
                    return;
            }
            double result = calc.Execute(a, b, operation);
            Console.WriteLine($"Result: {result}");
        }
    }
}