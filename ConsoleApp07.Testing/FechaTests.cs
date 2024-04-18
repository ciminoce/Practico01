using ConsoleApp07.Entidades;
namespace ConsoleApp07.Testing
{

    [TestClass]
    public class FechaTests
    {
        [TestMethod]
        public void TestModificarFecha()
        {
            // Arrange
            Fecha fecha = new Fecha(1, 1, 2022);

            // Act
            fecha.ModificarFecha(10, 5, 2023);

            // Assert
            StringAssert.Contains("10/05/2023", fecha.MostrarFecha());
        }

        [DataTestMethod]
        [DataRow(31, 12, 2022, true)]  // Fecha válida
        [DataRow(32, 12, 2022, false)] // Día inválido
        [DataRow(31, 13, 2022, false)] // Mes inválido
        [DataRow(29, 2, 2021, false)]  // Año no bisiesto
        [DataRow(29, 2, 2020, true)]   // Año bisiesto
        public void TestEsFechaValida(int dia, int mes, int anio, bool esValida)
        {
            // Arrange
            Fecha fecha = new Fecha();

            // Act
            bool resultado = fecha.EsFechaValida(dia, mes, anio);

            // Assert
            Assert.AreEqual(esValida, resultado);
        }
        [TestMethod]
        public void TestObtenerDiaSemana()
        {
            // Arrange
            Fecha fecha = new Fecha(17, 4, 2024);

            // Act
            string diaSemana = fecha.ObtenerDiaSemana();

            // Assert
            Assert.AreEqual("miércoles", diaSemana); // El 17 de abril de 2024 es martes
        }

        [TestMethod]
        public void TestAgregarDias()
        {
            // Arrange
            Fecha fecha = new Fecha(1, 1, 2022);

            // Act
            fecha.AgregarDias(10);

            // Assert
            StringAssert.Contains("11/01/2022", fecha.MostrarFecha());
            
        }

        [TestMethod]
        public void TestCompararFechas()
        {
            // Arrange
            Fecha fecha1 = new Fecha(1, 1, 2022);
            Fecha fecha2 = new Fecha(1, 1, 2023);
            Fecha fecha3 = new Fecha(1, 1, 2022);
            // Act
            string resultado = fecha1.CompararFechas(fecha2);
            string otroResultado = fecha2.CompararFechas(fecha1);
            string nuevoResultado=fecha1.CompararFechas(fecha3);
            // Assert
            Assert.AreEqual("01/01/2022 es anterior a 01/01/2023", resultado);
            Assert.AreEqual("01/01/2023 es posterior a 01/01/2022", resultado);
            Assert.AreEqual("01/01/2022 es igual a 01/01/2022", resultado);
        }

        [TestMethod]
        public void TestObtenerEdad()
        {
            // Arrange
            Fecha fecha = new Fecha();
            DateTime fechaNacimiento = new DateTime(1990, 5, 15);

            // Act
            int edad = fecha.ObtenerEdad(fechaNacimiento);

            // Assert
            Assert.AreEqual(34, edad); // Suponiendo que estamos en el año 2024
        }

        // Agregar más pruebas unitarias según sea necesario
    }
}