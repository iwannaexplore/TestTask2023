using CalculateTheArea.Interfaces;

namespace CalculateTheArea.Models;

public class Triangle : ICalculateArea, IRectangular
{
 private double sideA;
 private double sideB;
 private double sideC;
 public double SideA
 {
  get
  {
   return sideA;
  }
  set
  {
   if (value <= 0)
    throw new ArgumentException("Can't create triangle. SideA must be greater than 0");
   sideA = value;
  }
 }
 public double SideB
 {
  get
  {
   return sideB;
  }
  set
  {
   if (value <= 0)
    throw new ArgumentException("Can't create triangle. SideB must be greater than 0");
   sideB = value;
  }
 }
 public double SideC
 {
  get
  {
   return sideC;
  }
  set
  {
   if (value <= 0)
    throw new ArgumentException("Can't create triangle. SideC must be greater than 0");
   sideC = value;
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
  return CompareSumOfTwoSidesWithThird(sideA, sideB, sideC) &&
   CompareSumOfTwoSidesWithThird(sideA, sideC, sideB) &&
   CompareSumOfTwoSidesWithThird(sideB, sideC, sideA);
 }
 private bool CompareSumOfTwoSidesWithThird(double firstSide, double secondSide, double thirdSide)
 {
  return firstSide + secondSide > thirdSide;
 }
 //p=(a+b+c)/2, S=sqrt(p(p-a)(p-b)(p-c))
 public double CalculateArea()
 {
  var p = (sideA + sideB + sideC) / 2;
  return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
 }
 // Теорема пифагора: c^2=a^2+b^2
 public bool IsRectangular()
 {
  var orderedSides = new double[] {sideA, sideB, sideC}.OrderDescending().ToArray();
  return Math.Abs(Math.Pow(orderedSides[0], 2) - (Math.Pow(orderedSides[1], 2) + Math.Pow(orderedSides[2], 2))) < 1;
 }
}
