using System.Collections.ObjectModel;

namespace Figures
{
    public class Triangle : IFigure
    {
        private double[] _sidesLengths;
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides must be greater than 0");
            }
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("Sides do not format a triangle");
            }
            _sidesLengths = new double[3] { a, b, c };
            Array.Sort(_sidesLengths);
            SidesLengths = Array.AsReadOnly(_sidesLengths);
        }

        public ReadOnlyCollection<double> SidesLengths { get; }
        public bool IsRight { 
            get => Math.Pow(SidesLengths[0], 2) + Math.Pow(SidesLengths[1], 2) == Math.Pow(SidesLengths[2], 2); 
        }

        public double GetArea()
        {
            double semiPerimetr = SidesLengths.Sum() / 2;
            return Math.Sqrt(
                semiPerimetr * 
                (semiPerimetr - SidesLengths[0]) * 
                (semiPerimetr - SidesLengths[1]) * 
                (semiPerimetr - SidesLengths[2]));
        }
    }
}
