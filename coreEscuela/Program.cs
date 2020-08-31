using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicializamos las Escuela 
            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.WriteTitle("BIENVENIDOS A LA ESCUELA");
            //Printer.Beep(10000, cantidad:10);
            ImprimirCursosEscuela(engine.Escuela);
            Printer.Space();

            
            Printer.DrawLine(40);
            Printer.WriteTitle("Pruebas Polimorfismo");
            Printer.DrawLine(40);
            var alumnoTest = new Alumno{Nombre="Claire Underwood"};
            ObjetoEscuelaBase ob = alumnoTest;
            Printer.WriteTitle("Alumno");
            WriteLine($"Alumno : {alumnoTest.Nombre}");
            WriteLine($"Id : {alumnoTest.UniqueId}");
            WriteLine($"Type : {alumnoTest.GetType()}");
            Printer.Space();
            Printer.WriteTitle("Objeto Escuela");
            WriteLine($"Alumno : {ob.Nombre}");
            WriteLine($"Id : {ob.UniqueId}");
            WriteLine($"Type : {ob.GetType()}");
            Printer.Space();

            var Ev29 = new Evaluacion{Nombre = "Calculo Integral I", Nota = 4.5f,};
            Printer.WriteTitle("Evaluacion");
            WriteLine($"Evaluacion : {Ev29.Nombre}");
            WriteLine($"Id : {Ev29.UniqueId}");
            WriteLine($"Nota : {Ev29.Nota}");
            WriteLine($"Alumno : {Ev29.GetType()}");
            Printer.Space();

        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Printer.WriteTitle("Cursos de la Escuela");
            if (escuela?.Cursos != null)
            {
            foreach (var curso in escuela.Cursos)
                {
                WriteLine($"Nombre {curso.Nombre  }, Id  {curso.UniqueId}");
                }
            }
        }
    }
}
