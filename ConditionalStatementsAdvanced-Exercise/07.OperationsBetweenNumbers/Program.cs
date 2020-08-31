using System;

namespace _07.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            string operatorSign = Console.ReadLine();
            double result = 0;
            bool zeroDevizion = false;
            if (num2 == 0)
            {
                zeroDevizion = true;
            }

            switch (operatorSign)
            {
                case "+":
                    result = num1 + num2;
                    break;

                case "-":
                    result = num1 - num2;
                    break;

                case "*":
                    result = num1 * num2;
                    break;

                case "/":
                    if (zeroDevizion)
                    {
                        
                    }
                    else
                    {
                        result = 1.0 * num1 / num2;
                    }
                    break;

                case "%":
                    if (zeroDevizion)
                    {

                    }
                    else
                    {
                        result = num1 % num2;
                    }
                    break;
                    
            }

            if (operatorSign == "+" || operatorSign == "-" || operatorSign == "*")
            {
                string evenOrOdd = "";
                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                else
                {
                    evenOrOdd = "odd";
                }
                Console.WriteLine($"{num1} {operatorSign} {num2} = {result} - {evenOrOdd}");
            }

            else if (zeroDevizion)
            {
                Console.WriteLine($"Cannot divide {num1} by zero");
            }

            else if (operatorSign == "%")
            {
                Console.WriteLine($"{ num1} {operatorSign} {num2} = {result}");
            }

            
            else 
            {
                Console.WriteLine($"{num1} {operatorSign} {num2} = {result:f2}");
            }
        }
    }
}
