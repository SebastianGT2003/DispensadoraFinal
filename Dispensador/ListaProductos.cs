using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispensador
{
    public class ListaProductos
    {
        public List<Producto> Productos;


        public ListaProductos(Dispensadora dispensadora)
        {
            Productos= dispensadora.Productos;
        }
        public string ListarProducto()
        {
            
            string lista = "";
            foreach (Producto item in Productos )
            {
                lista += item.Codigo + " " + item.Nombre + " Categoria " + item.Categoria + " Cantidad " + item.Cantidad + " Costo unidad " + item.Valor + "\n";
            }
            return lista;
        }
    }
}
