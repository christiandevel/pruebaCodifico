using CalculadoraAreas.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoraAreasTestRectangulo
{
    [TestClass]
    public class RectanguloTest
    {
        [TestMethod]
        public void CalcularArea_RectanguloValido_ResultadoCorrecto()
        {
            // Arrange
            Rectangulo rectangulo = new Rectangulo { Base = 5, Altura = 4 };

            // Act
            double area = rectangulo.CalcularArea();

            // Assert
            Assert.AreEqual(20, area);
        }
    }
}