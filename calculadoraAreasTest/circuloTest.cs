using CalculadoraAreas.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoraAreasTestCirculo
{
    [TestClass]
    public class CirculoTest
    {
        [TestMethod]
        public void TestCalcularArea()
        {
            // Arrange
            double radio = 2;
            double expected = 12.56637; // El valor esperado se redondeó a 5 decimales

            Circulo circulo = new Circulo { Radio = radio };

            // Act
            double actual = circulo.CalcularArea();

            // Assert
            Assert.AreEqual(expected, actual, 0.00001, "El cálculo del área del círculo no es correcto");
        }
    }
}