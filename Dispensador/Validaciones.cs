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
            lista = new Dispensadora();
            
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
        public double ValidarMonedas(string[] monedas)
        {
            double total = 0;
            foreach (string item in monedas)
            {

                try
                {
                    total += float.Parse(item);

                }
                catch (Exception e) { }

                return total;

            }
            return total;

        }
    }
}
