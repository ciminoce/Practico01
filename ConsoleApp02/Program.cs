using ConsoleApp02.Entidades;
using Practico01.Shared;
var radio = ConsoleExtensions.ReadDouble("Ingrese el valor del radio:");

Circunferencia circunferencia = new Circunferencia(radio);
Console.WriteLine("Perímetro: " + circunferencia.CalcularPerimetro());
Console.WriteLine("Área: " + circunferencia.CalcularArea());

circunferencia.CambiarTamaño(2);
Console.WriteLine("Nuevo radio: " + circunferencia.Radio);

double x = 3;
double y = 4;
if (circunferencia.PuntoDentro(x, y))
{
    Console.WriteLine("El punto (" + x + ", " + y + ") está dentro de la circunferencia.");
}
else
{
    Console.WriteLine("El punto (" + x + ", " + y + ") está fuera de la circunferencia.");
}