namespace FiguresLibrary
{
    public class Triangle: Shape
    {
        public double side { get; }
        public double height { get; }
        public Triangle(double side, double height) : base("Triangle")
        {
            this.side = side;
            this.height = height;
        }

        public override double GetArea()
        {
            return 0.5 * side * height;
        }
    }
}
