using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using System.Linq;

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

            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        private void CargarEvaluaciones()
        {
            Random random=new Random();
            foreach (var curso in Escuela.Cursos)
            {
                foreach (var alumno in curso.Alumnos)
                {
                    foreach (var asignatura in curso.Asignaturas)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            var eval = random.Next(0, 50) * 0.1;
                            var evaluacion = new Evaluacion();
                            evaluacion.Asignatura=asignatura;
                            evaluacion.Calificacion.Add(eval);

                            alumno.Evaluaciones.Add(evaluacion);
                        }   
                    }
                }
            }
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                List<Asignatura> listaAsignaturas = new List<Asignatura>
                {
                    new Asignatura{Nombre="Matemáticas"},
                    new Asignatura{Nombre="Educacion física"},
                    new Asignatura{Nombre="Ingles"},
                    new Asignatura{Nombre="Ciencias naturales"}
                };
                curso.Asignaturas = listaAsignaturas;
            }
        }

        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string[] nombres = { "Jorge", "Juan", "Alfredo", "Luis", "Maria", "Victoria" };
            string[] apellido1 = { "Ruiz", "Mendez", "Oliva", "Suarez", "Hernan", "Losa" };
            string[] apellido2 = { "Melendez", "Roberto", "Albarado", "Ricardo", "Mario", "Lucero" };

            //Producto cartesiano
            var listaAlumnos = from n1 in nombres
                               from n2 in apellido1
                               from n3 in apellido2
                               select new Alumno { Nombre = $"{n1} {n2} {n3}" };



            return listaAlumnos.OrderBy(x => x.UniqueId).Take(cantidad).ToList();
        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>{
                 new Curso() {Nombre = "101",Jornada=TiposJornada.Mañana},
                 new Curso() {Nombre = "201",Jornada=TiposJornada.Mañana},
                 new Curso() {Nombre = "301",Jornada=TiposJornada.Mañana},
                 new Curso() {Nombre = "401",Jornada=TiposJornada.Tarde},
                 new Curso() {Nombre = "501",Jornada=TiposJornada.Tarde}
            };

            Random random = new Random();
            foreach (var curso in Escuela.Cursos)
            {
                var cantidadRandom = random.Next(5, 20);
                curso.Alumnos = GenerarAlumnosAlAzar(cantidadRandom);
            }
        }

        #endregion
    }
}