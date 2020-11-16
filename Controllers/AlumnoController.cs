using System;
using System.Collections.Generic;
using System.Linq;
using curso_mvc_core.Models;
using Microsoft.AspNetCore.Mvc;

namespace curso_mvc_core.Controllers
{
    public class AlumnoController : Controller
    {
        private EscuelaContext _context { get; set; }
        public AlumnoController(EscuelaContext context)
        {
            _context = context;
        }

        [Route("[Controller]")]
        [Route("[Controller]/Index")]
        [Route("[Controller]/Index/{alumnoId}")]
        public IActionResult Index(string alumnoId)
        {
            /*
            var alumno = new Alumno();
            alumno.Id = Guid.NewGuid().ToString();
            alumno.Nombre = "Jhon Phileppe Reyes Flores";
            */
            var alumno = _context.Alumnos.Where(x => x.Id == alumnoId).FirstOrDefault();
            if (alumno is null)
            {
                return View("MultiAlumno", _context.Alumnos.ToList());
            }

            return View(alumno);
        }

        public IActionResult MultiAlumno()
        {
            /*var listalumnos = new List<Alumno>() {
                new Alumno() { UniqueId = Guid.NewGuid().ToString(), Nombre ="Javier Reyes Flores" },
                new Alumno() { UniqueId = Guid.NewGuid().ToString(), Nombre ="Vanessa Valentina Guevara Aguilar"},
                new Alumno() { UniqueId = Guid.NewGuid().ToString(), Nombre ="José Reyes Villegas" },
                new Alumno() { UniqueId = Guid.NewGuid().ToString(), Nombre ="Christian David Gomez Garay" },
                };*/

            //var listalumnos = GenerarAlumnosAlAzar();
            var listalumnos = _context.Alumnos.ToList();
            return View(listalumnos);
        }
    }
}