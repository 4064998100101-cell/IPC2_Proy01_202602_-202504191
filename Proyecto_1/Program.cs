using System.ComponentModel;
using System.Xml;
namespace Proyecto_1;

class Program
{
    static listarobot listarobots=new();
    static matrizortogonal matriz =new matrizortogonal();
    static lectorXml nuevo=new ();
    static void Main(string[] args)
    {   
       

        int fila =0;
        int columna =0;
        bool repetir;
        Console.WriteLine("+=========================================+");
        Console.WriteLine("|       CHAPIN RESCUE Y ASOCIADOS         |");
        Console.WriteLine("+=========================================+");
        Console.WriteLine("Ingrese la ruta del archivo para la lectura xml");
        string miguelito= Console.ReadLine();
        nuevo.cargarconfiguracion(miguelito);
        


    }
}
