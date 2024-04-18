﻿namespace ConsoleApp04.Entidades
{
    public class Temperatura
    {
        private double celsius;
        private const double CeroAbsoluto = -273.15;

        // Constructor que recibe la temperatura en grados Celsius
        public Temperatura(double celsius)
        {
            if (celsius < -80 || celsius > 80)
            {
                throw new ArgumentOutOfRangeException("La temperatura en grados Celsius debe estar entre -80 y 80.");
            }
            if (Math.Abs(celsius * 10) - Math.Floor(celsius * 10) > 0.1)
            {
                throw new ArgumentException("El valor debe tener únicamente un solo decimal");
            }

            this.celsius = celsius;
        }

        // Método para obtener la temperatura en grados Celsius
        public double ObtenerCelsius()
        {
            return celsius;
        }

        // Método para obtener la temperatura en grados Fahrenheit
        public double ObtenerFahrenheit()
        {
            return celsius * 9 / 5 + 32;
        }

        // Método para obtener la temperatura en grados Kelvin
        public double ObtenerKelvin()
        {
            return celsius + 273.15;
        }

        public override string ToString()
        {
            return $"{celsius} °C";
        }

        public (double, string) GetConversionEscala(char escala)
        {
            double temperaturaConvertida = 0;
            string escalaConvertida = string.Empty;
            switch (char.ToUpper(escala))
            {
                case 'F':
                    temperaturaConvertida = ObtenerFahrenheit();
                    escalaConvertida = "Fahrenheit";
                    break;
                case 'K':
                    temperaturaConvertida = ObtenerKelvin();
                    escalaConvertida = "Kelvin";
                    break;
                default:
                    throw new ArgumentException("Escala mal ingresada");
            }
            return (temperaturaConvertida, escalaConvertida);
        }

        public double DiferenciaConCeroAbsoluto()
        {
            return celsius - CeroAbsoluto;
        }

    }

}
