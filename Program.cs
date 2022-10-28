using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON_7__METHODS_
{
    class Program
    {
        // Additional Task
        #region
        //int sum1, sum2, total;
        ////---------------------------------------------------------------------------

        //public Program()
        //{
        //    this.sum1 = 0;
        //    this.sum2 = 0;
        //    this.total = 0;
        //}
        ////---------------------------------------------------------------------------
        //public static int CalculateAverage(ref int total, int sum1, int sum2)
        //{
        //    total += sum1 + sum2;
        //    total /= 2;
        //    return total;
        //}
        //---------------------------------------------------------------------------
        #endregion

        // Task 2
        #region
        int operation1, operation2;
        //--------------------------------------------------------------------------------------

        public Program()
        {
            this.operation1 = 0;
            this.operation2 = 0;
        }

        public Program(int operation1, int operation2)
        {
            this.operation1 = operation1;
            this.operation2 = operation2;
        }
        //--------------------------------------------------------------------------------------

        public static int Add(ref int operation1, ref int operation2)
        {
            if (operation1 != 0 && operation2 != 0)
            {
                return operation1 + operation2;
            }
            else
                return -1;              
        }
        //--------------------------------------------------------------------------------------

        public static int Substraction(ref int operation1, ref int operation2)
        {
            if (operation1 != 0 && operation2 != 0)
            {
                return operation1 - operation2;
            }
            else
                return -1;
        }
        //--------------------------------------------------------------------------------------

        public static int Multiplication(ref int operation1, ref int operation2)
        {
            if (operation1 != 0 && operation2 != 0)
            {
                return operation1 * operation2;
            }
            else
                return -1;
        }
        //--------------------------------------------------------------------------------------

        public static int Division(ref int operation1, ref int operation2)
        {
            if (operation1 != 0 && operation2 != 0)
            {
                return operation1 / operation2;
            }
            else 
            {
                if (operation1 == operation1 / 0)
                {
                    Console.WriteLine("Divide by zero exception!");
                }
                return -1;
            }
        }
        //--------------------------------------------------------------------------------------

        public int MenuOfOperations()
        {
            Console.WriteLine("Add - +");
            Console.WriteLine("Sub - -");
            Console.WriteLine("Mult - *");
            Console.WriteLine("Div - /\n");

            Console.WriteLine("Enter the operation: ");
            string operation = Console.ReadLine();

            switch(operation)
            {
                case "+":
                   return Add(ref operation1, ref operation2);
                    break;
                case "-":
                   return Substraction(ref operation1, ref operation2);
                    break;
                case "*":
                   return Multiplication(ref operation1, ref operation2);
                    break;
                case "/":
                   return Division(ref operation1, ref operation2);
                    break;
                default:
                    return -1;
                    break;
            }
        }
        //--------------------------------------------------------------------------------------
        #endregion

        // Task 3
        #region
        const double USD = 36.94;

        double sumOfMoney;
        //------------------------------------------------

        public Program(double sum)
        {
            this.sumOfMoney = sum;
        }
        //------------------------------------------------

        public double UAHtoUSD()
        {
            return sumOfMoney / USD;
        }
        //------------------------------------------------
        #endregion

        static void Main(string[] args)
        {
            //-----------------------------------------------------------------

            // Additional Task

            //int sum = 0;
            //Console.WriteLine(CalculateAverage(ref sum, 7, 10));

            //-----------------------------------------------------------------

            // Task 2

            //Program prog = new Program(30, 10);
            //Console.WriteLine(prog.MenuOfOperations());

            //-----------------------------------------------------------------

            // Task 3

            //Program prog = new Program(200);
            //Console.WriteLine(Math.Round(prog.UAHtoUSD(), 2));

            //----------------------------------------------------------------- 
        }
    }
}
