using System;
using System.Collections.Generic;
using curso_mvc_core.Models;
using Microsoft.AspNetCore.Mvc;

namespace curso_mvc_core.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            var asignatura = new Asignatura();
            asignatura.UniqueId = Guid.NewGuid().ToString();
            asignatura.Nombre = "Programación";

            ViewBag.cosaDinamica = "La Monja - Asignatura";
            ViewBag.Fecha = DateTime.UtcNow;

            return View(asignatura);
        }

        public IActionResult MultiAsignatura()
        {
            var listaAsignaturas = new List<Asignatura>(){
                            new Asignatura{Nombre="Matemáticas", UniqueId= Guid.NewGuid().ToString()} ,
                            new Asignatura{Nombre="Educación Física", UniqueId= Guid.NewGuid().ToString()},
                            new Asignatura{Nombre="Castellano", UniqueId= Guid.NewGuid().ToString()},
                            new Asignatura{Nombre="Ciencias Naturales", UniqueId= Guid.NewGuid().ToString()}
                };

            ViewBag.cosaDinamica = "La Monja - MultiAsignatura";
            ViewBag.Fecha = DateTime.UtcNow;

            return View(listaAsignaturas);
        }
    }
}