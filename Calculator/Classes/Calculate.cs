using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes
{
    internal class Calculate : ICalculate
    {
        protected bool Item = false;
        public string Name { get; set; }
        public string Function { get; set; }
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        public List<string> Histories { get; set; } = new List<string>();

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

        public virtual void Do()
        {
            string operation;
            switch (Function)
            {
                case "+":
                    Addition();
                    Item = true;
                    operation = $"Name : {Name}, {FirstNumber} + {SecondNumber} " +
                        $"= {FirstNumber + SecondNumber}";
                    Histories.Add(operation);
                    break;
                case "-":
                    Subtraction();
                    Item = true;
                    operation = $"Name : {Name}, {FirstNumber} - {SecondNumber} " +
                        $"= {FirstNumber - SecondNumber}";
                    Histories.Add(operation);
                    break;
                case "*":
                    Multiplication();
                    Item = true;
                    operation = $"Name : {Name}, {FirstNumber} / {SecondNumber} " +
                        $"= {FirstNumber / SecondNumber}";
                    Histories.Add(operation);
                    break;
                case "/":
                    Division();
                    Item = true;
                    operation = $"Name : {Name}, {FirstNumber} * {SecondNumber} " +
                        $"= {FirstNumber * SecondNumber}";
                    Histories.Add(operation);
                    break;
            }


        }

        public void Execute()
        {
            Console.Write("Name: ");
            Name = Console.ReadLine();

            bool repeat = true;

            while (repeat)
            {
                Console.WriteLine("1. Calculator \n2. Show history \n3. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice is 1)
                {
                    Console.Write("Function [ +, -, *, /, mTable]: ");
                    Function = Console.ReadLine();

                    if (Function == "+" || Function == "-" || Function == "*" || Function == "/")
                    {
                        Console.Write("firstNumber: ");
                        FirstNumber = Convert.ToDouble(Console.ReadLine());

                        Console.Write("secondNumber: ");
                        SecondNumber = Convert.ToDouble(Console.ReadLine());
                    }

                    Do();
                }
                else if (choice is 2)
                {
                    for (int i = 0; i < Histories.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {Histories[i]}");
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
