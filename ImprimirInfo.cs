using SuperHeroesApp.Interfaces;

namespace SuperHeroesApp
{
    // Clase ImprimirInfo: se encarga de imprimir la información del superhéroe.
    internal class ImprimirInfo
    {
        // Método ImprimirSuperHeroe: recibe un superhéroe (a través de la interfaz ISuperHeroe)
        // y muestra su información en la consola.
        public void ImprimirSuperHeroe(ISuperHeroe superHeroe)
        {
            Console.WriteLine(superHeroe.GetSuperHeroe()); // Imprime la info usando el método GetSuperHeroe.
        }
    }
}
