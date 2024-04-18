// Ejemplo de uso
using ConsoleApp06.Entidades;

Punto centro = new Punto(0, 0);
double radio = 5.0;
Circunferencia circunferencia = new Circunferencia(centro, radio);

Console.WriteLine("Área de la circunferencia: " + circunferencia.ObtenerArea());
Console.WriteLine("Perímetro de la circunferencia: " + circunferencia.ObtenerPerimetro());

Punto puntoPrueba = new Punto(3, 4);
Console.WriteLine("El punto (" + puntoPrueba.X + ", " + puntoPrueba.Y + ") está dentro de la circunferencia: " + circunferencia.PuntoEstaDentro(puntoPrueba));

Circunferencia circ1 = new Circunferencia(new Punto(0, 0), 5);
Circunferencia circ2 = new Circunferencia(new Punto(0, 0), 8);

bool circ1EstaContenidaEnCirc2 = circ1.EstaContenidaEn(circ2);
Console.WriteLine("¿La circunferencia 1 está contenida en la circunferencia 2? " + circ1EstaContenidaEnCirc2)