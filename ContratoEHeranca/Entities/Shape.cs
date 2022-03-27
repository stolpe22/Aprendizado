using ContratoEHeranca.Enums;

namespace ContratoEHeranca.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
