// See https://aka.ms/new-console-template for more information

using System.ComponentModel;

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
            Console.WriteLine("What is the area of your circle?");
   
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine(AreaOfCircle(radius));
        }
        public static double AreaOfCircle(double radius)
        {
          
            var area = Math.PI * Math.Pow(radius,2);
            return area;
           
        }
    }
}