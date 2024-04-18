// Ejemplo de uso
using ConsoleApp03.Entidades;
using Practico01.Shared;
using System.Drawing;

double longitudRectangulo = ConsoleExtensions.ReadDouble("Ingrese la longitud del rectángulo:");
double anchuraRectangulo = ConsoleExtensions.ReadDouble("Ingrese la anchura del rectángulo:");
Rectangulo rectangulo = new Rectangulo(longitudRectangulo, anchuraRectangulo);

Console.WriteLine("Rectángulo con longitud de " + rectangulo.Longitud + " y anchura de " + rectangulo.Anchura);
Console.WriteLine("Perímetro: " + rectangulo.CalcularPerimetro());
Console.WriteLine("Área: " + rectangulo.CalcularArea());

// Modificamos la longitud y la anchura del rectángulo y recalculamos el perímetro y el área
rectangulo.Longitud = ConsoleExtensions.ReadDouble("Ingrese nueva longitud del rectángulo:");
rectangulo.Anchura = ConsoleExtensions.ReadDouble("Ingrese nueva anchura del rectángulo:");
Console.WriteLine("\nRectángulo con longitud modificada a " + rectangulo.Longitud + " y anchura modificada a " + rectangulo.Anchura);
Console.WriteLine("Perímetro: " + rectangulo.CalcularPerimetro());
Console.WriteLine("Área: " + rectangulo.CalcularArea());