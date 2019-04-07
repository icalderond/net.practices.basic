using System;

namespace CoreEscuela.Entidades
{
    public class Alumno
    {
        public Alumno() => UniqueId = Guid.NewGuid().ToString();

        public string UniqueId { get; private set; }
        
        public string Nombre { get; internal set; }
    }
}