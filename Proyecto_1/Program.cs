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

        // prueba de no Xml
    string[] filas = new string[]
        {
            "*****",
            "E    ",
            "**** ",
            "***  ",
            " R  *",
            "*****"
        };

        // Insertamos usando índices basados en 0 (0 a 5)
        for (int f = 0; f < filas.Length; f++)
        {
            for (int c = 0; c < filas[f].Length; c++)
            {
                matriz.insertar(filas[f][c], f, c);
            }
        }

        Console.WriteLine("\n--- MAPA IMPRESO ---");
        matriz.ImprimirMapa();

    }
}
