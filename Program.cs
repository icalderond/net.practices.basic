using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela=new Escuela("Platzi Academy",2019){
                Pais="México",
                Ciudad="Guadalajara"
                };

            var arregloCurso=new Curso[3];
            arregloCurso[0] = new Curso()
            {
                Nombre = "101"
            };


            var cursoSegundo = new Curso()
            {
                Nombre = "201"
            };
            arregloCurso[1]=cursoSegundo;

            arregloCurso[2]= new Curso
            {
                Nombre = "301"
            };

            System.Console.WriteLine("==============");

            ImprimirCursosWhile(arregloCurso);
        }

        private static void ImprimirCursosWhile(Curso[] arregloCurso)
        {
            int contador=0;
            while (contador<arregloCurso.Length)
            {
                var current=arregloCurso[contador];
                System.Console.WriteLine($"Nombre:{current.Nombre}, Id:{current.UniqueId}");
                // contador=contador+1;
                // contador+=1;
                contador++;
            }
        }
    }
}
