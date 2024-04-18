// Ejemplo de uso
using ConsoleApp03.Entidades;
using System.Drawing;

double longitudRectangulo = 5.0;
double anchuraRectangulo = 3.0;
Rectangulo rectangulo = new Rectangulo(longitudRectangulo, anchuraRectangulo);

Console.WriteLine("Rectángulo con longitud de " + rectangulo.Longitud + " y anchura de " + rectangulo.Anchura);
Console.WriteLine("Perímetro: " + rectangulo.CalcularPerimetro());
Console.WriteLine("Área: " + rectangulo.CalcularArea());

// Modificamos la longitud y la anchura del rectángulo y recalculamos el perímetro y el área
rectangulo.Longitud = 7.0;
rectangulo.Anchura = 4.0;
Console.WriteLine("\nRectángulo con longitud modificada a " + rectangulo.Longitud + " y anchura modificada a " + rectangulo.Anchura);
Console.WriteLine("Perímetro: " + rectangulo.CalcularPerimetro());
Console.WriteLine("Área: " + rectangulo.CalcularArea());