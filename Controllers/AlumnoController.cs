using System;
using System.Collections.Generic;
using System.Linq;
using curso_mvc_core.Models;
using Microsoft.AspNetCore.Mvc;

namespace curso_mvc_core.Controllers
{
    public class AlumnoController : Controller
    {
        public IActionResult Index()
        {
            var alumno = new Alumno();
            alumno.UniqueId = Guid.NewGuid().ToString();
            alumno.Nombre = "Jhon Phileppe Reyes Flores";

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

            var listalumnos = GenerarAlumnosAlAzar();
            return View(listalumnos);
        }

        private List<Alumno> GenerarAlumnosAlAzar()
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { Nombre = $"{n1} {n2} {a1}" };

            return listaAlumnos.OrderBy((al) => al.UniqueId).ToList();
        }
    }
}