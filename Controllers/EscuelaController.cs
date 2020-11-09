using System;
using curso_mvc_core.Models;
using Microsoft.AspNetCore.Mvc;

namespace curso_mvc_core.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.AnioDeCreacion = 2020;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "Platzi";
            escuela.Direccion = "Av. Springfield 123";
            escuela.Ciudad = "Bogota";
            escuela.Pais = "Colombia";
            escuela.TipoEscuela = TiposEscuela.Secundaria;

            /* ViewBag = Almacena datos dinamicos */
            ViewBag.cosaDinamica = "La monja";

            /* Cualquier dato es enviado desde el controlador a la Vista. */
            return View(escuela);
        }
    }
}