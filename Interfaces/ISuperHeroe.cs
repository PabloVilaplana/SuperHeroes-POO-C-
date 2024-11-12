using System.Text;

namespace SuperHeroesApp.Interfaces
{
    // Interfaz ISuperHeroe: define las propiedades y métodos básicos que todo superhéroe debe tener.
    internal interface ISuperHeroe
    {
        // Propiedades para el ID, nombre y la identidad secreta del superhéroe.
        int Id { get; set; } // Identificador único del superhéroe.
        string Nombre { get; set; } // Nombre público del superhéroe.
        string IdentidadSecreta { get; set; } // Nombre secreto del superhéroe.

        // Método que devuelve la información del superhéroe como un texto formateado.
        // Utiliza StringBuilder para construir el texto de manera eficiente.
        string GetSuperHeroe()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Id: {Id}");
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Identidad secreta: {IdentidadSecreta}");
            return sb.ToString();
        }
    }
}
