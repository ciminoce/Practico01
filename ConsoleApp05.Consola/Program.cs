// Ejemplo de uso
using ConsoleApp05.Entidades;
using Practico01.Shared;

double xPunto = ConsoleExtensions.ReadDouble("Ingrese valor de la coord. X:");
double yPunto = ConsoleExtensions.ReadDouble("Ingrese valor de la coord. Y:");
Punto punto = new Punto(xPunto, yPunto);

Console.WriteLine("Punto con coordenadas (" + xPunto + ", " + yPunto + ")");
Console.WriteLine("Distancia al origen: " + punto.DistanciaAlOrigen());
Console.WriteLine("Cuadrante: " + punto.Cuadrante());
var coordenadasPolares = punto.CoordenadasPolares();
Console.WriteLine("Coordenadas polares (r, θ): (" + coordenadasPolares.r + ", " + coordenadasPolares.theta + ")");