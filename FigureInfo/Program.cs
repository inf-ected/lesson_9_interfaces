using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_9
{
    /*
     * Создать три независимых класса: Circle, Square, Triangle. 
     * У каждого из этих классов есть свой набор полей и методов, 
     * связанных с их особенностями, в том числе — характерный размер.
     * Для круга это, например, его радиус, для квадрата и равностороннего 
     * треугольника — длина его стороны. В каждый из классов необходимо 
     * гарантированно добавить методы, которые будут находить площадь (area) 
     * и периметр (perimeter) этих фигур. Сделать это при помощи интерфейса. 
     * 
namespace ИнтерфейсГеометрическихФигур
{
   interface IFigureInfo
   {
      double area();
      double perimeter();
   }
}
     */
    interface IFigureInfo
    {
        double area();
        double perimeter();
    }
    public class Circle : IFigureInfo
    {
        double radius;
        public Circle(double r) { radius = r; }
        public Circle() : this(0) { }

        public double area()
        {
            if (radius > 0) return Math.PI * radius * radius;
            throw new NotImplementedException();
        }

        public double perimeter()
        {
            if (radius > 0) return 2f * Math.PI * radius;
            throw new NotImplementedException();
        }
    }
    public class Square : IFigureInfo
    {
        double storona;
        public Square() : this(0) { }
        public Square(double x) { storona = x; }

        public double area()
        {
            if (storona > 0) return Math.Pow(storona, 2);
            throw new NotImplementedException();
        }

        public double perimeter()
        {
            if (storona > 0) return 4f * storona;
            throw new NotImplementedException();
        }
    }
    public class Triangle : IFigureInfo
    {
        double a, b, c;
        public Triangle(double a = 0, double b = 0, double c = 0)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double area()
        {
            if (a > 0 && b > 0 && c > 0)
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            throw new NotImplementedException();
        }

        public double perimeter()
        {
            if (a > 0 && b > 0 && c > 0)
            { return a + b + c; }
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IFigureInfo[] x =
            {
                new Circle(5.5),
                new Square(6.6),
                new Triangle(3,4,5)
            };

            foreach (var i in x)
                Console.WriteLine("Perimetr: " + i.perimeter() + " Area: " + i.area());

            Console.ReadKey();
        }
    }
}
