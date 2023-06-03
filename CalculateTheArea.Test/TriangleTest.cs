using CalculateTheArea.Models;

namespace CalculateTheArea.Test;

public class TriangleTest
{
 //if radius is 0
 //if radius is negative
 //if any triangle side is negative
 [Test]
 public void TriangleConstructor_Create3TrianglesWithOneSideLessThan0_3Exceptions()
 {
  //Arrange
  //Act
  //Assert
  Assert.Throws<ArgumentException>(() =>
  {
   Triangle triangle1 = new Triangle(1, 2, -3);
  });
  Assert.Throws<ArgumentException>(() =>
  {
   Triangle triangle2 = new Triangle(1, -2, 3);
  });
  Assert.Throws<ArgumentException>(() =>
  {
   Triangle triangle3 = new Triangle(-1, 2, 3);
  });
 }
 [Test]
 public void CheckIfTriangleIsPossible_Create3TrianglesWithAllCorrectSides_3TrianglesWithoutException()
 {
  //Arrange
  //Act
  //Assert
  Assert.DoesNotThrow(() =>
  {
   Triangle triangle1 = new Triangle(5, 5, 5);
  });
  Assert.DoesNotThrow(() =>
  {
   Triangle triangle2 = new Triangle(6, 6, 6);
  });
  Assert.DoesNotThrow(() =>
  {
   Triangle triangle3 = new Triangle(3, 5, 6);
  });
 }
 [Test]
 public void CheckIfTriangleIsPossible_Create3TrianglesWithEqualSides_3TrianglesWithEqualSides()
 {
  //Arrange
  Triangle triangle1 = new Triangle(5, 5, 5);
  Triangle triangle2 = new Triangle(6, 6, 6);
  Triangle triangle3 = new Triangle(3, 3, 3);
  //Act
  //Assert
  Assert.AreEqual(triangle1.SideA, triangle1.SideB);
  Assert.AreEqual(triangle1.SideB, triangle1.SideC);
  Assert.AreEqual(triangle1.SideC, triangle1.SideA);
  Assert.AreEqual(triangle2.SideA, triangle2.SideB);
  Assert.AreEqual(triangle2.SideB, triangle2.SideC);
  Assert.AreEqual(triangle2.SideC, triangle2.SideA);
  Assert.AreEqual(triangle3.SideA, triangle3.SideB);
  Assert.AreEqual(triangle3.SideB, triangle3.SideC);
  Assert.AreEqual(triangle3.SideC, triangle3.SideA);
 }
 [Test]
 public void IsRectangular_CreateRectangularTriangle_TriangleIsRectangular()
 {
  //Arrange
  Triangle triangle = new Triangle(3, 4, 5);
  //Act
  //Assert
  Assert.IsTrue(triangle.IsRectangular());
 }
 [Test]
 public void IsRectangular_CreateNotRectangularTriangle_TriangleIsNotRectangular()
 {
  //Arrange
  Triangle triangle = new Triangle(3, 4, 6);
  //Act
  //Assert
  Assert.IsFalse(triangle.IsRectangular());
 }
 [Test]
 public void CalculateArea_Create3TrianglesWithCorrectSides_3AreasValuesAreEqualToPredefined()
 {
  //Arrange
  Triangle triangle1 = new Triangle(5, 5, 5);
  Triangle triangle2 = new Triangle(3, 4, 5);
  Triangle triangle3 = new Triangle(3, 6, 6);
  //Act
  //Assert
  Assert.AreEqual(10.825317547305483, triangle1.CalculateArea());
  Assert.AreEqual(6, triangle2.CalculateArea());
  Assert.AreEqual(8.7142125289666872, triangle3.CalculateArea());
 }


}
