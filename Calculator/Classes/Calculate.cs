using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes
{
    internal class Calculate
    {
        string name;
        char item;
        double firstNumber, secondNumber;

        public Calculate(string name, char item, double firstNumber, double secondNumber)
        {
            this.name = name;
            this.item = item;
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }

        public void Do()
        {
            switch (item)
            {
                case '+':
                    Addition();
                    break;
                case '-':
                    Subtraction();
                    break;
                case '*':
                    Multiplication();
                    break;
                case '/':
                    Division();
                    break;
                default:
                    Console.WriteLine("Inserted action was error");
                    break;
            }
        }

        public void Addition()
        {
            double result = firstNumber + secondNumber;
            Console.WriteLine($"\nName: {name} \n{firstNumber} + {secondNumber} = {result}");
        }

        public void Subtraction()
        {
            double result = firstNumber - secondNumber;
            Console.WriteLine($"\nName: {name} \n{firstNumber} - {secondNumber} = {result}");
        }

        public void Multiplication()
        {
            double result = firstNumber * secondNumber;
            Console.WriteLine($"\nName: {name} \n{firstNumber} * {secondNumber} = {result}");
        }

        public void Division()
        {
            double result = firstNumber / secondNumber;
            Console.WriteLine($"\nName: {name} \n{firstNumber} / {secondNumber} = {result}");
        }
    }
}
