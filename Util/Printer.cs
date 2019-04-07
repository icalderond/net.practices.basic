using static System.Console;

namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void DibujarLinea(int tamano = 10)
        {
            var linea = string.Empty.PadLeft(tamano, '=');
            WriteLine(linea);
        }

        public static void EscribirTitulo(string titulo)
        {
            var tamano = titulo.Length + 4;
            DibujarLinea(tamano);
            WriteLine($"| {titulo} |");
            DibujarLinea(tamano);
        }

        public static void Beepi(int hz = 2000, int tiempo = 500, int cantidad = 1)
        {
            while (cantidad-- > 0)
            {
                //Not work on mac
                System.Console.Beep(hz, tiempo);
            }
        }
    }
}