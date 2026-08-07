

namespace Proyecto_1
{
    public class res : robot
    {
        public res() : base ("res")
        {
            
         this.Capacidad=0;

        }
        public override void Mover(int capacidadUnidadMilitar)
        {
            // se mueve pero evitando a los militares
        }

        public override void RestarCapacidad(int capacidadUnidadMilitar)
        {
            // no aplica los datos en este caso
        }

        
    }

}