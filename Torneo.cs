using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoFutbolAmautas
{
    // Clase Torneo que contiene una lista de equipos y métodos para gestionarlos
    class Torneo
    {
        public string Nombre { get; set; }
        public List<Equipo> Equipos { get; set; }

        // Constructor que inicializa el torneo con su nombre y una lista vacía de equipos
        public Torneo(string nombre)
        {
            Nombre = nombre;
            Equipos = new List<Equipo>();
        }

        // Método para agregar un equipo al torneo
        public void AgregarEquipo(Equipo equipo)
        {
            Equipos.Add(equipo);
            Console.WriteLine($"Equipo {equipo.Nombre} agregado al torneo {Nombre}.");
        }

        // Método para eliminar un equipo del torneo por su nombre
        public void EliminarEquipo(string nombreEquipo)
        {
            Equipo equipoAEliminar = Equipos.Find(e => e.Nombre == nombreEquipo);
            if (equipoAEliminar != null)
            {
                Equipos.Remove(equipoAEliminar);
                Console.WriteLine($"Equipo {nombreEquipo} eliminado del torneo {Nombre}.");
            }
            else
            {
                Console.WriteLine($"Equipo {nombreEquipo} no encontrado en el torneo {Nombre}.");
            }
        }

        // Método que muestra todos los equipos registrados en el torneo
        public void MostrarEquipos()
        {
            if (Equipos.Count == 0)
            {
                Console.WriteLine("No hay equipos registrados.");
            }
            else
            {
                Console.WriteLine($"Equipos en el torneo {Nombre}:");
                // Recorre la lista de equipos y muestra sus jugadores
                foreach (var equipo in Equipos)
                {
                    equipo.MostrarJugadores();
                    Console.WriteLine();
                }
            }
        }
    }
}
