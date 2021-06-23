using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using capaEntidades;

namespace capaDatos
{
    public class ListaEmpleado
    {
        static List<Object> lista = new List<Object>();

        public ListaEmpleado Lista { get; set; }
        
        public static void add(Object p)
        {
            lista.Add(p);
        }

        public static clsEmpleado  buscar(string id)
        {
            clsEmpleado res = null;
            foreach(clsEmpleado p in lista)
            {
                if (p.Documento.Equals(id, StringComparison.OrdinalIgnoreCase))
                {
                    res = p;
                    break;
                }
            }
            return res;
        }
    }
}
