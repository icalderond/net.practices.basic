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

            var cursoPrimero = new Curso()
            {
                Nombre = "101"
            };
            var cursoSegundo = new Curso()
            {
                Nombre = "201"
            };
            var cursoTercero = new Curso()
            {
                Nombre = "301"
            };

            System.Console.WriteLine("==============");

            var messagePrimerCurso = $"{cursoPrimero.Nombre}, {cursoPrimero.UniqueId}";
            var messagePrimerSegundo = $"{cursoSegundo.Nombre}, {cursoSegundo.UniqueId}";
            var messagePrimerTercero = $"{cursoTercero.Nombre}, {cursoTercero.UniqueId}";

            System.Console.WriteLine(messagePrimerCurso);
            System.Console.WriteLine(messagePrimerSegundo);
            System.Console.WriteLine(messagePrimerTercero);
        }
    }
}
