using System;
using CoreEscuela.Entidades;
using static System.Console;
using System.Collections.Generic;
using CoreEscuela;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine=new EscuelaEngine();
            ImprimirCursosEscuela(engine.Escuela);
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