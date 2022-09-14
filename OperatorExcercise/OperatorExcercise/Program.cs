// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using System.Reflection;
using Operators_Excercises;

namespace OperatorExcercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Excercise 1
            int a = 17;
            int b = 4;
            var quotient = a / b;
            var remainder = a % b;
            Console.WriteLine($"{a} /{b} is {quotient} remainder {remainder}");
            //Excercise 2 
            
            Methods.AreaOfCircle();
        }
    
    }
}
