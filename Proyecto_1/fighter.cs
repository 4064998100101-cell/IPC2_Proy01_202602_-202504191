namespace Proyecto_1
{
    public class fighter: robot
    {
        public fighter(string nombre, int capacidadinicial) : base(nombre)
        {
            this.Capacidad=capacidadinicial;

        }
        public override void Mover(int capacidadUnidadMilitar)
        {
            if (this.Capacidad>capacidadUnidadMilitar)
            {
                Console.WriteLine("se esta moviendo el robot");

            }
            else
            {
                Console.WriteLine("El robot no puede vencer a la unidad militar");
            }
             
        }

        public override void RestarCapacidad(int capacidadUnidadMilitar)
        {
            this.Capacidad=this.Capacidad-capacidadUnidadMilitar;
        }




    }

}