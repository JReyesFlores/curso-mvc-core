using System;

namespace curso_mvc_core.Models
{
    //ABSTRACT => Esta clase puede tener clases hijas, más no se puede instanciar o crear objetos
    public abstract class ObjetoEscuelaBase {
        public string Id { get; set; }
        public virtual string Nombre { get; set; }
        public ObjetoEscuelaBase() {
            Id = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return $"{Nombre}, {Id}";
        }

    }
}