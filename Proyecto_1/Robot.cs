namespace Proyecto_1
{

    public abstract class robot{
        // setters y getters
    public string Nombre{get; set;}
    public int Capacidad {get; set;}
    // constructor 
    public robot(string nombre)
        {
            this.Capacidad=0;
            this.Nombre=nombre;
        }

        public abstract void Mover(int capacidadUnidadMilitar);
        public abstract void RestarCapacidad(int capacidadUnidadMilitar); 

    }

}