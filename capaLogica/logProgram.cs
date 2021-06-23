using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidades;

namespace capaLogica
{
    public class logProgram
    {
      
        public static void agregarP(Object p)
        {
            clsEmpleado a = new clsEmpleado();
            if(p.GetType() == a.GetType())
            {
                ListaEmpleado.add(p);
            }
            else
            {
                ListaCliente.add(p);
            }
            
        }
        public static clsEmpleado consultaEmple(string iden)
        {
            return ListaEmpleado.buscar(iden);
        }
        public static clsCliente consultaCliente(string iden)
        {
            return ListaCliente.buscar(iden);
        }
    }
}
