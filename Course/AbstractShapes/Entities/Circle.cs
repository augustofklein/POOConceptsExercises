using AbstractShapes.Entities.Enums;

namespace AbstractShapes.Entities
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        /*
         * Não é necessário adicionar o comando virtual, pois
         * o bastract o implementa automaticamente.
         */
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}

