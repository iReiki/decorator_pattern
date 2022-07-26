using System;

namespace TestDecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine();
                Console.WriteLine("Circle and Rectangle with normal border init");

                IShape circle = new Circle();
                IShape rectangle = new Rectangle();
                Console.WriteLine(circle.Draw());
                Console.WriteLine(rectangle.Draw());

                Console.WriteLine();
                Console.WriteLine("Apply Decorators");
                IShape redCircle = new RedShapeDecorator(circle);
                IShape blueRectangle = new BlueShapeDecorator(rectangle);
                IShape fillCircle = new FillShapeDecorator(redCircle);

                Console.WriteLine();
                Console.WriteLine(redCircle.Draw());

                Console.WriteLine();
                Console.WriteLine(blueRectangle.Draw());

                Console.WriteLine();
                Console.WriteLine(fillCircle.Draw());

                Console.WriteLine();
        }
    }
}