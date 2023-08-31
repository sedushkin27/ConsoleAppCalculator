namespace ConsoleAppCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.DivideByZero += HandleDivideByZero;

            Console.WriteLine("Enter two numbers:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter an operation (+, -, *, /):");
            string operation = Console.ReadLine();

            double result = 0;

            switch (operation)
            {
                case "+":
                    result = calculator.Add(a, b);
                    break;
                case "-":
                    result = calculator.Subtract(a, b);
                    break;
                case "*":
                    result = calculator.Multiply(a, b);
                    break;
                case "/":
                    result = calculator.Divide(a, b);
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }

            Console.WriteLine($"Result: {result}");
        }
        static void HandleDivideByZero(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Cannot divide by zero!");
            Console.ResetColor();
        }
    }

}