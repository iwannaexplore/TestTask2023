using CalculateTheArea.Interfaces;

namespace CalculateTheArea.Models;

public class Circle : ICalculateArea
{
 private double radius;
 public Circle(double radius)
 {
  this.Radius = radius;
 }
 public double Radius
 {
  get
  {
   return radius;
  }
  set
  {
   if (value <= 0)
   {
    throw new ArgumentException("The radius must be greater than 0");
   }
   radius = value;
  }
 }
 //Area of cirlce = PI * r^2
 //в теории можно использовать сдесь паттерн Стратегия, который будет использовать разные алгоритмы расчета площади
 public double CalculateArea()
 {
  return Math.PI * Math.Pow(radius, 2);
 }
}
