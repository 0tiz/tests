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
            int[] mustSort = new int[2] { 5,4 };
            int[] sortArray = GetArraySort(mustSort);

            
           
        }
    private static int[] GetArraySort(int[] arrayInput)
        {
            int[] array1 = arrayInput;
            int[] array2 = new int[arrayInput.Length];
            int[] array3 = new int[arrayInput.Length];
            int[] array4 = new int[arrayInput.Length];

            if (array1.Max > array2.Min)
                return array1;


            

        }
    }
}
