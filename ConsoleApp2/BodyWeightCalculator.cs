using System;

namespace ConsoleApp2
{
    public class BodyWeightCalculator
    {
        public int Height { get; set; }
        public char Gender { get; set; }

        public double CalculateIdealBodyWeight()
        {
            switch (Gender)
            {
                case 'M':
                    return (Height - 100) - ((Height - 150) / 4);
                case 'F':
                    return (Height - 100) - ((Height - 150) / 2);
                default:
                    return 0;
            }
        }
    }
}