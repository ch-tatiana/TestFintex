using System;

public static class Geometry
{
    public static double CircleSquare(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    public static double TriangleSquare(double a, double b, double c)
    {
        if (!PossibleFormTriangle(a, b, c))
        {
            throw new ArgumentException("Треугольник не существует");
        }

        double s = (a + b + c) / 2; 
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

    public static double SphereVolume(double radius)
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
    }


    public static bool PossibleFormTriangle(double a, double b, double c)
    {
        return (a + b > c) && (a + c > b) && (b + c > a);
    }
}

class Program
{
    static void Main()
    {
        //тестовые значения
        double circleRadius = 5;
        double triangleA = 3, triangleB = 4, triangleC = 5;
        double sphereRadius = 6;

        Console.WriteLine("Площадь круга радиусом {0} равна: {1}", circleRadius, Geometry.CircleSquare(circleRadius));
        Console.WriteLine("Площадь треугольника со сторонами {0}, {1}, {2} равна: {3}", triangleA, triangleB, triangleC, Geometry.TriangleSquare(triangleA, triangleB, triangleC));
        Console.WriteLine("Объём шара радиусом {0} равен: {1}", sphereRadius, Geometry.SphereVolume(sphereRadius));
        bool possibleFormTriangle = Geometry.PossibleFormTriangle(triangleA, triangleB, triangleC);
        Console.WriteLine("Можно ли построить треугольник со сторонами {0}, {1}, {2}? {3}", triangleA, triangleB, triangleC, possibleFormTriangle ? "Да" : "Нет");
    }
}