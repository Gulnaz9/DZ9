

namespace Lab10
{
    internal class Rectangle : Point
    {
        public Rectangle(Colors color, Statuses status)
            : base(color, status)
        {

        }
        public double CalculArea(double length, double width)
        {
            return length * width;
        }
    }
}
