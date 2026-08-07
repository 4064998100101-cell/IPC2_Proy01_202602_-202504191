

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

        private nodorobot? cola;
        private nodorobot? cabeza;

        public listarobot()
        {
            cabeza=null;
            cola=null;
        }
       public void agregarRobot(robot Robot)
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
                 Console.WriteLine($"Robot: {actual.Robot.GetType().Name}, Capacidad: {actual.Robot.Capacidad}");
                 actual=actual.siguiente;
            }
        }

    }

}