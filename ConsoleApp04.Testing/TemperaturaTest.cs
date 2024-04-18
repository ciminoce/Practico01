using ConsoleApp04.Entidades;

namespace ConsoleApp04.Testing
{
    [TestClass]
    public class TemperaturaTest
    {
        [TestMethod]
        public void TestObtenerFahrenheit()
        {
            Temperatura temperatura = new Temperatura(0);
            Assert.AreEqual(32, temperatura.ObtenerFahrenheit());
        }

        [TestMethod]
        public void TestObtenerKelvin()
        {
            Temperatura temperatura = new Temperatura(0);
            Assert.AreEqual(273.15, temperatura.ObtenerKelvin());
        }

        [TestMethod]
        public void TestDiferenciaConCeroAbsoluto()
        {
            Temperatura temperatura = new Temperatura(0);
            Assert.AreEqual(273.15, temperatura.DiferenciaConCeroAbsoluto());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestConstructor_TemperaturaFueraDeRango()
        {
            Temperatura temperatura = new Temperatura(100);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConstructor_TemperaturaConMasDeUnDecimal()
        {
            Temperatura temperatura = new Temperatura(20.25);
        }

        [TestMethod]
        [DataRow('F',32, "Fahrenheit")]
        [DataRow('K',273.15, "Kelvin")]
        public void TestGetConversionEscala(char escala, double expectedTemperatura, string expectedEscala)
        {
            Temperatura temperatura = new Temperatura(0);
            var conversion = temperatura.GetConversionEscala(escala);
            Assert.AreEqual(expectedTemperatura, conversion.Item1);
            Assert.AreEqual(expectedEscala, conversion.Item2);
        }
    }
}