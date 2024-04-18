using ConsoleApp05.Entidades;
namespace ConsoleApp05.Testing
{

    [TestClass]
    public class PuntoTest
    {
        [TestMethod]
        public void TestDistanciaAlOrigen()
        {
            Punto punto = new Punto(3, 4);
            Assert.AreEqual(5, punto.DistanciaAlOrigen());
        }

        [TestMethod]
        public void TestDistanciaOtroPunto()
        {
            Punto punto1 = new Punto(1, 2);
            Punto punto2 = new Punto(4, 6);
            Assert.AreEqual(5, punto1.DistanciaOtroPunto(punto2));
        }

        [TestMethod]
        [DataRow(3, 4, 1)]
        [DataRow(-3, 4, 2)]
        [DataRow(-3, -4, 3)]
        [DataRow(3, -4, 4)]
        [DataRow(0, 0, 0)]
        public void TestCuadrante(double x, double y, int expectedCuadrante)
        {
            Punto punto = new Punto(x, y);
            Assert.AreEqual(expectedCuadrante, punto.Cuadrante());
        }

        [TestMethod]
        public void TestCuadrante()
        {
            Punto punto1 = new Punto(3, 4);
            Punto punto2 = new Punto(-3, 4);
            Punto punto3 = new Punto(-3, -4);
            Punto punto4 = new Punto(3, -4);
            Punto punto5 = new Punto(0, 0);

            Assert.AreEqual(1, punto1.Cuadrante());
            Assert.AreEqual(2, punto2.Cuadrante());
            Assert.AreEqual(3, punto3.Cuadrante());
            Assert.AreEqual(4, punto4.Cuadrante());
            Assert.AreEqual(0, punto5.Cuadrante());
        }

        [TestMethod]
        public void TestCoordenadasPolares()
        {
            Punto punto = new Punto(3, 4);
            var coordenadasPolares = punto.CoordenadasPolares();
            Assert.AreEqual(5, coordenadasPolares.r);
            Assert.AreEqual(Math.Atan2(4, 3), coordenadasPolares.theta);
        }

        [TestMethod]
        public void TestMoverArriba()
        {
            Punto punto = new Punto(3, 4);
            punto.MoverArriba(2);
            Assert.AreEqual(6, punto.Y);
        }

        [TestMethod]
        public void TestMoverAbajo()
        {
            Punto punto = new Punto(3, 4);
            punto.MoverAbajo(2);
            Assert.AreEqual(2, punto.Y);
        }

        [TestMethod]
        public void TestMoverIzquierda()
        {
            Punto punto = new Punto(3, 4);
            punto.MoverIzquierda(2);
            Assert.AreEqual(1, punto.X);
        }

        [TestMethod]
        public void TestMoverDerecha()
        {
            Punto punto = new Punto(3, 4);
            punto.MoverDerecha(2);
            Assert.AreEqual(5, punto.X);
        }

        [TestMethod]
        public void TestMover()
        {
            Punto punto = new Punto(3, 4);
            punto.Mover(2, -1);
            Assert.AreEqual(5, punto.X);
            Assert.AreEqual(3, punto.Y);
        }

        [TestMethod]
        public void TestEsColinealCon()
        {
            Punto punto1 = new Punto(1, 1);
            Punto punto2 = new Punto(2, 2);
            Punto punto3 = new Punto(3, 3);
            Assert.IsTrue(punto1.EsColinealCon(punto2, punto3));
        }
    }
}