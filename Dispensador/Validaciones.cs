using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dispensador;


namespace Dispensador
{
    public class Validaciones
    {
        Dispensadora lista;
        public int ValidaProducto(string codigo)
        {
            
            int encontro = -1;

            for (int i = 0; i < lista.Productos.Count; i++)
            {
                if (lista.Productos[i].Codigo == codigo)
                {
                    encontro = i;
                }
            }
            return encontro;
        }
    }
}
