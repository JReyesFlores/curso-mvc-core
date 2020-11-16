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

            return listaAlumnos.OrderBy((al) => al.Id).ToList();
        }
    }

}