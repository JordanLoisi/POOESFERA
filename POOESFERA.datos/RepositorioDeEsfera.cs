using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POOEsfera.Entidades;

namespace POOESFERA.datos
{
    public class RepositorioDeEsfera
    {
        private List<Esfera> ListaDeEsfera;

      public RepositorioDeEsfera()
    {
            ListaDeEsfera = new List<Esfera>();

    }
        public void Agregar(Esfera esfera)
        {
            ListaDeEsfera.Add(esfera);
        }
         
        public List<Esfera> GetLista()
        {
            return ListaDeEsfera;
        }
        public bool Borrar (Esfera esfera)
        {
            if (ListaDeEsfera.Contains(esfera))
            {
                ListaDeEsfera.Remove(esfera);
                return true;
            }
            return false;
        }
        public int GetCantidad()
        {
            return ListaDeEsfera.Count();
        }


    }
    
   
    }
