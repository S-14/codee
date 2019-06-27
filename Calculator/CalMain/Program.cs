using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace CalMain
{
    delegate void ArithmaticOperation(int num1, int num2);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter choice: \n 1.ADD \n 2.SUB \n 3.MULT \n 4.DIV \n");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("enter num1:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter num2:");
            int num2 = int.Parse(Console.ReadLine());

            CalculatorBOL cal = new CalculatorBOL();
           
            switch (choice)
            {
                case 1:
                    ArithmaticOperation op1 = new ArithmaticOperation(cal.Add);
                    op1(num1, num2);
                    Console.WriteLine("addition is");
                    break;
                case 2:
                    ArithmaticOperation op2 = new ArithmaticOperation(cal.Sub);
                    op2(num1, num2);
                    Console.WriteLine("subtraction is");
                    break;
                   
            }
            int result = cal.Result;
            Console.WriteLine(result);
            Console.ReadLine();
        }
        }
    }

