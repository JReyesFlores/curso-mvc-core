using System;
using curso_mvc_core.Models;
using Microsoft.AspNetCore.Mvc;

namespace curso_mvc_core.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela = new EscuelaModel();
            escuela.AnioFundacion = 2020;
            escuela.EscuelaId = Guid.NewGuid().ToString();
            escuela.Nombre = "Platzi";

            /* Cualquier dato es enviado desde el controlador a la Vista. */
            return View(escuela);
        }
    }
}