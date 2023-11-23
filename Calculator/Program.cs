using Calculator.Classes;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Function [ +, -, *, / ]: ");
            char item = Convert.ToChar(Console.ReadLine());
            Console.Write("firstNumber: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("secondNumber: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());


            Calculate calculate = new Calculate(name, item, firstNumber, secondNumber);
            calculate.Do();
        }
    }
}