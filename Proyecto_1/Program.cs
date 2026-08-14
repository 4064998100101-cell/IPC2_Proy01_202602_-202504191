using System.ComponentModel;
namespace Proyecto_1;

class Program
{
    static listarobot listarobots=new();
    static matrizortogonal matriz =new matrizortogonal();

    static void Main(string[] args)
    {
        fighter fighter1= new fighter(10);
        res res1=new res();
        listarobots.agregarRobot(fighter1);
        listarobots.agregarRobot(res1);
        listarobots.mostrarRobot();
        int fila =0;
        int columna =0;
        bool repetir;
        Console.WriteLine("+=========================================+");
        

    }
}
