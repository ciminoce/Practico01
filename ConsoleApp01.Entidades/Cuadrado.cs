using System.Text;

namespace ConsoleApp01.Entidades
{
    public class Cuadrado
    {
        private double lado;

        // Constructor que recibe el valor del lado
        public Cuadrado(double lado)
        {
            this.lado = lado;
        }
        /// <summary>
        ///  Método para obtener el perímetro del cuadrado   
        /// </summary>
        /// <returns></returns>
        public double CalcularPerimetro()
        {
            return 4 * lado;
        }
        /// <summary>
        /// Método para informar el valor del área
        /// </summary>
        /// <returns></returns>  
        public double CalcularArea()
        {
            return lado * lado;
        }

        /// <summary>
        /// Método para imprimir la información del cuadrado
        /// </summary>
        /// <returns></returns>
        public string ImprimirInformacion()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Cuadrado con lado de " + lado);
            sb.AppendLine("Perímetro: " + CalcularPerimetro());
            sb.AppendLine("Área: " + CalcularArea());
            return sb.ToString();
        }
        /// <summary>
        /// Método para informar si el cuadrado es un cuadrado perfecto
        /// </summary>
        /// <returns>Verdadero o Falso</returns>
        public bool EsCuadradoPerfecto()
        {
            double area = CalcularArea();
            double raiz = Math.Sqrt(area);
            return raiz == Math.Floor(raiz);
        }
        // Propiedad para acceder y modificar el valor del lado
        public double Lado
        {
            get { return lado; }
            set
            {
                if (value > 0)
                    lado = value;
                else
                    throw new ArgumentException("El valor del lado debe ser mayor que cero.");
            }
        }
        /// <summary>
        /// Método para obtener la diagonal del cuadrado
        /// </summary>
        /// <returns></returns>
        public double ObtenerDiagonal()
        {
            return Math.Sqrt(2) * lado;
        }
        /// <summary>
        /// Método para cambiar el tamaño del cuadrado
        /// </summary>
        /// <param name="factorDeCambio">Número positivo</param>
        public void CambiarTamaño(double factorDeCambio)
        {
            if (lado * factorDeCambio > 0)
            {
                lado *= factorDeCambio;
            }
            else
            {
                throw new ArgumentException("Error: No se puede cambiar el tamaño a un valor negativo o cero.");
            }
        }
    }
}
