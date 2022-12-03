namespace Figures
{
    public static class FiguresUtil
    {
        public static double GetCircleAreaByRadius(double radius)
        {
            return new Circle(radius).GetArea();
        }

        public static double GetTriangleAreaBySides(double a, double b, double c)
        {
            return new Triangle(a, b, c).GetArea();
        }
    }
}
