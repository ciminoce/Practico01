using ConsoleApp01.Entidades;

namespace ConsoleApp01.Test
{
    [TestClass]
    public class TestCuadrado
    {
        [TestMethod]
        public void CalcularPerimetro_DeberiaCalcularCorrectamente()
        {
            // Arrange
            double lado = 5;
            Cuadrado cuadrado = new Cuadrado(lado);

            // Act
            double perimetro = cuadrado.CalcularPerimetro();

            // Assert
            Assert.AreEqual(20, perimetro);
        }

        [TestMethod]
        public void CalcularArea_DeberiaCalcularCorrectamente()
        {
            // Arrange
            double lado = 5;
            Cuadrado cuadrado = new Cuadrado(lado);

            // Act
            double area = cuadrado.CalcularArea();

            // Assert
            Assert.AreEqual(25, area);
        }

        [TestMethod]
        public void ImprimirInformacion_DeberiaRetornarInformacionCorrecta()
        {
            // Arrange
            double lado = 5;
            Cuadrado cuadrado = new Cuadrado(lado);

            // Act
            string informacion = cuadrado.ImprimirInformacion();

            // Assert
            StringAssert.Contains("Cuadrado con lado de 5", informacion);
            StringAssert.Contains("Perímetro: 20", informacion);
            StringAssert.Contains("Área: 25", informacion);
        }

        [TestMethod]
        public void EsCuadradoPerfecto_DeberiaRetornarVerdaderoParaCuadradoPerfecto()
        {
            // Arrange
            double lado = 4; // 4 * 4 = 16 (cuadrado perfecto)
            Cuadrado cuadrado = new Cuadrado(lado);

            // Act
            bool esCuadradoPerfecto = cuadrado.EsCuadradoPerfecto();

            // Assert
            Assert.IsTrue(esCuadradoPerfecto);
        }

        [TestMethod]
        public void EsCuadradoPerfecto_DeberiaRetornarFalsoParaCuadradoNoPerfecto()
        {
            // Arrange
            double lado = 5.5; // 5 * 5 = 25 (no cuadrado perfecto)
            Cuadrado cuadrado = new Cuadrado(lado);

            // Act
            bool esCuadradoPerfecto = cuadrado.EsCuadradoPerfecto();

            // Assert
            Assert.IsFalse(esCuadradoPerfecto);
        }

        [TestMethod]
        public void Lado_DeberiaPermitirModificarValorCorrectamente()
        {
            // Arrange
            double ladoInicial = 5;
            Cuadrado cuadrado = new Cuadrado(ladoInicial);

            // Act
            cuadrado.Lado = 7;

            // Assert
            Assert.AreEqual(7, cuadrado.Lado);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void Lado_DeberiaLanzarExcepcionParaValorMenorIgualACero()
        {
            // Arrange
            Cuadrado cuadrado = new Cuadrado(5);

            // Act
            cuadrado.Lado = 0;
        }

        [TestMethod]
        public void TestCambiarTamañoOK()
        {
            Cuadrado cuadrado = new Cuadrado(5);
            cuadrado.CambiarTamaño(2);
            Assert.AreEqual(10, cuadrado.Lado);
        }
        [TestMethod]
        [ExpectedException (typeof(System.ArgumentException))]
        public void TestCambiarTamañoExcepcion()
        {
            Cuadrado cuadrado = new Cuadrado(5);
            cuadrado.CambiarTamaño(-2);
            
        }

        [TestMethod]
        public void TestEsCuadradoPerfecto()
        {
            Cuadrado cuadrado1 = new Cuadrado(4);
            Cuadrado cuadrado2 = new Cuadrado(5);
            Assert.IsTrue(cuadrado1.EsCuadradoPerfecto());
            Assert.IsFalse(cuadrado2.EsCuadradoPerfecto());
        }

        [TestMethod]
        public void TestObtenerDiagonal()
        {
            Cuadrado cuadrado = new Cuadrado(5);
            Assert.AreEqual(Math.Sqrt(50), cuadrado.ObtenerDiagonal());
        }
    }
}