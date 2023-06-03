using CalculateTheArea.Models;

namespace CalculateTheArea.Test;

public class CircleTest
{
 [Test]
 public void RadiusProperty_CreateCircleWithCorrectRadius()
 {
  //Arrange
  Circle circle = new Circle(5);
  //Act
  //Assert
  Assert.AreEqual(5, circle.Radius);
 }
 [Test]
 public void RadiusProperty_CreateCircleWithInCorrectRadius_ThrowException()
 {
  //Arrange
  //Act
  //Assert
  Assert.Throws<ArgumentException>(() =>
  {
   Circle circle = new Circle(-5);
  });
  Assert.Throws<ArgumentException>(() =>
  {
   Circle circle = new Circle(0);
  });
 }
 [Test]
 public void CalculateArea_CreateCircleWithCorrectRadius_CorrectArea()
 {
  //Arrange
  Circle circle = new Circle(5);
  //Act
  //Assert
  Assert.AreEqual(78.539816339744831, circle.CalculateArea());
 }
}
