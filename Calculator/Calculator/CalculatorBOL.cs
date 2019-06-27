using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorBOL
    {
        public int Result { get;set;}

        public void Add(int num1,int num2)
        {
            Result = num1 + num2;
        }
        public void Sub(int num1, int num2)
        {
            Result = num1 - num2;
        }
        public void Mult(int num1, int num2)
        {
            Result = num1 * num2;
        }
        public void Div(int num1, int num2)
        {
            Result = num1 / num2;
        }
    }
}
