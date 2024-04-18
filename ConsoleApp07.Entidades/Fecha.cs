namespace ConsoleApp07.Entidades
{
    public class Fecha
    {
        private int dia;
        private int mes;
        private int anio;

        // Constructor que inicializa los atributos con la fecha del sistema
        public Fecha()
        {
            DateTime fechaActual = DateTime.Now;
            dia = fechaActual.Day;
            mes = fechaActual.Month;
            anio = fechaActual.Year;
        }

        // Constructor que recibe como parámetro los valores para inicializar la fecha
        public Fecha(int dia, int mes, int año)
        {
            if (EsFechaValida(dia, mes, año))
            {
                this.dia = dia;
                this.mes = mes;
                this.anio = año;
            }
            else
            {
                throw new ArgumentException("La fecha ingresada no es válida.");
            }
        }

        // Método público para modificar el valor de la fecha
        public void ModificarFecha(int dia, int mes, int año)
        {
            if (EsFechaValida(dia, mes, año))
            {
                this.dia = dia;
                this.mes = mes;
                this.anio = año;
            }
            else
            {
                throw new ArgumentException("La fecha ingresada no es válida.");
            }
        }

        // Método público para mostrar la fecha en formato dia / mes / año
        public string MostrarFecha()
        {
            return $"{dia.ToString().PadLeft(2,'0')}/{mes.ToString().PadLeft(2, '0')}/{anio}";
        }

        // Método público para mostrar la fecha con el mes en palabras
        public void MostrarFechaConMesEnPalabras()
        {
            string nombreMes = ObtenerNombreMes();
            Console.WriteLine($"{dia} de {nombreMes} de {anio}");
        }

        // Método público para verificar si una fecha es válida
        public bool EsFechaValida(int dia, int mes, int año)
        {
            if (año < 1 || año > 9999)
                return false;

            if (mes < 1 || mes > 12)
                return false;

            int[] diasPorMes = { 31, 28 + (EsAñoBisiesto(año) ? 1 : 0), 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (dia < 1 || dia > diasPorMes[mes - 1])
                return false;

            return true;
        }

        // Método privado para obtener el nombre del mes
        private string ObtenerNombreMes()
        {
            switch (mes)
            {
                case 1:
                    return "Enero";
                case 2:
                    return "Febrero";
                case 3:
                    return "Marzo";
                case 4:
                    return "Abril";
                case 5:
                    return "Mayo";
                case 6:
                    return "Junio";
                case 7:
                    return "Julio";
                case 8:
                    return "Agosto";
                case 9:
                    return "Septiembre";
                case 10:
                    return "Octubre";
                case 11:
                    return "Noviembre";
                case 12:
                    return "Diciembre";
                default:
                    return "";
            }
        }

        // Método privado para verificar si un año es bisiesto
        private bool EsAñoBisiesto(int año)
        {
            return (año % 4 == 0 && año % 100 != 0) || (año % 400 == 0);
        }
        public bool EsFechaValidaAlt(int dia, int mes, int anio)
        {
            return (dia >= 1 && dia <= DateTime.DaysInMonth(mes, anio))
                && (mes >= 1 && mes <= 12)
                && (anio > 0);

        }
        public string MostrarFechaConMesEnPalabra()
        {
            string nombreMes = ObtenerNombreMes();
            string nombreMesAlt = ObtenerNombreMesAlt();
            return ($"{dia} de {nombreMes} de {anio}");
        }

        private string ObtenerNombreMesAlt()
        {
            var fecha = new DateTime(anio, mes, dia);
            return fecha.ToString("MMM");
        }
        public string ObtenerDiaSemana()
        {
            var fecha = new DateTime(anio, mes, dia);
            return fecha.ToString("dddd");
            //return fecha.DayOfWeek.ToString();

        }
        public void AgregarDias(int diasAgregados)
        {
            DateTime fecha = new DateTime(anio, mes, dia);
            fecha = fecha.AddDays(diasAgregados);
            dia = fecha.Day;
            mes = fecha.Month;
            anio = fecha.Year;
        }
        public string CompararFechas(Fecha otraFecha)
        {
            DateTime fecha1 = new DateTime(anio, mes, dia);
            DateTime fecha2 = new DateTime(otraFecha.anio, otraFecha.mes, otraFecha.dia);
            if (DateTime.Compare(fecha1, fecha2) == -1)
            {
                return $@"{fecha1.ToShortDateString()} es anterior a 
                    {fecha2.ToShortDateString()}";
            }
            if (DateTime.Compare(fecha1, fecha2) == 1)
            {
                return $@"{fecha1.ToShortDateString()} es posterior a 
                    {fecha2.ToShortDateString()}";
            }
            return $@"{fecha1.ToShortDateString()} es igual a 
                    {fecha2.ToShortDateString()}";

        }
        public int ObtenerEdad(DateTime fechaNacimiento)
        {

            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - fechaNacimiento.Year;
            if (fechaNacimiento > fechaActual.AddYears(-edad))
                edad--;
            return edad;
        }

    }
}