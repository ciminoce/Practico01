using ConsoleApp02.Entidades;

namespace ConsoleApp02.Testing
{
    [TestClass]
    public class CircunferenciaTesting
    {
        public class CircunferenciaTest
        {
            [TestMethod]
            public void TestPerimetro()
            {
                Circunferencia circunferencia = new Circunferencia(5);
                Assert.AreEqual(2 * Math.PI * 5, circunferencia.CalcularPerimetro());
            }

            [TestMethod]
            public void TestArea()
            {
                Circunferencia circunferencia = new Circunferencia(5);
                Assert.AreEqual(Math.PI * Math.Pow(5, 2), circunferencia.CalcularArea());
            }

            [TestMethod]
            public void TestCambiarTamaño()
            {
                Circunferencia circunferencia = new Circunferencia(5);
                circunferencia.CambiarTamaño(2);
                Assert.AreEqual(10, circunferencia.Radio);
            }

            [TestMethod]
            public void TestPuntoDentro()
            {
                Circunferencia circunferencia = new Circunferencia(5);
                Assert.IsTrue(circunferencia.PuntoDentro(3, 4));
                Assert.IsFalse(circunferencia.PuntoDentro(10, 10));
            }
        }
    }
}