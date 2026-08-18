using System.ComponentModel;
using System.Xml;
namespace Proyecto_1;

class Program
{
    static listarobot robots=new();
    static listaciudades ciudades=new();
    static matrizortogonal matriz =new matrizortogonal();
    static lectorXml nuevo=new ();
    static void Main(string[] args)
    {   
       
        bool repetir=true;

        while (repetir)
        {
        Console.WriteLine("+=========================================+");
        Console.WriteLine("|       CHAPIN RESCUE Y ASOCIADOS         |");
        Console.WriteLine("+=========================================+");
        Console.WriteLine("1. Cargar archivo XML");
        Console.WriteLine("2. Gestionar ciudades");
        Console.WriteLine("3. Gestionar Robots");
        Console.WriteLine("4. Realizar Mision");
        Console.WriteLine("0. Salir");
        Console.WriteLine("Ingrese una opcion");
        int opcion=int.Parse(Console.ReadLine());
        switch (opcion)
        {
            case 1: Console.WriteLine("Ingrese un nuevo XML que leer"); string miguelito=Console.ReadLine(); nuevo.cargarconfiguracion(miguelito); break;
            case 2: ciudades.mostrarciudades(); break;
            case 3: robots.mostrarRobot(); break;
            case 4: Console.WriteLine("VAMOS A REALIZAR UNA MISION,........... INCOMPLETO"); break;
            case 0: Console.WriteLine("Gracias por usar el programa"); repetir=false; break;
        }
        }
    }

}
