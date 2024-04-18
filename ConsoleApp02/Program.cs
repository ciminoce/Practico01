using ConsoleApp02.Entidades;

Circunferencia circunferencia = new Circunferencia(5);
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