using ConsoleApp06.Entidades;
namespace ConsoleApp06.Testing
{

    [TestClass]
    public class PuntoCircunferenciaTest
    {
        [TestMethod]
        public void TestObtenerArea()
        {
            Punto centro = new Punto(0, 0);
            Circunferencia circunferencia = new Circunferencia(centro, 5);
            Assert.AreEqual(Math.PI * 25, circunferencia.ObtenerArea());
        }

        [TestMethod]
        public void TestObtenerPerimetro()
        {
            Punto centro = new Punto(0, 0);
            Circunferencia circunferencia = new Circunferencia(centro, 5);
            Assert.AreEqual(2 * Math.PI * 5, circunferencia.ObtenerPerimetro());
        }

        [TestMethod]
        public void TestPuntoEstaDentro()
        {
            Punto centro = new Punto(0, 0);
            Circunferencia circunferencia = new Circunferencia(centro, 5);
            Punto puntoDentro = new Punto(3, 4);
            Punto puntoFuera = new Punto(8, 8);
            Assert.IsTrue(circunferencia.PuntoEstaDentro(puntoDentro));
            Assert.IsFalse(circunferencia.PuntoEstaDentro(puntoFuera));
        }

        [TestMethod]
        public void TestEstaContenidaEn()
        {
            Punto centro1 = new Punto(0, 0);
            Punto centro2 = new Punto(3, 0);
            Circunferencia circunferencia1 = new Circunferencia(centro1, 2);
            Circunferencia circunferencia2 = new Circunferencia(centro2, 5);
            Assert.IsTrue(circunferencia1.EstaContenidaEn(circunferencia2));
        }

        [TestMethod]
        public void TestEstaContenidaEn_NoContenido()
        {
            Punto centro1 = new Punto(0, 0);
            Punto centro2 = new Punto(8, 0); // Asegurémonos de que las circunferencias no se solapen
            Circunferencia circunferencia1 = new Circunferencia(centro1, 2);
            Circunferencia circunferencia2 = new Circunferencia(centro2, 5);
            Assert.IsFalse(circunferencia1.EstaContenidaEn(circunferencia2));
        }

        [TestMethod]
        public void TestObtenerEcuacionGeneral()
        {

            Punto centro = new Punto(3, -4);
            Circunferencia circunferencia = new Circunferencia(centro, 5);
            Assert.AreEqual("x² + y² + (-6)x + (-8)y + (-8) = 0", circunferencia.ObtenerEcuacionGeneral());
        }
    }
}