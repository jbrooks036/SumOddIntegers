using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOddIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList= new List<int>() { 1, 2, 3 };

            List<int> intList2 = new List<int>{ 0, 1, 2, 3, 4, 5, 6, 7};

            int sum = 0;

            int listLength = intList.Count;

            for (int i=0; i <= listLength; i++)
            {
                if (intList[i] % 2 != 0)
                {
                    sum += intList[i];
                }
            }

            Console.WriteLine("Sum = " + sum);
            // return sum;

            /*
            List<int> list = new List<int>();
            list.Add(2);
            list.Add(3);
            list.Add(5);
            list.Add(7);
            */
        }
    }
}
