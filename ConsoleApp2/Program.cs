using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test Case 1: Female
            TestCalculateIdealBodyWeight(176, 'F', 63);

            // Test Case 2: Male
            TestCalculateIdealBodyWeight(170, 'M', 65);

            // Test Case 3: Invalid Gender
            TestCalculateIdealBodyWeight(170, 'z', 0); 
        }

        static void TestCalculateIdealBodyWeight(int height, char gender, double expectedWeight)
        {
            BodyWeightCalculator calculator = new BodyWeightCalculator()
            {
                Height = height,
                Gender = gender
            };
            double actualWeight = calculator.CalculateIdealBodyWeight();

            if (actualWeight == expectedWeight)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Test Passed: Calculated ideal body weight is correct.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Test Failed: Expected ideal body weight: {expectedWeight}, Actual: {actualWeight}");
            }

            Console.ResetColor();
        }
    }
}