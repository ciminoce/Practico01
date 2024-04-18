using System.Text;

namespace ConsoleApp02.Entidades
{
    public class Circunferencia
    {
        private double radio;

        // Constructor que recibe el valor del radio
        public Circunferencia(double radio)
        {
            this.radio = radio;
        }

        // Método para obtener el perímetro de la circunferencia
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }

        // Método para obtener el área de la circunferencia
        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        /// <summary>
        /// Método para imprimir la información del cuadrado
        /// </summary>
        /// <returns></returns>
        public string ImprimirInformacion()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Circunferencia de radio: {Radio} ");
            sb.AppendLine($"Perímetro:  {CalcularPerimetro()}");
            sb.AppendLine($"Área: {CalcularArea()}");
            return sb.ToString();
        }

        // Propiedad para acceder y modificar el valor del radio
        public double Radio
        {
            get { return radio; }
            set
            {
                if (value > 0)
                    radio = value;
                else
                    throw new ArgumentException(@"El valor del radio debe 
                        ser mayor que cero.");
            }
        }

        /// <summary>
        /// Método para cambiar el tamaño del cuadrado
        /// </summary>
        /// <param name="factorDeCambio">Número positivo</param>
        public void CambiarTamaño(double factorDeCambio)
        {
            if (radio * factorDeCambio > 0)
            {
                radio *= factorDeCambio;
            }
            else
            {
                throw new ArgumentException(@"Error: No se puede cambiar 
                    el tamaño a un valor negativo o cero.");
            }
        }
        /// <summary>
        /// Método para ver si un punto está dentro de la circ
        /// </summary>
        /// <param name="x">coord x del punto</param>
        /// <param name="y">coord y del punto</param>
        /// <returns>Verdadero o Falso</returns>
        public bool PuntoDentro(double x, double y)
        {
            // Calculamos la distancia desde el origen al punto dado (x, y)
            double distanciaAlOrigen = Math.Sqrt(Math.Pow(x, 2)
                + Math.Pow(y, 2));

            // Si la distancia es menor o igual al radio, el punto está dentro de la circunferencia
            return distanciaAlOrigen <= radio;
        }
    }

}
