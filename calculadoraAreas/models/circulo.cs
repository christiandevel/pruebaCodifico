using System;
using CalculadoraAreas.Utils;

namespace CalculadoraAreas.Models
{
    public class Circulo : FiguraGeometrica
    {
        public double Radio { get; set; }

        public override double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }
    }
}