

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
    try
    {
        int contador = 1;
        nodociudad actual = cabeza;

        string formatoColumna = "{0, -12} | {1, -25}";


        Console.WriteLine(formatoColumna, "No. ciudad", "Nombre ciudad");
        Console.WriteLine(new string('-', 40)); 

        while (actual != null)
        {
            
            Console.WriteLine(
                formatoColumna,
                contador,
                actual.Ciudad.Nombreciudad
            );

            contador++;
            actual = actual.siguiente;
        } 
    }
    catch (System.Exception ex)
    {
        Console.WriteLine($"Error al mostrar datos: {ex.Message}");
    }
}
    }

}