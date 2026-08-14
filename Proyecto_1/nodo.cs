using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_1
{
    public class nodo
    {
        // Getters públicos para permitir lectura desde MatrizOrtogonal
        public char dato { get; set; }
        public int fila { get; set; }
        public int columna { get; set; }

        public nodo? anterior;
        public nodo? arriba;
        public nodo? abajo;
        public nodo? siguiente;

        public nodo(char d, int f, int c)
        {
            dato = d;
            fila = f;
            columna = c;
            anterior = null;
            arriba = null;
            abajo = null;
            siguiente = null;
        }

        public void ActualizarDato(char nuevoDato)
        {
            dato = nuevoDato;
        }
    }
}
