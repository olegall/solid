using System;

namespace Liskov
{
    class Stackoverflow
    {
        public class Color { }

        public class Circle
        {
            private int radius;

            public Circle(int radius)
            {
                if (radius <= 0) // эта проверка чинит принцип Лисков
                {
                    throw new Exception("Radius should be >= 0");
                }
                this.radius = radius;
            }

            public virtual int getRadius()
            {
                return this.radius;
            }
        }

        public class ColoredCircle : Circle
        {
            private Color color; // defined elsewhere

            public ColoredCircle(int radius, Color color): base(radius)
            {
                //super(radius);
                this.color = color;
            }

            public Color getColor()
            {
                return this.color;
            }
        }

        public class Square : Circle // нарушение принципа Лисков. ошибка только в рантайме
        {
            private int sideSize;

            public Square(int sideSize) : base(0)
            {
                //super(0);
                this.sideSize = sideSize;
            }

            public override int getRadius()
            {
                return -1; // I'm a square, I don't care
            }

            public int getSideSize()
            {
                return this.sideSize;
            }
        }
    }
}
