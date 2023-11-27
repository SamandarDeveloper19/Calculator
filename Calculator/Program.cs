using Calculator.Classes;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AdvancedCalculate advancedCalculate = new AdvancedCalculate();

            advancedCalculate.Execute();
        }
    }
}