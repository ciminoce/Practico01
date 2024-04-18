// Ejemplo de uso
using ConsoleApp01.Entidades;

try
{
    double ladoCuadrado = 5.0;
    Cuadrado cuadrado = new Cuadrado(ladoCuadrado);

    // Utilizamos el método para imprimir la información del cuadrado
    cuadrado.ImprimirInformacion();

    // Modificamos el lado del cuadrado y volvemos a imprimir la información
    cuadrado.Lado = 7.0;
    Console.WriteLine(cuadrado.ImprimirInformacion());
    DibujarCuadrado(cuadrado.Lado);
    cuadrado.CambiarTamaño(-2); // Mostrará un mensaje de error y no cambiará el tamaño
    Console.WriteLine(cuadrado.Lado); // Imprimirá 5

}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}
void DibujarCuadrado(double lado)
{
    for (int i = 0; i < lado; i++)
    {
        for (int j = 0; j < lado; j++)
        {
            if (i == 0 || i == lado - 1 || j == 0 || j == lado - 1)
                Console.Write("# ");
            else
                Console.Write("  ");
        }
        Console.WriteLine();
    }
}