using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myarray = new int[3] { 10, 5, 6 };
            int maxFromArray = MaxArray(myarray);
            Console.WriteLine(maxFromArray);
            
        }



        private static int MaxArray(int[] array)
        { int maxValue = 0;
            foreach (int element in array)
            {
                if (element > maxValue)
                    maxValue = element;
            

            }
            //Example 2
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                    maxValue = array[i];
            }

            return maxValue;
        } 
    }
}
