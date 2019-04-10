using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Asignatura
    {
        public Asignatura() => UniqueId = Guid.NewGuid().ToString();

        public string UniqueId { get; private set; }

        public string Nombre { get; internal set; }
    }
}