
namespace SuperHeroesApp.Models
{
    // Clase SuperPoder: define los poderes que pueden tener los superhéroes.
    internal class SuperPoder
    {
        // Propiedad Nombre: el nombre del superpoder.
        public string Nombre;

        // Propiedad Descripcion: una descripción del superpoder.
        public string Descripcion;

        // Propiedad Nivel: el nivel del superpoder, por defecto es NivelUno.
        public NivelPoder Nivel;

        // Constructor: inicializa el nivel del superpoder como NivelUno.
        public SuperPoder()
        {
            Nivel = NivelPoder.NivelUno;
        }
    }
}
