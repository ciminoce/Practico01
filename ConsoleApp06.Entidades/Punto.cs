namespace ConsoleApp06.Entidades
{
    public class Punto
    {
        public double X { get; }
        public double Y { get; }

        // Constructor que recibe las coordenadas x e y del punto
        public Punto(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
