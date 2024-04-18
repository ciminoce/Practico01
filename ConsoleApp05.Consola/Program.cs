// Ejemplo de uso
using ConsoleApp05.Entidades;

double xPunto = 3.0;
double yPunto = 4.0;
Punto punto = new Punto(xPunto, yPunto);

Console.WriteLine("Punto con coordenadas (" + xPunto + ", " + yPunto + ")");
Console.WriteLine("Distancia al origen: " + punto.DistanciaAlOrigen());
Console.WriteLine("Cuadrante: " + punto.Cuadrante());
var coordenadasPolares = punto.CoordenadasPolares();
Console.WriteLine("Coordenadas polares (r, θ): (" + coordenadasPolares.r + ", " + coordenadasPolares.theta + ")");