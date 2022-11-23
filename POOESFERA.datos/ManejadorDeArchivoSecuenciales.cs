using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POOEsfera.Entidades;

namespace POOESFERA.datos
{
   public class ManejadorDeArchivoSecuenciales
    {
        public static void GuardarEnArchivosSecuencial(List<Esfera> lista)
        {
            //Creo el objeto que va a escribir en el archivo secuencial
            using (var escritor = new StreamWriter("Archivo.txt"))
            {
                //Recorro la lista de circunferencial
                foreach (var esfera in lista)
                {
                    //Creo la linea
                    string linea = ConstruirLinea(esfera);
                    escritor.WriteLine(linea);
                }
            }
        }
        public static List<Esfera> LeerArchivoSecuencial()
        {
            List<Esfera> lista = new List<Esfera>();
            using (var lector = new StreamReader("Archivo.txt"))
            {
                while (!lector.EndOfStream)//Mientras no sea fin de archivo, va a continuar leyendo
                {
                    string linea = lector.ReadLine();
                    Esfera esfera = ConstruirRectangulo(linea);
                    lista.Add(esfera);
                }

            }
            return lista;
        }

        private static Esfera ConstruirRectangulo(string linea)
        {
            return new Esfera() { Radio = int.Parse(linea) };
        }

        private static string ConstruirLinea(Esfera esfera)
        {
            return $"{esfera.Radio} ";
        }
    }
    
    