using SuperHeroesApp;
using SuperHeroesApp.Models;

// Crear una instancia de ImprimirInfo para imprimir información de superhéroes.
var imprimirInfo = new ImprimirInfo();

// Crear objetos SuperPoder para Superman.
var poderVolar = new SuperPoder();
poderVolar.Nombre = "Volar"; // Definir el nombre del poder.
poderVolar.Descripcion = "Capacidad para volar y planear en el aire"; // Descripción del poder.
poderVolar.Nivel = NivelPoder.NivelDos; // Nivel del poder.

var superFuerza = new SuperPoder();
superFuerza.Nombre = "Super fuerza"; // Definir el nombre del poder.
superFuerza.Nivel = NivelPoder.NivelTres; // Nivel del poder.

var regeneracion = new SuperPoder();
regeneracion.Nombre = "Regeneración"; // Definir el nombre del poder.
regeneracion.Nivel = NivelPoder.NivelTres; // Nivel del poder.

// Crear un superhéroe (Superman).
var superman = new SuperHeroe();
superman.Id = 1;
superman.Nombre = "   Superman   "; // Eliminar los espacios extra.
superman.IdentidadSecreta = "Clark Kent"; // Definir la identidad secreta.
superman.Ciudad = "Metropolis"; // Ciudad de Superman.
superman.PuedeVolar = true; // Definir si puede volar.

imprimirInfo.ImprimirSuperHeroe(superman); // Imprimir la información de Superman.

// Crear y asignar poderes a Superman.
List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superFuerza);
superman.SuperPoderes = poderesSuperman; // Asignar los poderes a Superman.

string resultSuperPoderes = superman.UsarSuperPoderes(); // Usar los poderes de Superman.
Console.WriteLine(resultSuperPoderes); // Imprimir el uso de poderes.

string resultSalvarMundo = superman.SalvarElMundo(); // Superman salva el mundo.
Console.WriteLine(resultSalvarMundo);

string resultSalvarTierra = superman.SalvarLaTierra(); // Superman salva la tierra.
Console.WriteLine(resultSalvarTierra);

// Crear un anti-héroe (Wolverine).
var wolverine = new AntiHeroe();
wolverine.Id = 5;
wolverine.Nombre = "Wolverine"; // Nombre de Wolverine.
wolverine.IdentidadSecreta = "Logan"; // Identidad secreta de Wolverine.
wolverine.PuedeVolar = false; // Wolverine no puede volar.

imprimirInfo.ImprimirSuperHeroe(wolverine); // Imprimir la información de Wolverine.

// Crear y asignar poderes a Wolverine.
List<SuperPoder> poderesWolverine = new List<SuperPoder>();
poderesWolverine.Add(regeneracion);
poderesWolverine.Add(superFuerza);
wolverine.SuperPoderes = poderesWolverine; // Asignar los poderes a Wolverine.

string resultWolverinePoderes = wolverine.UsarSuperPoderes(); // Usar los poderes de Wolverine.
Console.WriteLine(resultWolverinePoderes); // Imprimir el uso de poderes.

string accionAntiheroe = wolverine.RealizarAccionDeAntiheroe("Ataca la policia"); // Realizar acción de anti-héroe.
Console.WriteLine(accionAntiheroe); // Imprimir la acción realizada por el anti-héroe.

// Enum NivelPoder: define los niveles de poder.
enum NivelPoder
{
    NivelUno, // Nivel 1.
    NivelDos, // Nivel 2.
    NivelTres // Nivel 3.
}

// Record para representar un superhéroe de forma inmutable.
public record SuperHeroRecord(int Id, string Nombre, string IdentidadSecreta);
