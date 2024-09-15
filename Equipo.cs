using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoFutbolAmautas
{
    // Clase Equipo que representa un equipo de fútbol
    class Equipo
    {
        public string Nombre { get; set; }
        public List<Jugador> Jugadores { get; set; }

        // Constructor que inicializa un equipo con su nombre y una lista vacía de jugadores
        public Equipo(string nombre)
        {
            Nombre = nombre;
            Jugadores = new List<Jugador>();
        }

        // Método para agregar un jugador al equipo, hasta un máximo de 20 jugadores
        public void AgregarJugador(Jugador jugador)
        {
            if (Jugadores.Count < 20)
            {
                Jugadores.Add(jugador);
                Console.WriteLine($"Jugador {jugador.Nombre} agregado al equipo {Nombre}.");
            }
            else
            {
                Console.WriteLine($"El equipo {Nombre} ya tiene 20 jugadores.");
            }
        }

        // Método para eliminar un jugador del equipo por su nombre
        public void EliminarJugador(string nombreJugador)
        {
            // Busca el jugador en la lista según su nombre
            Jugador jugadorAEliminar = Jugadores.Find(j => j.Nombre == nombreJugador);
            if (jugadorAEliminar != null)
            {
                Jugadores.Remove(jugadorAEliminar);
                Console.WriteLine($"Jugador {nombreJugador} eliminado del equipo {Nombre}.");
            }
            else
            {
                Console.WriteLine($"Jugador {nombreJugador} no encontrado en el equipo {Nombre}.");
            }
        }

        // Método que muestra la lista de jugadores del equipo
        // Si hay menos de 20 jugadores, muestra las posiciones vacías
        public void MostrarJugadores()
        {
            Console.WriteLine($"Equipo: {Nombre}");
            int jugadorIndex = 1;
            foreach (var jugador in Jugadores)
            {
                Console.WriteLine($"{jugadorIndex}. {jugador.Nombre} - {jugador.Posicion} - Camiseta: {jugador.NumeroCamiseta}");
                jugadorIndex++;
            }
            // Imprime los lugares vacíos restantes hasta el número 20
            for (int i = jugadorIndex; i <= 20; i++)
            {
                Console.WriteLine($"{i}. Vacío");
            }
        }
    }
}
