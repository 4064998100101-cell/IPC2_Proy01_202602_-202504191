using System.Collections.Immutable;
using System.Xml;
namespace  Proyecto_1
{
    public class lectorXml
    {
   
    
        public  void cargarconfiguracion(string rutaArchivo)
        {
            try
            {
                XmlDocument Xml=new XmlDocument();
                Xml.Load(rutaArchivo);
                XmlNode nodoRaiz=Xml.DocumentElement;
                if (nodoRaiz==null)
                {
                    Console.WriteLine("El archivo xml esta vacio");
                    
                }

                foreach(XmlNode nodoHijo in nodoRaiz.ChildNodes)
                {
                    if (nodoHijo.Name == "listaCiudades")
                    {
                        Procesarlista(nodoHijo);
                    }
                    // 2. Buscar la sección <robots>
                    else if (nodoHijo.Name == "robots")
                    {
                        Procesarrobot(nodoHijo);
                }
            }
            }
            catch (System.Exception)
            {
               Console.WriteLine("Error al leer el archivo xml");
            }
        }
        private static void Procesarlista(XmlNode nodoListaciudades)
        {
            
            foreach (XmlNode nodociudad in nodoListaciudades.ChildNodes)
            {
                if (nodociudad.Name == "ciudad")
                {
                    string nombreCiudad="";
                    int totalFilas=0;
                    int totalColumnas=0;
                    foreach(XmlNode nombre in nodociudad.ChildNodes)
                    {
                        if (nombre.Name == "nombre")
                        {
                            nombreCiudad=nombre.InnerText.Trim();

                            totalFilas=int.Parse(nombre.Attributes["filas"].Value);
                            totalColumnas=int.Parse(nombre.Attributes["columnas"].Value);
                            break;
                        }
                    }
                ciudad nuevaciudad=new ciudad(nombreCiudad, totalFilas,totalColumnas);
                foreach(XmlNode elemento in nodociudad.ChildNodes)
                    {
                        if (elemento.Name=="fila")
                        {
                             int numeroFila = int.Parse(elemento.Attributes["numero"].Value);
                             string cadenaFila=elemento.InnerText;
                            
                            for(int col=0 ; col<cadenaFila.Length; col++)
                            {
                                char caracter=cadenaFila[col];
                                nuevaciudad.agregarelemento(caracter,numeroFila,col);
                            }
                        }
                       else if (elemento.Name=="unidadMilitar")
                        {
                            int filamilitar=int.Parse(elemento.Attributes["fila"].Value);
                             int colmilitar=int.Parse(elemento.Attributes["columna"].Value);
                             nuevaciudad.agregarelemento('M',filamilitar,colmilitar);
                        }

                    }

                
                Console.WriteLine();
               
                nuevaciudad.MostrarCiudad();
                 listaciudades.agregarcity(nuevaciudad);
                }


            }
        }
        private static void Procesarrobot(XmlNode nodolistarobot)
        {
            foreach(XmlNode nodoRobot in nodolistarobot.ChildNodes)
            {
               if (nodoRobot.Name=="robot")
                {
                    string nombrerobot="";
                    string tipoRobot="";
                    int capacidad=0;
                    foreach (XmlNode elemento in nodoRobot.ChildNodes)
                    {
                        if (elemento.Name=="nombre")
                        {
                            nombrerobot=elemento.InnerText.Trim();
                            
                            if (elemento.Attributes["tipo"]!=null)
                            {
                                
                                tipoRobot=elemento.Attributes["tipo"].Value;
                            
                            }
                            if (elemento.Attributes["capacidad"]!= null)
                            {
                                capacidad=int.Parse(elemento.Attributes["capacidad"].Value);
                            }
                            
                        break;
                        }

                    }
                    robot nuevorobot=null;

                            if (tipoRobot=="ChapinFighter")
                            {
                              nuevorobot = new  fighter(nombrerobot,capacidad);
                            }
                            else if (tipoRobot=="ChapinRescue")

                           {
                        nuevorobot= new res(nombrerobot);
                           }
                        else
                           {
                            Console.WriteLine("Este tipo de robot no existe");
                           }
                    listarobot.agregarRobot(nuevorobot);
                    Console.WriteLine ("Robot: "+nombrerobot+"|tipo: "+tipoRobot+"| capacidad: "+capacidad);
                }
            }
        }
    }

}