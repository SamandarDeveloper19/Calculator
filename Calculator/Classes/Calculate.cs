using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes
{
    internal class Calculate
    {
        protected bool Item = false;
        public string Name { get; set; }
        public string Function { get; set; }
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }

        public Calculate(string name, string function, double firstNumber, double secondNumber)
        {
            Name = name;
            Function = function;
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }

        public virtual void Do()
        {
            switch (Function)
            {
                case "+":
                    Addition();
                    Item = true;
                    break;
                case "-":
                    Subtraction();
                    Item = true;
                    break;
                case "*":
                    Multiplication();
                    Item = true;
                    break;
                case "/":
                    Division();
                    Item = true;
                    break;
                
            }
        }

        public void Addition()
        {
            double result = FirstNumber + SecondNumber;
            Console.WriteLine($"\nName: {Name} \n{FirstNumber} + {SecondNumber} = {result}");
        }

        public void Subtraction()
        {
            double result = FirstNumber - SecondNumber;
            Console.WriteLine($"\nName: {Name} \n{FirstNumber} - {SecondNumber} = {result}");
        }

        public void Multiplication()
        {
            double result = FirstNumber * SecondNumber;
            Console.WriteLine($"\nName: {Name} \n{FirstNumber} * {SecondNumber} = {result}");
        }

        public void Division()
        {
            double result = FirstNumber / SecondNumber;
            Console.WriteLine($"\nName: {Name} \n{FirstNumber} / {SecondNumber} = {result}");
        }
    }
}
