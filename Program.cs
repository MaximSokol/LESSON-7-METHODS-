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

        // Task 4
        #region
        public static string IsPositiveAndNegative(int number)
        {
            if (number < 0)
                return $"Negative number: {number}";
            else
                return $"Positive number: {number}";
        }
        //------------------------------------------------------------------

        public static void IsPrime(int number)
        {
            int counter = 0;

            for(int i = 2; i < (number/2+1); i++)
            {
                if(number % i == 0)
                {
                    counter++;
                    break;
                }
            }

            if(counter == 0)
            {
                Console.WriteLine($"Number: {number}");
            }
        }
        //------------------------------------------------------------------

        public static void DivideSomeNumbers()
        {
            int[] numbers = { 2, 3, 5, 6, 9 };
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[0] % 2 == 0 && numbers[1] % 3 == 0 && numbers[2] % 5 == 0
                    && numbers[3] % 6 == 0 && numbers[4] % 9 == 0)
                {
                    int elem = numbers[i];
                    Console.WriteLine("The numbers are devide without reminder:\t" + elem);
                }
                else
                {
                    int elem = numbers[i];
                    Console.WriteLine("The numbers aren't devide without reminder:\t" + elem);
                }
            }
        }
        //-----------------------------------------------------------------
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

            // Task 4

            //Console.WriteLine(IsPositiveAndNegative(10));

            //Console.Write("Enter the number ->\t");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 2; i < number + 1; i++)
            //{
            //    IsPrime(i);
            //}

            //DivideSomeNumbers();

            //-----------------------------------------------------------------
        }
    }
}
