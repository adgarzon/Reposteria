using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidades;

namespace capaDatos
{
    public class ListaCliente
    {
        static List<Object> lista = new List<Object>();

        public ListaEmpleado Lista { get; set; }

        public static void add(Object p)
        {
            lista.Add(p);
        }

        public static clsCliente buscar(string id)
        {
            clsCliente res = null;
            foreach (clsCliente p in lista)
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
