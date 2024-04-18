namespace Practico01.Shared
{
    public static class ConsoleExtensions
    {
        public static string ReadString(string message)
        {
            string? stringVar = string.Empty;
            while (true)
            {

                Console.Write(message);
                stringVar = Console.ReadLine();
                if (stringVar == null)
                {
                    Console.WriteLine("Debe ingresar algo!!!");
                }
                else
                {
                    break;
                }
            }
            return stringVar;
        }

        public static int ReadInt(string message)
        {
            while (true)
            {
                Console.Write(message);
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número entero válido.");
                }
            }
        }

        public static int ReadInt(string message, int min, int max)
        {
            while (true)
            {
                Console.Write(message);
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int result))
                {
                    if (result >= min && result <= max)
                    {
                        return result;

                    }
                    else
                    {
                        Console.WriteLine($"Selección fuera de rango ({min}-{max}");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número entero válido.");
                }
            }
        }
        public static double ReadDouble(string message)
        {
            while (true)
            {
                Console.Write(message);
                string? input = Console.ReadLine();
                if (double.TryParse(input, out double result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número double válido.");
                }
            }
        }

        public static double ReadDouble(string message, int min, int max)
        {
            while (true)
            {
                Console.Write(message);
                string? input = Console.ReadLine();
                if (double.TryParse(input, out double result))
                {
                    if (result >= min && result <= max)
                    {
                        return result;

                    }
                    else
                    {
                        Console.WriteLine($"Selección fuera de rango ({min}-{max}");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número double válido.");
                }
            }
        }

        public static decimal ReadDecimal(string message)
        {
            while (true)
            {
                Console.Write(message);
                string? input = Console.ReadLine();
                if (decimal.TryParse(input, out decimal result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número decimal válido.");
                }
            }
        }

        public static decimal ReadDecimal(string message, int min, int max)
        {
            while (true)
            {
                Console.Write(message);
                string? input = Console.ReadLine();
                if (decimal.TryParse(input, out decimal result))
                {
                    if (result >= min && result <= max)
                    {
                        return result;

                    }
                    else
                    {
                        Console.WriteLine($"Selección fuera de rango ({min}-{max}");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número decimal válido.");
                }
            }
        }


        public static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

    }
}
