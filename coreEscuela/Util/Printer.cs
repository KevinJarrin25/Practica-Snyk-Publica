using static System.Console;

namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void DrawLine(int tam = 10)
        {
            WriteLine("".PadLeft(tam, '='));
        }

        public static void WriteTitle(string titulo)
        {
            
            WriteLine($"        | {titulo} |        ");
            
        }

        public static void Space(){
            WriteLine(" ");
        }

        public static void Beep(int hz = 2000, int tiempo=500, int cantidad =1)
        {
            while (cantidad-- > 0)
            {
                System.Console.Beep(hz, tiempo);
            }
        }
    }
}