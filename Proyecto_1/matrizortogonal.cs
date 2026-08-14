using System;

namespace Proyecto_1
{
    class matrizortogonal
    {
        private nodo raiz;

        public matrizortogonal()
        {
            // CORREGIDO: La raíz debe estar en (-1, -1) para no colisionar con la fila/columna 0
            raiz = new nodo('X', -1, -1);
        }

        private nodo ObtenerocrearcabeceraFila(int fila)
        {
            nodo actual = raiz;
            while (actual.abajo != null && actual.abajo.fila < fila)
            {
                actual = actual.abajo;
            }

            if (actual.abajo != null && actual.abajo.fila == fila)
            {
                return actual.abajo;
            }

            nodo nuevaCabecera = new nodo(' ', fila, -1);

            nuevaCabecera.abajo = actual.abajo;
            nuevaCabecera.arriba = actual;

            if (actual.abajo != null)
            {
                actual.abajo.arriba = nuevaCabecera;
            }

            actual.abajo = nuevaCabecera;

            return nuevaCabecera;
        }

        private nodo ObtenerOcrearCabeceraColumna(int columna)
        {
            nodo actual = raiz;
            while (actual.siguiente != null && actual.siguiente.columna < columna)
            {
                actual = actual.siguiente;
            }

            if (actual.siguiente != null && actual.siguiente.columna == columna)
            {
                return actual.siguiente;
            }

            // CORREGIDO: Fila = -1, Columna = columna
            nodo nuevaCabecera = new nodo(' ', -1, columna);
            nuevaCabecera.siguiente = actual.siguiente;
            nuevaCabecera.anterior = actual;

            if (actual.siguiente != null)
            {
                actual.siguiente.anterior = nuevaCabecera;
            }

            actual.siguiente = nuevaCabecera;
            return nuevaCabecera;
        }

        public void insertar(char dato, int fila, int columna)
        {
            nodo cabeceraFila = ObtenerocrearcabeceraFila(fila);
            nodo cabeceraColumna = ObtenerOcrearCabeceraColumna(columna);

            nodo nuevo = new nodo(dato, fila, columna);
            InsertarEnfila(nuevo, cabeceraFila);
            InsertarEnColumna(nuevo, cabeceraColumna);
        }

        private void InsertarEnfila(nodo nuevo, nodo cabeceraFila)
        {
            nodo actual = cabeceraFila;
            while (actual.siguiente != null && actual.siguiente.columna < nuevo.columna)
            {
                actual = actual.siguiente;
            }

            if (actual.siguiente != null && actual.siguiente.columna == nuevo.columna)
            {
                actual.siguiente.dato = nuevo.dato;
                return;
            }

            nuevo.siguiente = actual.siguiente;
            nuevo.anterior = actual;

            if (actual.siguiente != null)
            {
                actual.siguiente.anterior = nuevo;
            }

            actual.siguiente = nuevo;
        }

        private void InsertarEnColumna(nodo nuevo, nodo cabaceraColumna)
        {
            nodo actual = cabaceraColumna;
            while (actual.abajo != null && actual.abajo.fila < nuevo.fila)
            {
                actual = actual.abajo;
            }

            // CORREGIDO: Actualizar el dato si ya existe el nodo
            if (actual.abajo != null && actual.abajo.fila == nuevo.fila)
            {
                actual.abajo.dato = nuevo.dato;
                return;
            }

            nuevo.abajo = actual.abajo;
            nuevo.arriba = actual;

            if (actual.abajo != null)
            {
                actual.abajo.arriba = nuevo;
            }

            actual.abajo = nuevo;
        }

        public void ImprimirMapa()
        {
            if (raiz.abajo == null || raiz.siguiente == null)
            {
                Console.WriteLine("La matriz está vacía.");
                return;
            }

            // Calcular dimensiones
            int minfila = raiz.abajo.fila;
            int maxfila = minfila;
            nodo? tempfila = raiz.abajo;
            while (tempfila != null)
            {
                maxfila = tempfila.fila;
                tempfila = tempfila.abajo;
            }

            int mincol = raiz.siguiente.columna;
            int maxcolumna = mincol;
            nodo? tempcolumna = raiz.siguiente;
            while (tempcolumna != null)
            {
                maxcolumna = tempcolumna.columna;
                tempcolumna = tempcolumna.siguiente;
            }

            nodo? cabeceraFila = raiz.abajo;

            // Recorrer todas las filas
            for (int f = minfila; f <= maxfila; f++)
            {
                nodo? actual = null;

                if (cabeceraFila != null && cabeceraFila.fila == f)
                {
                    actual = cabeceraFila.siguiente;
                    cabeceraFila = cabeceraFila.abajo;
                }

                // Recorrer todas las columnas
                for (int c = mincol; c <= maxcolumna; c++)
                {
                    if (actual != null && actual.columna == c)
                    {
                        Console.Write($"[{actual.dato}] ");
                        actual = actual.siguiente;
                    }
                    else
                    {
                        Console.Write("[ ] ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
