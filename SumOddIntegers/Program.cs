using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// C# Program that sums all the odd members of a list of integers
namespace SumOddIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList= new List<int>() { 0, 2, 13, 3, 42, 6, 71, 0, -1, -2, -3};

            int sum = 0;

            int listLength = intList.Count;

            for (int i=0; i < listLength; i++)
            {
                if (intList[i] % 2 != 0)
                {
                    System.Console.WriteLine("i = " + i);
                    sum += intList[i];
                    System.Console.WriteLine("Sum = " + sum);
                }
            }

            System.Console.WriteLine("Sum = " + sum);
            System.Console.WriteLine("Press any key to exit...");
            System.Console.ReadKey();
            
        }
    }
}
