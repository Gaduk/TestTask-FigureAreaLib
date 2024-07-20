using System.Runtime.InteropServices;

namespace FigureAreaLib
{
    public abstract class Figure
    {
        protected float a;
        public Figure(float a)
        {
            this.a = a;
        }
        public abstract float FindArea();
    }

    public class Circle : Figure
    {
        public Circle(float r) : base(r) { }
        override public float FindArea()
        {
            return (float)(Math.PI * a * a);
        }
    }
    public class Triangle : Figure
    {
        private float _b;
        private float _c;
        public Triangle(float a, float b, float c) : base(a) 
        {
            _b = b;
            _c = c;
        }
        override public float FindArea()
        {
            float p = (a +_b + _c) / 2f;
            return (float)Math.Sqrt(p * (p - a) * (p - _b) * (p - _c));
        }
        public bool isRightAngled()
        {
            float max = Math.Max(a, _b);
            max = Math.Max(max, _c);
            float other1, other2;
            if (max == a)
            {
                other1 = _b;
                other2 = _c;
            }
            else if (max == _b)
            {
                other1 = a;
                other2 = _c;
            }
            else
            {
                other1 = a;
                other2 = _b;
            }
            return Math.Abs(max * max - (other1 * other1 + other2 * other2)) < 1e-5;
        }
    }
    
}