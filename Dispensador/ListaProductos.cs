using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispensador
{
    public class ListaProductos
    {
        Dispensadora dispensadora= new Dispensadora();
        public string ListarProducto()
        {
            
            string lista = "";
            foreach (Producto item in dispensadora.Productos)
            {
                lista += item.Codigo + " " + item.Nombre + " Categoria " + item.Categoria + " Cantidad " + item.Cantidad + " Costo unidad " + item.Valor + "\n";
            }
            return lista;
        }
    }
}
