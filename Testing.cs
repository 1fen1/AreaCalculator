using GeometryLibrary;

namespace ClientApplication
{
    class Testing
    {
        static void Main(string[] args)
        {
            // Создание объекта круга и вычисление его площади
            IShape circle = new Circle(5);
            double circleArea = ShapeCalculator.CalculateArea(circle);
            Console.WriteLine($"Площадь круга: {circleArea}");

            // Создание объекта треугольника и вычисление его площади
            IShape triangle = new Triangle(3, 4, 5);
            double triangleArea = ShapeCalculator.CalculateArea(triangle);
            Console.WriteLine($"Площадь треугольника: {triangleArea}");

            // Проверка, является ли треугольник прямоугольным
            Triangle triangleObj = (Triangle)triangle;
            bool isRightTriangle = triangleObj.IsRightTriangle();
            Console.WriteLine($"Треугольник является прямоугольным: {isRightTriangle}");
        }
    }
}