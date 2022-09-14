using System;
namespace Operators_Excercises;

internal class Methods
{
    public static void AreaOfCircle()
    { 
    Console.WriteLine("Please input the radius of your circle.");
    var radius = double.Parse(Console.ReadLine());

    double area = Math.PI * Math.Pow(radius, 2);

        Console.WriteLine($"The {radius} has an area of {area}.");
        Console.ReadLine();
    }
    
}