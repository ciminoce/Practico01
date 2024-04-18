using ConsoleApp03.Entidades;

namespace ConsoleApp03.Testing
{
    [TestClass]
    public class RectanguloTest
    {
        [TestMethod]
        public void TestCalcularPerimetro()
        {
            Rectangulo rectangulo = new Rectangulo(4, 6);
            Assert.AreEqual(20, rectangulo.CalcularPerimetro());
        }

        [TestMethod]
        public void TestCalcularArea()
        {
            Rectangulo rectangulo = new Rectangulo(4, 6);
            Assert.AreEqual(24, rectangulo.CalcularArea());
        }

        [TestMethod]
        public void TestPuntoEstaDentro()
        {
            Rectangulo rectangulo = new Rectangulo(4, 6);
            Assert.IsTrue(rectangulo.PuntoEstaDentro(2, 3));
            Assert.IsFalse(rectangulo.PuntoEstaDentro(5, 7));
        }

        [TestMethod]
        public void TestCalcularDiagonal()
        {
            Rectangulo rectangulo = new Rectangulo(3, 4);
            Assert.AreEqual(5, rectangulo.CalcularDiagonal());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConstructor_LongitudNegativa()
        {
            Rectangulo rectangulo = new Rectangulo(-4, 6);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConstructor_AnchuraCero()
        {
            Rectangulo rectangulo = new Rectangulo(4, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConstructor_LongitudIgualAnchura()
        {
            Rectangulo rectangulo = new Rectangulo(4, 4);
        }

        [TestMethod]
        public void TestPropiedades_LongitudYAnchura()
        {
            Rectangulo rectangulo = new Rectangulo(4, 6);
            rectangulo.Longitud = 8;
            rectangulo.Anchura = 10;
            Assert.AreEqual(8, rectangulo.Longitud);
            Assert.AreEqual(10, rectangulo.Anchura);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPropiedades_LongitudNegativa()
        {
            Rectangulo rectangulo = new Rectangulo(4, 6);
            rectangulo.Longitud = -8;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPropiedades_AnchuraCero()
        {
            Rectangulo rectangulo = new Rectangulo(4, 6);
            rectangulo.Anchura = 0;
        }
    }
}