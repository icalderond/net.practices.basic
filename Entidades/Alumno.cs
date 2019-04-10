using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Alumno
    {
        public Alumno()
        {
            UniqueId = Guid.NewGuid().ToString();
            Evaluaciones = new List<Evaluacion>();
        }

        public string UniqueId { get; private set; }

        public string Nombre { get; internal set; }

        public List<Evaluacion> Evaluaciones { get; set; }

    }
}