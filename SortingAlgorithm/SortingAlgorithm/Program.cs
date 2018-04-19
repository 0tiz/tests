using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] MyArray = new int[2] { 5,4 };
            int[] sortArray = GetArraySort(MyArray);

            Console.WriteLine(sortArray[1]);
           
        }
    private static int[] GetArraySort(int[] arrayInput)
        {
            int[] arrayCache = new int[arrayInput.Length];

            for(int i = 0; i < arrayInput[i]; i++)
            {
                if (arrayInput[i] < arrayCache[i])
                    arrayInput = arrayCache;
            }
            return arrayCache;
        }
    }
}
