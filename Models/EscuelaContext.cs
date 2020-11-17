using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace curso_mvc_core.Models
{
    public class EscuelaContext : DbContext
    {
        public DbSet<Escuela> Escuelas { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Evaluacion> Evaluaciones { get; set; }

        //Se crea un constructor que tome las propiedades de las clases y las mapee con el destino de base de datos
        public EscuelaContext(DbContextOptions<EscuelaContext> options) : base(options)
        {
        }

        //OnModelCreating => Es un método que se lanza al crear la base de datos.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Con esto no rompemos el flujo del proceso lanzado por el EntityframeWorkCore
            base.OnModelCreating(modelBuilder);

            //Luego de esto ya puede procesarse otras cosas
            var escuela = new Escuela();
            escuela.AnioDeCreacion = 2020;
            escuela.Id = Guid.NewGuid().ToString();
            escuela.Nombre = "Platzi";
            escuela.Direccion = "Av. Springfield 123";
            escuela.Ciudad = "Bogota";
            escuela.Pais = "Colombia";
            escuela.TipoEscuela = TiposEscuela.Secundaria;

            //Cargar Cursos de la Escuela
            var cursos = CargarCursos(escuela);

            //x cada curso cargar asignaturas
            var asignaturas = CargarAsignaturas(cursos);

            //x cada curso cargar alumnos
            var alumnos = CargarAlumnos(cursos);

            modelBuilder.Entity<Escuela>().HasData(escuela);
            modelBuilder.Entity<Curso>().HasData(cursos.ToArray());
            modelBuilder.Entity<Asignatura>().HasData(asignaturas.ToArray());
            modelBuilder.Entity<Alumno>().HasData(alumnos.ToArray());

            /*
            //HasData => Método que inserta información en caso no encuentre datos
            modelBuilder.Entity<Escuela>().HasData(
                escuela
            );

            //Cargando datos a la bdtemp y a las diferentes entidades
            modelBuilder.Entity<Asignatura>().HasData(
                new Asignatura { Nombre = "Matemáticas", Id = Guid.NewGuid().ToString() },
                new Asignatura { Nombre = "Educación Física", Id = Guid.NewGuid().ToString() },
                new Asignatura { Nombre = "Castellano", Id = Guid.NewGuid().ToString() },
                new Asignatura
                {
                    Nombre = "Ciencias Naturales",
                    Id = Guid.NewGuid().ToString()
                }
            );

            modelBuilder.Entity<Alumno>().HasData(GenerarAlumnosAlAzar().ToArray());
            */

        }

        private List<Alumno> CargarAlumnos(List<Curso> cursos)
        {
            var listaAlumnos = new List<Alumno>();

            Random rnd = new Random();
            foreach (var curso in cursos)
            {
                int cantRandom = rnd.Next(5, 20);
                var tmplist = GenerarAlumnosAlAzar(curso, cantRandom);
                listaAlumnos.AddRange(tmplist);
            }
            return listaAlumnos;
        }

        private static List<Asignatura> CargarAsignaturas(List<Curso> cursos)
        {
            var listaCompleta = new List<Asignatura>();
            foreach (var curso in cursos)
            {
                var tmpList = new List<Asignatura> {
                            new Asignatura{
                                CursoId = curso.Id,
                                Nombre="Matemáticas"} ,
                            new Asignatura{ CursoId = curso.Id, Nombre="Educación Física"},
                            new Asignatura{ CursoId = curso.Id, Nombre="Castellano"},
                            new Asignatura{ CursoId = curso.Id, Nombre="Ciencias Naturales"},
                            new Asignatura{ CursoId = curso.Id, Nombre="Programación"}

                };
                listaCompleta.AddRange(tmpList);
            }

            return listaCompleta;
        }

        private static List<Curso> CargarCursos(Escuela escuela)
        {
            return new List<Curso>(){
                        new Curso{
                            EscuelaId = escuela.Id,
                            Nombre = "101",
                            Jornada = TiposJornada.Mañana,
                            Direccion ="Los Olivos" },
                        new Curso{EscuelaId = escuela.Id, Nombre = "201", Jornada = TiposJornada.Mañana, Direccion ="Los Olivos" },
                        new Curso{EscuelaId = escuela.Id, Nombre = "301", Jornada = TiposJornada.Mañana, Direccion ="Los Olivos"},
                        new Curso{EscuelaId = escuela.Id, Nombre = "401", Jornada = TiposJornada.Tarde, Direccion ="Los Olivos"},
                        new Curso{EscuelaId = escuela.Id, Nombre = "501", Jornada = TiposJornada.Tarde, Direccion ="Los Olivos"},
            };
        }

        private List<Alumno> GenerarAlumnosAlAzar(Curso curso, int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno
                               {
                                   CursoId = curso.Id,
                                   Nombre = $"{n1} {n2} {a1}"
                               };

            return listaAlumnos.OrderBy((al) => al.Id).Take(cantidad).ToList();
        }
    }

}