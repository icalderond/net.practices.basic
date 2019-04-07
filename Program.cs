using System;
using CoreEscuela.Entidades;

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

            var arregloCurso = new Curso[3];
            arregloCurso[0] = new Curso()
            {
                Nombre = "101"
            };


            var cursoSegundo = new Curso()
            {
                Nombre = "201"
            };
            arregloCurso[1] = cursoSegundo;

            arregloCurso[2] = new Curso
            {
                Nombre = "301"
            };

            System.Console.WriteLine("==============");
            ImprimirCursos_While(arregloCurso);
            System.Console.WriteLine("==============");
            ImprimirCursos_DoWhile(arregloCurso);
            System.Console.WriteLine("==============");
            ImprimirCursos_For(arregloCurso);
            System.Console.WriteLine("==============");
            ImprimirCursos_ForEach(arregloCurso);
        }

        private static void ImprimirCursos_ForEach(Curso[] arregloCurso)
        {
            foreach (var curso in arregloCurso)
            {
                System.Console.WriteLine($"Nombre:{curso.Nombre}, Id:{curso.UniqueId}");
            }
        }

        private static void ImprimirCursos_For(Curso[] arregloCurso)
        {
            for (int i = 0; i < arregloCurso.Length; i++)
            {
                var curso=arregloCurso[i];
                System.Console.WriteLine($"Nombre:{curso.Nombre}, Id:{curso.UniqueId}");
            }
        }

        private static void ImprimirCursos_DoWhile(Curso[] arregloCurso)
        {
            int contador = 0;
            do
            {
                var curso = arregloCurso[contador];
                System.Console.WriteLine($"Nombre:{curso.Nombre}, Id:{curso.UniqueId}");
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
                System.Console.WriteLine($"Nombre:{curso.Nombre}, Id:{curso.UniqueId}");
                // contador=contador+1;
                // contador+=1;
                contador++;
            }
        }
    }
}
