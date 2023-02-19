using AbstractShapes.Entities.Enums;

namespace AbstractShapes.Entities
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }

        /*
         * Não é necessário adicionar o comando virtual, pois
         * o bastract o implementa automaticamente.
         */
        public override double Area()
        {
            return Width * Height;
        }
    }
}

