using CalculateTheArea.Interfaces;

namespace CalculateTheArea.Models;

public class Triangle : ICalculateArea, IRectangular
{
 private double _sideA;
 private double _sideB;
 private double _sideC;
 public double SideA
 {
  get
  {
   return _sideA;
  }
  set
  {
   if (value <= 0)
    throw new ArgumentException("Can't create triangle. SideA must be greater than 0");
   _sideA = value;
  }
 }
 public double SideB
 {
  get
  {
   return _sideB;
  }
  set
  {
   if (value <= 0)
    throw new ArgumentException("Can't create triangle. SideB must be greater than 0");
   _sideB = value;
  }
 }
 public double SideC
 {
  get
  {
   return _sideC;
  }
  set
  {
   if (value <= 0)
    throw new ArgumentException("Can't create triangle. SideC must be greater than 0");
   _sideC = value;
  }
 }
 public Triangle(double sideA, double sideB, double sideC)
 {
  SideA = sideA;
  SideB = sideB;
  SideC = sideC;
  if (!CheckIfTriangleIsPossible())
  {
   throw new ArgumentException("Can't create triangle. Sum of two sides must be greater than third side");
  }
 }
 private bool CheckIfTriangleIsPossible()
 {
  return CompareSumOfTwoSidesWithThird(_sideA, _sideB, _sideC) &&
   CompareSumOfTwoSidesWithThird(_sideA, _sideC, _sideB) &&
   CompareSumOfTwoSidesWithThird(_sideB, _sideC, _sideA);
 }
 private bool CompareSumOfTwoSidesWithThird(double firstSide, double secondSide, double thirdSide)
 {
  return firstSide + secondSide > thirdSide;
 }
 //p=(a+b+c)/2, S=sqrt(p(p-a)(p-b)(p-c))
 //в теории можно использовать сдесь паттерн Стратегия, который будет использовать разные алгоритмы расчета площади
 public double CalculateArea()
 {
  var p = (_sideA + _sideB + _sideC) / 2;
  return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
 }
 // Теорема пифагора: c^2=a^2+b^2
 public bool IsRectangular()
 {
  var orderedSides = new double[] {_sideA, _sideB, _sideC}.OrderDescending().ToArray();
  return Math.Abs(Math.Pow(orderedSides[0], 2) - (Math.Pow(orderedSides[1], 2) + Math.Pow(orderedSides[2], 2))) < 1;
 }
}
