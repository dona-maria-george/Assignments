using System;

namespace Calculator
{
    class Addition
    {
        static void Main(string[] args)
        {
            //declaration
            Decimal a;
            Decimal b;
            while (true)
            {
                //entering input
                Console.Write("Enter first number: ");
                a = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Enter second number: ");
                b = Convert.ToDecimal(Console.ReadLine());


                //enetring operation
                Console.WriteLine("Available operations: " +
                    "Addition-A, " +
                    "Substraction-S, " +
                    "Multiplication-M, " +
                    "Division-D,  " +
                    "Exit-E");
                char opn;
                Console.Write("Enter operation to be performed ");
                opn = Convert.ToChar(Console.ReadLine());

                //switch

                switch (opn)
                {
                    case 'A':
                        Console.WriteLine(a + b);
                        break;
                    case 'S':
                        Console.WriteLine(a - b);
                        break;
                    case 'M':
                        Console.WriteLine(a * b);
                        break;
                    case 'D':
                        //exception divide by zero
                        try
                        {
                            Console.WriteLine(a / b);
                        }
                        catch (DivideByZeroException ex)
                        {

                            Console.WriteLine("Cannot divide by zero. Please try again.");
                        }
                        Console.Write(a / b);
                        break;
                    case 'E':
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid case");
                        break;


                }
            }


        }
    }
}
