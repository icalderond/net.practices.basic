using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;

namespace CoreEscuela.Entidades
{
    public class Evaluacion
    {
        public Evaluacion()
        {
            UniqueId = Guid.NewGuid().ToString();
            Calificacion=new List<double>();
        }

        public string UniqueId { get; private set; }

        public List<double> Calificacion { get; set; }

        public Asignatura Asignatura { get; set; }
    }
}