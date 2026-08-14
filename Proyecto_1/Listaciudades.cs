

namespace Proyecto_1
{
    public class listaciudades
    {
        
        public class nodociudad
        {
            public ciudad Ciudad;
            public nodociudad? siguiente;
            public nodociudad(ciudad c)
            {
                Ciudad=c;
                siguiente=null;

            }

        }

        private static nodociudad? cola;
        private static  nodociudad? cabeza;

        public  listaciudades()
        {
            cabeza=null;
            cola=null;
        }
       public static void agregarcity(ciudad Ciudad)
        {
            nodociudad nuevonodo=new nodociudad(Ciudad);

            if (cabeza == null)
            {
                cabeza=nuevonodo;
                cola=nuevonodo;
            }
            else
            {
                cola.siguiente=nuevonodo;
                cola=nuevonodo;
            }


        }
        public void mostrarciudades()
        {
            nodociudad actual=cabeza;
            while (actual != null)
            {
                 Console.WriteLine($"Robot: {actual.Ciudad.GetType().Name}");
                 actual=actual.siguiente;
            }
        }

    }

}