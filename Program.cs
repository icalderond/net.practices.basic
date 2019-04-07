using System;
using CoreEscuela.Entidades;
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2019)
            {
                Pais = "México",
                Ciudad = "Guadalajara"
            };

            escuela.Cursos = new Curso[] {
                new Curso() {Nombre = "101"},
                new Curso(){Nombre = "201"},
                new Curso(){Nombre = "301"}
            };

            // escuela.CursosArray=null;
            // escuela.CursosArray=new Curso[0];
            escuela = null;

            ImprimirCursosEscuela(escuela);
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("======================");
            WriteLine("Cursos de la escuela");
            WriteLine("======================");

            if (escuela?.Cursos != null)
            {
                ImprimirCursos_ForEach(escuela.Cursos);
            }
        }

        private static void ImprimirCursos_ForEach(Curso[] arregloCurso)
        {
            foreach (var curso in arregloCurso)
            {
                WriteLine($"Nombre:{curso.Nombre}, Id:{curso.UniqueId}");
            }
        }

        private static void ImprimirCursos_For(Curso[] arregloCurso)
        {
            for (int i = 0; i < arregloCurso.Length; i++)
            {
                var curso = arregloCurso[i];
                WriteLine($"Nombre:{curso.Nombre}, Id:{curso.UniqueId}");
            }
        }

        private static void ImprimirCursos_DoWhile(Curso[] arregloCurso)
        {
            int contador = 0;
            do
            {
                var curso = arregloCurso[contador];
                WriteLine($"Nombre:{curso.Nombre}, Id:{curso.UniqueId}");
                // contador=contador+1;
                // contador+=1;
                contador++;
            } while (contador < arregloCurso.Length);
        }
        private static void ImprimirCursos_While(Curso[] arregloCurso)
        {
            int contador = 0;
            while (contador < arregloCurso.Length)
            {
                var curso = arregloCurso[contador];
                WriteLine($"Nombre:{curso.Nombre}, Id:{curso.UniqueId}");
                // contador=contador+1;
                // contador+=1;
                contador++;
            }
        }
    }
}
