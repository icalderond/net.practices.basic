using System.Collections.Generic;
using CoreEscuela.Entidades;
using CoreEscuela.Util;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        #region Constructor
        public EscuelaEngine()
        {
            Inicializar();
        }

        #endregion

        #region Properties

        public Escuela Escuela { get; set; }


        #endregion

        #region Methods

        public void Inicializar()
        {
            Escuela = new Escuela("Platzi Academy", 2019)
            {
                Pais = "México",
                Ciudad = "Guadalajara",
                TipoEscuela = TiposEscuela.Primaria
            };

            Escuela.Cursos = new List<Curso>{
                 new Curso() {Nombre = "101",Jornada=TiposJornada.Mañana},
                 new Curso() {Nombre = "201",Jornada=TiposJornada.Mañana},
                 new Curso() {Nombre = "301",Jornada=TiposJornada.Mañana},
                 new Curso() {Nombre = "401",Jornada=TiposJornada.Tarde},
                 new Curso() {Nombre = "501",Jornada=TiposJornada.Tarde}
            };
        }

        #endregion
    }
}