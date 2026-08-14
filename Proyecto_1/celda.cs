using Microsoft.VisualBasic;

namespace Proyecto_1
{
    public class celda
    {
        public int Fila{get; set;}
        public int Columna{get; set;}
        public string Tipo{get; set;}
        public int CapacidadCombate{get; set;}

        public celda (int fila, int columna, string tipo, int capacidadCombate=0)
        {
            Fila=fila;
            Columna=columna;
            Tipo=tipo;
            CapacidadCombate=capacidadCombate;
        }

    }

}