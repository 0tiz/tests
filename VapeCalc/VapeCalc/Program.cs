using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VapeCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            double liquidAmount = GetInt($"Wieviel ml möchtest du am Ende rausbekommen? : ");
            double liquidPercent = GetInt($"Wieviel Prozent?: ");
            double liquidName = GetString($"Gib nen Namen ein: ")
        }




        private static string GetString(string text)
        {
            Console.WriteLine(text);
            return string (Console.ReadLine());
        }


        private static double GetInt(string text)
        {
            Console.WriteLine(text);
            return double.Parse(Console.ReadLine());
        }
    }
}
