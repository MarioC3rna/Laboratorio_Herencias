﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Laboratorio
{
    /// <summary>
    /// Esta Clase Padre tiene 4 errores lógicos
    /// debe de encontrarlos y corregirlos
    /// documente los errores encontrados y las correcciones realizadas
    /// </summary>
    internal class VideoJuego
    {
        private string titulo;
        private string desarrolladora;
        private double calificacion;
        private int anioLanzamiento;
        private bool jugando;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Desarrolladora
        {
            get { return desarrolladora; }
            set { desarrolladora = value; }
        }

        public double Calificacion
        {
            get { return calificacion; }
            set { calificacion = value; }
        }

        public int AnioLanzamiento
        {
            get { return anioLanzamiento; }
            set
            {
                
                anioLanzamiento = value;
            }
        }

        public string MostrarInformacion()
        {
            return "Título: " + Titulo + " \nDesarrolladora: " + desarrolladora + " \nCalificación: " + Calificacion + " \nAño de Lanzamiento: " + AnioLanzamiento;


        }

        public static void saludo()
        {
            Console.WriteLine("Hi Gamer:");
        }


        public void IniciarPartida()
        {
            jugando = true;
            Console.WriteLine("¡Partida iniciada!");
        }

        public void DetenerPartida()
        {
            if (jugando)
            {
                jugando = false;
                Console.WriteLine("Partida detenida.");
            }
            else
            {
                Console.WriteLine("La partida ya está detenida.");
            }
        }

        public void TerminarJuego()
        {
            if (jugando)
            {
                jugando = false;
                Console.WriteLine("Juego terminado.");
            }
            else
            {
                Console.WriteLine("El juego ya está terminado.");
            }
        }

    }
}

