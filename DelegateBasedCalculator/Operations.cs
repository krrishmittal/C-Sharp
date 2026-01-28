using System;
namespace DelegateBasedCalculator{
    public static class Operations{
        public static double Add(double a,double b){
            return a+b;
        }
        public static double Subtract(double a,double b){
            return a-b;
        }
        public static double Multiply(double a,double b){
            return a*b;
        }
        public static double Divide(double a,double b){
            if(b==0){
                Console.WriteLine("Division by zero occurred");
                return 0;
            }
            else{
                return a/b; 
            }
        }
    }
}