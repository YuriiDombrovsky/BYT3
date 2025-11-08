namespace Tut2_s29915;

public class Calculator
{
    private double a;
    private double b;
    private char operation;

    public Calculator(double a, double b, char operation)
    {
        this.a = a;
        this.b = b;
        this.operation = operation;
        
    }

    public double Calculate()
    {
        switch (operation)
        {
            case '+':
                return a + b;

            case '-':
                return a - b;

            case '*':
                return a * b;

            case '/':
                if (b == 0)
                {
                    throw new DivideByZeroException();
                } 
                return a / b;

            default:
                throw new InvalidOperationException();
        }
    }
}