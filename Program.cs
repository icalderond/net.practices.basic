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
            
            escuela.TipoEscuela=TiposEscuela.Primaria;
           Console.WriteLine(escuela);     
        }
    }
}
