// using System;

// abstract class Shape
// {
//     public abstract double Area();
// }

// class Rectangle : Shape
// {
//     private double length;
//     private double width;

//     public Rectangle(double length, double width)
//     {
//         this.length = length;
//         this.width = width;
//     }

//     public override double Area()
//     {
//         return length * width;
//     }
// }

// class Triangle : Shape
// {
//     private double baseValue;
//     private double height;

//     public Triangle(double baseValue, double height)
//     {
//         this.baseValue = baseValue;
//         this.height = height;
//     }

//     public override double Area()
//     {
//         return 0.5 * baseValue * height;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Shape shape1 = new Rectangle(8, 5);
//         Shape shape2 = new Triangle(6, 9);

//         Console.WriteLine("Rectangle Area = " + shape1.Area());
//         Console.WriteLine("Triangle Area = " + shape2.Area());
//     }
// }