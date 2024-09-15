using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoFutbolAmautas
{
    // Clase principal del programa, que contiene el menú interactivo
    class Program
    {
        static Torneo torneo = new Torneo("Copa Nacional AMAUTAS");

        static void Main(string[] args)
        {
            Menu();
        }

        // Menú interactivo que permite al usuario realizar diferentes operaciones
        static void Menu()
        {
            int opcion = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Clear();
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("+===******* Menú del Torneo de Fútbol AMAUTAS *******==+");
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("+                                                      +");
                Console.WriteLine("+   1. Agregar equipo                                  +");
                Console.WriteLine("+   2. Eliminar equipo                                 +");
                Console.WriteLine("+   3. Agregar jugador a un equipo                     +");
                Console.WriteLine("+   4. Eliminar jugador de un equipo                   +");
                Console.WriteLine("+   5. Mostrar equipos registrados                     +");
                Console.WriteLine("+   6. Salir                                           +");
                Console.WriteLine("+                                                      +");
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.Write    ("+Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                // Opciones del menú que llaman a diferentes métodos
                switch (opcion)
                {
                    case 1:
                        AgregarEquipo();
                        break;
                    case 2:
                        EliminarEquipo();
                        break;
                    case 3:
                        AgregarJugadorAEquipo();
                        break;
                    case 4:
                        EliminarJugadorDeEquipo();
                        break;
                    case 5:
                        MostrarEquipos();
                        break;
                    case 6:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (opcion != 6)
                {
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 6); // El ciclo continúa hasta que se selecciona la opción de salir
        }

        
        // Método para agregar un equipo al torneo
        static void AgregarEquipo()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Ingrese el nombre del equipo: ");
            string nombreEquipo = Console.ReadLine();
            Equipo equipo = new Equipo(nombreEquipo);
            torneo.AgregarEquipo(equipo);
        }

        // Método para eliminar un equipo del torneo
        static void EliminarEquipo()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Ingrese el nombre del equipo a eliminar: ");
            string nombreEquipo = Console.ReadLine();
            torneo.EliminarEquipo(nombreEquipo);
        }

        // Método para agregar un jugador a un equipo
        static void AgregarJugadorAEquipo()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Ingrese el nombre del equipo: ");
            string nombreEquipo = Console.ReadLine();
            // Busca el equipo en la lista
            Equipo equipo = torneo.Equipos.Find(e => e.Nombre == nombreEquipo);

            if (equipo != null)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("Ingrese el nombre del jugador: ");
                string nombreJugador = Console.ReadLine();
                Console.Write("Ingrese la posición del jugador: ");
                string posicion = Console.ReadLine();
                Console.Write("Ingrese el número de camiseta del jugador: ");
                int numeroCamiseta = int.Parse(Console.ReadLine());

                // Crea un nuevo objeto Jugador y lo agrega al equipo
                Jugador jugador = new Jugador(nombreJugador, posicion, numeroCamiseta);
                equipo.AgregarJugador(jugador);
            }
            else
            {
                Console.WriteLine($"Equipo {nombreEquipo} no encontrado.");
            }
        }

        // Método para eliminar un jugador de un equipo
        static void EliminarJugadorDeEquipo()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Ingrese el nombre del equipo: ");
            string nombreEquipo = Console.ReadLine();
            // Busca el equipo en la lista
            Equipo equipo = torneo.Equipos.Find(e => e.Nombre == nombreEquipo);

            if (equipo != null)
            {
                Console.Write("Ingrese el nombre del jugador a eliminar: ");
                string nombreJugador = Console.ReadLine();
                equipo.EliminarJugador(nombreJugador);
            }
            else
            {
                Console.WriteLine($"Equipo {nombreEquipo} no encontrado.");
            }
        }

        // Método para mostrar los equipos registrados
        static void MostrarEquipos()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            torneo.MostrarEquipos();
        }
    }
}
