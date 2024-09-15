using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoFutbolAmautas
{
    // Clase Jugador que define las propiedades de un jugador
    class Jugador
    {
        public string Nombre { get; set; }
        public string Posicion { get; set; }
        public int NumeroCamiseta { get; set; }

        // Constructor que inicializa un jugador con su nombre, posición y número de camiseta
        public Jugador(string nombre, string posicion, int numeroCamiseta)
        {
            Nombre = nombre;
            Posicion = posicion;
            NumeroCamiseta = numeroCamiseta;
        }

        // Método que muestra la información del jugador en la consola
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Posición: {Posicion}, Número de Camiseta: {NumeroCamiseta}");
        }
    }
}
