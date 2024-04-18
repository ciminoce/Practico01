// Ejemplo de uso
using ConsoleApp07.Entidades;

// Crear una instancia de Fecha con la fecha del sistema
Fecha fechaActual = new Fecha();

Console.WriteLine("Fecha actual:");
fechaActual.MostrarFechaConMesEnPalabras();

Console.WriteLine("\nAgregar 10 días a la fecha actual:");
fechaActual.AgregarDias(10);
fechaActual.MostrarFechaConMesEnPalabras();

Console.WriteLine("\nComparar la fecha actual con otra fecha:");
Fecha otraFecha = new Fecha(20, 4, 2024);
Console.WriteLine(fechaActual.CompararFechas(otraFecha));

Console.WriteLine("\nObtener el día de la semana de la fecha actual:");
string diaSemana = fechaActual.ObtenerDiaSemana();
Console.WriteLine($"Día de la semana: {diaSemana}");

Console.WriteLine("\nCalcular la edad a partir de una fecha de nacimiento:");
DateTime fechaNacimiento = new DateTime(1990, 5, 15);
int edad = fechaActual.ObtenerEdad(fechaNacimiento);
Console.WriteLine($"Edad: {edad} años");