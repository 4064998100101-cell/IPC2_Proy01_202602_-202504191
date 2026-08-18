namespace Proyecto_1
{
    public class listarobot
    {
        public class nodorobot
        {
            public robot Robot;
            public nodorobot? siguiente;
            public nodorobot(robot r)
            {
                Robot = r;
                siguiente = null;
            }
        }

        private static nodorobot? cola;
        private static nodorobot? cabeza;

        public listarobot()
        {
            cabeza = null;
            cola = null;
        }

        public static void agregarRobot(robot Robot)
        {
            nodorobot nuevonodo = new nodorobot(Robot);

            if (cabeza == null)
            {
                cabeza = nuevonodo;
                cola = nuevonodo;
            }
            else
            {
                cola.siguiente = nuevonodo;
                cola = nuevonodo;
            }
        }

        public void mostrarRobot()
        {
            try 
            {
                int contador = 1;
                nodorobot? actual = cabeza;

                // CORREGIDO: Cambiamos el último {1, -17} por {2, -17}
                string formatoColumna = "{0, -12} | {1, -25} | {2, -17}";

                Console.WriteLine(formatoColumna, "No. robot", "Nombre robot", "Tipo de robot");
                // Ampliamos la línea para que cubra el ancho total (12 + 25 + 17 + separadores = ~60)
                Console.WriteLine(new string('-', 60)); 

                while (actual != null)
                {
                    Console.WriteLine(
                        formatoColumna,
                        contador,                      
                        actual.Robot.Nombre,       
                        actual.Robot.GetType().Name   
                    );

                    contador++;
                    actual = actual.siguiente;
                } 
            }
            catch (System.Exception ex)
            {
                Console.WriteLine($"Error al mostrar la lista: {ex.Message}");
            }
        }
    }
}