using System.Collections;

namespace Proyecto_1
{
    public class ciudad
    {
        public string Nombreciudad{get; private set;}
        public int TotalFilas{get; private set;}
        public int TotalColumnas{get; private set;}
        public matrizortogonal Mapa {get; private set;}
        
         public listapuntos ListaEntradas { get; private set; }
        public listapuntos ListaRecursos { get; private set; }
        public listapuntos ListaCiviles { get; private set; }
        public listapuntos ListaMilitares { get; private set; }
        public ciudad (string nombreCiudad, int totalFilas,int totalColumnas)
        {
            Nombreciudad=nombreCiudad;
            TotalFilas=totalFilas;
            TotalColumnas=totalColumnas;

            Mapa =new matrizortogonal
            {
                nombreciudad=nombreCiudad,
                totalfilas=totalFilas,
                totalcolumnas=totalColumnas

            };

            ListaEntradas=new listapuntos();
            ListaCiviles=new listapuntos();
            ListaRecursos=new listapuntos();
            ListaMilitares=new listapuntos ();

        }

        public void agregarelemento(char tipo, int fila, int columna)
        {
            Mapa.insertar(tipo,fila,columna);
            switch (tipo)
            {
                case 'E': ListaEntradas.agregar(new nodo(tipo,fila,columna)); 
                break;
                case 'C': ListaCiviles.agregar(new nodo(tipo,fila, columna));
                break;
                case 'R': ListaRecursos.agregar(new nodo(tipo,fila,columna));
                break;
                case 'M': ListaMilitares.agregar(new nodo(tipo,fila,columna));
                break;
                
            }

        }
        public void MostrarCiudad()
        {
            Console.WriteLine("Ciudad: "+Nombreciudad+$" ({TotalFilas}x{TotalColumnas})");
            Mapa.ImprimirMapa();
        }
    }

}