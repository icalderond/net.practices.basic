using System;
using CoreEscuela.Entidades;
using static System.Console;
using System.Collections.Generic;

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

            escuela.Cursos = new List<Curso>{
                 new Curso() {Nombre = "101"},
                new Curso(){Nombre = "201"},
                new Curso(){Nombre = "301"}
            };

            var otraColeccion = new List<Curso>
            {
                new Curso
                {
                    Nombre = "102",
                    Jornada = TiposJornada.Mañana
                },
                new Curso
                {
                    Nombre = "202",
                    Jornada = TiposJornada.Tarde
                }
            };

            escuela.Cursos.AddRange(otraColeccion);
            // otraColeccion.Clear(); 

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

        private static void ImprimirCursos_ForEach(List<Curso> arregloCurso)
        {
            foreach (var curso in arregloCurso)
            {
                WriteLine($"Nombre:{curso.Nombre}, Id:{curso.UniqueId}");
            }
        }
    }
}
