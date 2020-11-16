using System;
using System.Collections.Generic;
using System.Linq;
using curso_mvc_core.Models;
using Microsoft.AspNetCore.Mvc;

namespace curso_mvc_core.Controllers
{
    public class AsignaturaController : Controller
    {

        private EscuelaContext _context { get; set; }
        public AsignaturaController(EscuelaContext context)
        {
            this._context = context;
        }
        /*public IActionResult Index()
        {
            ////Desde un modelo
            //var asignatura = new Asignatura();
            //asignatura.Id = Guid.NewGuid().ToString();
            //asignatura.Nombre = "Programación";
            
            var asignatura = _context.Asignaturas.FirstOrDefault();

            ViewBag.cosaDinamica = "La Monja - Asignatura";
            ViewBag.Fecha = DateTime.UtcNow;

            return View(asignatura);
        }
        */

        [Route("[Controller]")]
        [Route("[Controller]/Index")]
        [Route("[Controller]/Index/{asignaturaId}")]
        public IActionResult Index(string asignaturaId)
        {
            var asignatura = (from asig in _context.Asignaturas
                              where asig.Id == asignaturaId
                              select asig).SingleOrDefault();

            if (asignatura is null)
            {
                return View("MultiAsignatura", _context.Asignaturas.ToList());
            }
            return View(asignatura);
        }

        public IActionResult MultiAsignatura()
        {
            /*
            var listaAsignaturas = new List<Asignatura>(){
                            new Asignatura{Nombre="Matemáticas", Id= Guid.NewGuid().ToString()} ,
                            new Asignatura{Nombre="Educación Física", Id= Guid.NewGuid().ToString()},
                            new Asignatura{Nombre="Castellano", Id= Guid.NewGuid().ToString()},
                            new Asignatura{Nombre="Ciencias Naturales", Id= Guid.NewGuid().ToString()}
                };
            */

            var listaAsignaturas = _context.Asignaturas.ToList();
            ViewBag.cosaDinamica = "La Monja - MultiAsignatura";
            ViewBag.Fecha = DateTime.UtcNow;

            return View(listaAsignaturas);
        }
    }
}