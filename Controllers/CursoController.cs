using System.Linq;
using curso_mvc_core.Models;
using Microsoft.AspNetCore.Mvc;

namespace curso_mvc_core.Controllers
{
    public class CursoController : Controller
    {
        private EscuelaContext _context;
        public CursoController(EscuelaContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("[Controller]")]
        [Route("[Controller]/index")]
        [Route("[Controller]/{cursoId}")]
        [Route("[Controller]/index/{cursoId}")]
        public IActionResult Index(string cursoId)
        {
            var curso = _context.Cursos.Where(x => x.Id == cursoId).FirstOrDefault();
            if (curso is null)
            {
                return View("MultiCurso", _context.Cursos.ToList());
            }
            return View(curso);
        }

        [HttpGet]
        public IActionResult MultiCurso()
        {
            return View(_context.Cursos.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Curso curso)
        {
            if (ModelState.IsValid)
            {
                var escuela = _context.Escuelas.FirstOrDefault();
                curso.EscuelaId = escuela.Id;

                _context.Add(curso);
                _context.SaveChanges();

                ViewBag.Mensaje = "Curso creado correctamente!!";
                return View("Index", curso);
            }
            else
            {
                return View(curso);
            }
        }
    }
}