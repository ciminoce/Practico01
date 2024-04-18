// Ejemplo de uso
using ConsoleApp04.Entidades;
using Practico01.Shared;

try
{
	double temperaturaCelsius = ConsoleExtensions.ReadDouble("Ingrese la temperatura en celsius:");
	Temperatura temperatura = new Temperatura(temperaturaCelsius);

	Console.WriteLine("Temperatura en grados Celsius: " + temperatura.ObtenerCelsius());
	Console.WriteLine("Temperatura en grados Fahrenheit: " + temperatura.ObtenerFahrenheit());
	Console.WriteLine("Temperatura en grados Kelvin: " + temperatura.ObtenerKelvin());
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message); 
}