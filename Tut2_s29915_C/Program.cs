using Tut2_s29915;

//Part 2
Console.Write("Enter number: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter number: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter operation: ");
//Rider auto generate
char op = Convert.ToChar(Console.ReadLine() ?? string.Empty);


try
{
    Calculator calc = new Calculator(a, b, op);
    Console.WriteLine($"\nResult: {a} {op} {b} = {calc.Calculate():F3}");
}
catch (DivideByZeroException e)
{
    Console.WriteLine("Divide by zero");
}
catch (InvalidOperationException e)
{
    Console.WriteLine("InvalidOperation");
}
