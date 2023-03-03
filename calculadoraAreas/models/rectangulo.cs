using CalculadoraAreas.Utils;

namespace CalculadoraAreas.Models
{
    public class Rectangulo : FiguraGeometrica
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public override double CalcularArea()
        {
            return Base * Altura;
        }
    }
}