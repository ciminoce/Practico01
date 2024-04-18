using System.Text;

namespace ConsoleApp03.Entidades
{
    public class Rectangulo
    {
        private double longitud;
        private double anchura;

        // Constructor que recibe la longitud y la anchura del rectángulo
        public Rectangulo(double longitud, double anchura)
        {
            if (longitud <= 0 || anchura <= 0)
            {
                throw new ArgumentException("La longitud y la anchura deben ser mayores que cero.");
            }

            if (!EsRectangulo(longitud, anchura))
            {
                throw new ArgumentException("Los valores proporcionados no forman un rectángulo válido.");
            }

            this.longitud = longitud;
            this.anchura = anchura;
        }

        // Método privado para validar si las medidas forman un rectángulo
        private bool EsRectangulo(double longitud, double anchura)
        {
            return longitud != anchura;
        }
        // Método para obtener el perímetro del rectángulo
        public double CalcularPerimetro()
        {
            return 2 * (longitud + anchura);
        }

        // Método para obtener el área del rectángulo
        public double CalcularArea()
        {
            return longitud * anchura;
        }
        public string ImprimirInformacion()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Rectángulo con longitud de {Longitud} y anchura de {Anchura}) ");
            sb.AppendLine($"Perímetro:  {CalcularPerimetro()}");
            sb.AppendLine($"Área: {CalcularArea()}");
            return sb.ToString();
        }

        // Propiedades para acceder y modificar la longitud y la anchura del rectángulo
        public double Longitud
        {
            get { return longitud; }
            set
            {
                if (value > 0)
                    longitud = value;
                else
                    throw new ArgumentException("La longitud debe ser mayor que cero.");
            }
        }

        public double Anchura
        {
            get { return anchura; }
            set
            {
                if (value > 0)
                    anchura = value;
                else
                    throw new ArgumentException("La anchura debe ser mayor que cero.");
            }
        }
        public bool PuntoEstaDentro(double x, double y)
        {
            return x >= 0 && x <= longitud && y >= 0 && y <= anchura;
        }

        public double CalcularDiagonal()
        {
            return Math.Sqrt(Math.Pow(longitud, 2)+Math.Pow(anchura, 2));
        }
    }
}
