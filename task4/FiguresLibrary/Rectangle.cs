namespace FiguresLibrary
{
    public class Rectangle: Shape
    {
        public double width { get; }
        public double height { get; }
        public Rectangle(double width, double height) : base("Rectangle")
        {
            this.width = width;
            this.height = height;
        }

        public override double GetArea()
        {
            return width * height;
        }
    }
}
