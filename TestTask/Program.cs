using CalculateTheArea.Models;
var triangle = new Triangle(3,3,3);
var triangleArea = triangle.CalculateArea();
var isTriangleRectangular = triangle.IsRectangular();
Console.WriteLine($"Triangle area: {triangleArea}");
Console.WriteLine($"Is triangle rectangular: {isTriangleRectangular}");

var circle = new Circle(5);
var circleArea = circle.CalculateArea();
Console.WriteLine($"Circle area: {circleArea}");