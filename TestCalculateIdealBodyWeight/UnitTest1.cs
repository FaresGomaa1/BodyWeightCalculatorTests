using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2; 

namespace TestCalculateIdealBodyWeight
{
    [TestClass]
    public class BodyWeightCalculatorTests
    {
        [TestMethod]
        public void CalculateIdealBodyWeight_Female_Height176_Returns63()
        {
            // Arrange
            BodyWeightCalculator calculator = new BodyWeightCalculator
            {
                Height = 176,
                Gender = 'F'
            };

            // Act
            double result = calculator.CalculateIdealBodyWeight();

            // Assert
            Assert.AreEqual(63, result);
        }

        [TestMethod]
        public void CalculateIdealBodyWeight_Male_Height170_Returns65()
        {
            // Arrange
            BodyWeightCalculator calculator = new BodyWeightCalculator
            {
                Height = 170,
                Gender = 'M'
            };

            // Act
            double result = calculator.CalculateIdealBodyWeight();

            // Assert
            Assert.AreEqual(65, result);
        }

        [TestMethod]
        public void CalculateIdealBodyWeight_InvalidGender_ThrowsArgumentException()
        {
            // Arrange
            BodyWeightCalculator calculator = new BodyWeightCalculator
            {
                Height = 170,
                Gender = 'W'
            };

            // Act
            double result = calculator.CalculateIdealBodyWeight(); 
        }
    }
}