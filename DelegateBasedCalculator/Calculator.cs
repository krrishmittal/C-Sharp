namespace DelegateBasedCalculator{
    public delegate double MathOperation(double x, double y);
    public class Calculator{
        public double Execute(double x,double y,MathOperation operation){
            return operation(x,y);
        }
    } 
}