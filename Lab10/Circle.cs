using System;

namespace Lab10
{
    internal class Circle : Point
    {
        public Circle(Colors color, Statuses status)
            : base(color, status)
        {
            // Конструктор окружности вызывает конструктор точки
        }

        public double CalculArea(double radius)
        {
            double a = Math.PI * radius * radius;
            double b = Math.Round(a, 2);
            return b;
        }
    }
}
