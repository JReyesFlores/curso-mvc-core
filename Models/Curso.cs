using System;
using System.Collections.Generic;

namespace curso_mvc_core.Models
{
    public class Curso : ObjetoEscuelaBase
    {
        public string EscuelaId { get; set; }
        public Escuela Escuela { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumno> Alumnos { get; set; }
        public TiposJornada Jornada { get; set; }

        public string Direccion { get; set; }
    }
}