// Ejemplo de uso
using ConsoleApp04.Entidades;

double temperaturaCelsius = 25.0;
Temperatura temperatura = new Temperatura(temperaturaCelsius);

Console.WriteLine("Temperatura en grados Celsius: " + temperatura.ObtenerCelsius());
Console.WriteLine("Temperatura en grados Fahrenheit: " + temperatura.ObtenerFahrenheit());
Console.WriteLine("Temperatura en grados Kelvin: " + temperatura.ObtenerKelvin());