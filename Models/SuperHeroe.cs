using SuperHeroesApp.Interfaces;
using System.Text;

namespace SuperHeroesApp.Models
{
    // Clase SuperHeroe: hereda de Heroe y de la interfaz ISuperHeroe.
    // Define propiedades y comportamientos específicos de un superhéroe.
    class SuperHeroe : Heroe, ISuperHeroe
    {
        private string _Nombre;

        // Propiedad Id: identificador único del superhéroe, por defecto es 1.
        public int Id { get; set; } = 1;

        // Propiedad Nombre: se usa para obtener y establecer el nombre del superhéroe.
        // El nombre se recorta para eliminar espacios innecesarios.
        public override string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value.Trim(); }
        }

        // Propiedad NombreEIdentidadSecreta: muestra el nombre público y la identidad secreta.
        public string NombreEIdentidadSecreta
        {
            get { return $"{Nombre} ({IdentidadSecreta})"; }
        }

        // Propiedad IdentidadSecreta: guarda la identidad secreta del superhéroe.
        public string IdentidadSecreta { get; set; }

        // Propiedad Ciudad: ciudad donde el superhéroe vive.
        public string Ciudad;

        // Lista de SuperPoderes: contiene los poderes del superhéroe.
        public List<SuperPoder> SuperPoderes = new List<SuperPoder>();

        // Propiedad PuedeVolar: indica si el superhéroe puede volar.
        public bool PuedeVolar;

        // Constructor: inicializa el Id y establece valores por defecto para los poderes y la capacidad de volar.
        public SuperHeroe()
        {
            Id = 1;
            SuperPoderes = new List<SuperPoder>();
            PuedeVolar = false;
        }

        // Método UsarSuperPoderes: devuelve un mensaje con los poderes que el superhéroe está usando.
        public string UsarSuperPoderes()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in SuperPoderes)
            {
                sb.AppendLine($"{NombreEIdentidadSecreta} esta usando el super poder {item.Nombre}!!");
            }

            return sb.ToString();
        }

        // Método SalvarElMundo: devuelve un mensaje indicando que el superhéroe ha salvado el mundo.
        public override string SalvarElMundo()
        {
            return $"{NombreEIdentidadSecreta} ha salvado el mundo";
        }

        // Método SalvarLaTierra: devuelve un mensaje indicando que el superhéroe ha salvado la tierra.
        public override string SalvarLaTierra()
        {
            return $"{NombreEIdentidadSecreta} ha salvado la tierra";
        }
    }

}
