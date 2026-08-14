namespace Proyecto_1
{
    public class nodoPunto
    {
        public nodo Elemento {get; set;}
        public nodoPunto siguiente{get; set;}
        public nodoPunto(nodo elemento)
        {
            elemento=elemento;
            siguiente=null;
        }
    }

    public class listapuntos
    {
        public nodoPunto cabeza{get; private set;}
        public int cantidad{get; private set;}
        public void agregar(nodo elemento)
        {
            nodoPunto nuevo =new nodoPunto(elemento);
            if (cabeza== null)

            {
                cabeza=nuevo;
    
            }
            else
            {
                nodoPunto actual=cabeza;
                while (actual.siguiente !=null)
                {
                    actual=actual.siguiente;
                }
                actual.siguiente=nuevo;
            }
            cantidad++;
        }
    }
}