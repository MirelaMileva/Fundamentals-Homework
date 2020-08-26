using System;

namespace Fund_DataTypesAndVariables_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());
            int numFour = int.Parse(Console.ReadLine());
            int result = ((numOne + numTwo) / numThree) * numFour;

            Console.WriteLine(result);

        }
    }
}
