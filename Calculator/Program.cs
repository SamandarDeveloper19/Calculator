using Calculator.Classes;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("1. Calculator \n2. Show history \n3. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                double firstNumber = 0, secondNumber = 0;
                string function = null;
                AdvancedCalculate advancedCalculate = 
                    new AdvancedCalculate(name, function, firstNumber, secondNumber);
                if (choice is 1)
                {
                    Console.Write("Function [ +, -, *, /, mTable]: ");
                    function = Console.ReadLine();

                    if (function == "+" || function == "-" || function == "*" || function == "/")
                    {
                        Console.Write("firstNumber: ");
                        firstNumber = Convert.ToDouble(Console.ReadLine());

                        Console.Write("secondNumber: ");
                        secondNumber = Convert.ToDouble(Console.ReadLine());
                    }

                    advancedCalculate =
                        new AdvancedCalculate(name, function, firstNumber, secondNumber);
                    advancedCalculate.Do();
                }
                else if (choice is 2)
                {
                    foreach (string history in advancedCalculate.Histories)
                    {
                        Console.WriteLine(history);
                    }
                }
                else if (choice == 3)
                {
                    break;
                }

                Console.WriteLine("Do you want to do something again? [y / n]: ");
                string answer = Console.ReadLine();
                if (answer is "y")
                {
                    repeat = true;
                }
                else if (answer is "n")
                {
                    repeat = false;
                }
                
            }

        }
    }
}