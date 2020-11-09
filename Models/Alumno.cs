using System;
using System.Collections.Generic; 

namespace curso_mvc_core.Models
{
    public class Alumno : ObjetoEscuelaBase
    { 
        public List<Evaluacion> Evaluaciones { get; set; } = new List<Evaluacion>(); 
    }
}