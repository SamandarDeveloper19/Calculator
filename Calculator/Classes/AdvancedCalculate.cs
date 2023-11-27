﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes
{
    internal class AdvancedCalculate : Calculate
    {
        public AdvancedCalculate(string name, string function, double firstNumber, double secondNumber)
            : base(name, function, firstNumber, secondNumber)
        { }

        public override void Do()
        {
            base.Do();
            switch (Function)
            {
                case "mTable":
                    MultiplicationTable();
                    Item = true;
                    break;
            }
            if(Item == false)
                Console.WriteLine("function is error!");
        }

        public void MultiplicationTable()
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    Console.Write($"{j} * {i} = {i * j}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 1; i < 10; i++)
            {
                for (int j = 6; j <= 10; j++)
                {
                    Console.Write($"{j} * {i} = {i * j}\t");
                }
                Console.WriteLine();
            }
        }
    }
}