using Calculator.Classes;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = 0, secondNumber = 0;

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Function [ +, -, *, /, mTable]: ");
            string function = Console.ReadLine();
            if (function == "+" || function == "-"
                || function == "*" || function == "/")
            {
                Console.Write("firstNumber: ");
                firstNumber = Convert.ToDouble(Console.ReadLine());

                Console.Write("secondNumber: ");
                secondNumber = Convert.ToDouble(Console.ReadLine());
            }

            AdvancedCalculate advancedCalculate = new AdvancedCalculate(name, function,
                firstNumber, secondNumber);
            advancedCalculate.Do();

        }
    }
}