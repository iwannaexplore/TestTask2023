using CalculateTheArea.Interfaces;
using CalculateTheArea.Models;
var triangle = new Triangle(3,3,3);
var triangleArea = triangle.CalculateArea();
var isTriangleRectangular = triangle.IsRectangular();
Console.WriteLine($"Triangle area: {triangleArea}");
Console.WriteLine($"Is triangle rectangular: {isTriangleRectangular}");

var circle = new Circle(5);
var circleArea = circle.CalculateArea();
Console.WriteLine($"Circle area: {circleArea}");

var resultOfUsingCompileTimeCalculation = MethodThatCalculateAreaInCompileTime(triangle);
if (Math.Abs(resultOfUsingCompileTimeCalculation - triangleArea) < 1)
{
    Console.WriteLine("Compile time calculation is correct");
}
else
{
    Console.WriteLine("Compile time calculation is not correct");
}

static double MethodThatCalculateAreaInCompileTime(ICalculateArea figure)
{
    return figure.CalculateArea();
}