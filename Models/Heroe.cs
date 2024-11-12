
namespace SuperHeroesApp.Models
{
    // Clase abstracta Heroe: no se puede crear directamente, sirve de base para otras clases.
    internal abstract class Heroe
    {
        // Propiedad abstracta Nombre: cada héroe debe tener un nombre, pero cómo lo maneja depende de la clase hija.
        public abstract string Nombre { get; set; }

        // Método abstracto SalvarElMundo: cada héroe tiene su forma de salvar el mundo, debe implementarlo en las clases hijas.
        public abstract string SalvarElMundo();

        // Método virtual SalvarLaTierra: tiene una implementación por defecto, pero las clases hijas pueden cambiarla si quieren.
        public virtual string SalvarLaTierra()
        {
            return $"{Nombre} ha salvado la tierra"; // Mensaje por defecto.
        }
    }
}
