namespace ConsoleApp05.Entidades
{
    public class Punto
    {
        private double x;
        private double y;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        // Constructor que recibe las coordenadas x e y del punto
        public Punto(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        // Método para obtener la distancia al origen de coordenadas
        public double DistanciaAlOrigen()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
        }

        public double DistanciaOtroPunto(Punto otroPunto)
        {
            return Math.Sqrt(Math.Pow(X-otroPunto.X, 2)
                + Math.Pow(Y-otroPunto.Y, 2));
        }

        // Método para obtener el cuadrante en el que se encuentra el punto
        public int Cuadrante()
        {
            if (X > 0 && Y > 0)
                return 1;
            else if (X < 0 && Y > 0)
                return 2;
            else if (X < 0 && Y < 0)
                return 3;
            else if (X > 0 && Y < 0)
                return 4;
            else
                return 0; // Se encuentra en el origen
        }

        // Método para obtener las coordenadas polares del punto (r, θ)
        public (double r, double theta) CoordenadasPolares()
        {
            double r = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
            double theta = Math.Atan2(Y, X);
            return (r, theta);
        }

        public void MoverArriba(double distancia)
        {
            Y += distancia;
        }

        public void MoverAbajo(double distancia)
        {
            Y -= distancia;
        }

        public void MoverIzquierda(double distancia)
        {
            X -= distancia;
        }

        public void MoverDerecha(double distancia)
        {
            X += distancia;
        }

        public void Mover(double deltaX, double deltaY)
        {
            X += deltaX;
            Y += deltaY;
        }

        // Método para verificar si este punto es colineal con otros dos puntos dados
        public bool EsColinealCon(Punto punto1, Punto punto2)
        {
            return punto1.X==punto2.X && punto1.Y==punto2.Y;
        }
    }

}
