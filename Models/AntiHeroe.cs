
namespace SuperHeroesApp.Models
{
    // Clase AntiHeroe: hereda de SuperHeroe, por lo que tiene todas sus propiedades y métodos.
    internal class AntiHeroe : SuperHeroe
    {
        // Método RealizarAccionDeAntiheroe: permite al antihéroe realizar una acción y devuelve un mensaje con la acción.
        public string RealizarAccionDeAntiheroe(string accion)
        {
            return $"El Antiheroe {NombreEIdentidadSecreta} ha realizado: {accion}";
        }
    }
}
