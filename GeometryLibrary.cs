namespace GeometryLibrary
{
    public interface IShape
    {
        double CalculateArea();
    }

    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }

    public class Triangle : IShape
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public double CalculateArea()
        {
            double semiPerimeter = (side1 + side2 + side3) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));
        }

        public bool IsRightTriangle()
        {
            double a2 = side1 * side1;
            double b2 = side2 * side2;
            double c2 = side3 * side3;

            return (a2 == b2 + c2) || (b2 == a2 + c2) || (c2 == a2 + b2);
        }
    }

    public class ShapeCalculator
    {
        public static double CalculateArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}