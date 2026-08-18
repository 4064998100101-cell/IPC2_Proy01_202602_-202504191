

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
                Robot=r;
                siguiente=null;

            }

        }

        private static  nodorobot? cola;
        private static nodorobot? cabeza;

        public listarobot()
        {
            cabeza=null;
            cola=null;
        }
       public static void agregarRobot(robot Robot)
        {
            nodorobot nuevonodo=new nodorobot(Robot);

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
        public void mostrarRobot()
        {
            nodorobot actual=cabeza;
            while (actual != null)
            {
                 Console.WriteLine($"Robot: {actual.Robot.Nombre}, Capacidad: {actual.Robot.Capacidad}");
                 actual=actual.siguiente;
            }
        }

    }

}