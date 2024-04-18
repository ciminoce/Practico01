namespace ConsoleApp06.Entidades
{
    public class Circunferencia
    {
        private Punto centro;
        private double radio;

        // Constructor que recibe el centro y el radio de la circunferencia
        public Circunferencia(Punto centro, double radio)
        {
            this.centro = centro;
            this.radio = radio;
        }

        // Método para obtener el área de la circunferencia
        public double ObtenerArea()
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        // Método para obtener el perímetro de la circunferencia
        public double ObtenerPerimetro()
        {
            return 2 * Math.PI * radio;
        }

        // Método para verificar si un punto está dentro de la circunferencia
        public bool PuntoEstaDentro(Punto punto)
        {
            double distanciaAlCentro = Math.Sqrt(Math.Pow(punto.X - centro.X, 2) 
                + Math.Pow(punto.Y - centro.Y, 2));
            return distanciaAlCentro <= radio;
        }
        private double CalcularDistanciaEntreCentros(Circunferencia otraCircunferencia)
        {
            return Math.Sqrt(Math.Pow(centro.X - otraCircunferencia.centro.X, 2)
                + Math.Pow(centro.Y - otraCircunferencia.centro.Y, 2));
        }
        public bool EstaContenidaEn(Circunferencia otraCircunferencia)
        {
            double distanciaEntreCentros = 
                CalcularDistanciaEntreCentros(otraCircunferencia);
            return distanciaEntreCentros + radio <= otraCircunferencia.radio;
        }

        public string ObtenerEcuacionGeneral()
        {
            //Para obtener el super índice alt+ "0178" teclado numérico
            double D = -2 * centro.X;
            double E = -2 * centro.Y;
            double F = Math.Pow(centro.X, 2) + Math.Pow(centro.Y, 2)
                - Math.Pow(radio, 2);
            return $"x² + y² + ({D})x + ({E})y + ({F}) = 0";
        }

    }
}
