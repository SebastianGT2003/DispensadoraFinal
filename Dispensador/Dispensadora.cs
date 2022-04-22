using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispensador
{
    public class Dispensadora
    {
        Validaciones validar;
        public List<Producto> Productos { get; set; }
        public string Pago { get; set; }
        public Dispensadora()
        {
            this.Productos = new List<Producto>();  

            Producto Cocacola = new Producto();
            Cocacola.Codigo = "01";
            Cocacola.Nombre = "Coca Cola";
            Cocacola.Valor = 3000;
            Cocacola.Categoria = "B";
            Cocacola.Cantidad = 3;

            Producto Solterita = new Producto();
            Solterita.Codigo = "02";
            Solterita.Nombre = "Solterita";
            Solterita.Valor = 2000;
            Solterita.Categoria = "C";
            Solterita.Cantidad = 5;



            Producto Papas = new Producto();
            Papas.Codigo = "03";
            Papas.Valor = 2000;
            Papas.Nombre = "Papas Margaritas";
            Papas.Categoria = "C";
            Papas.Cantidad = 10;

            this.Productos.Add(Cocacola);
            this.Productos.Add(Papas);
            this.Productos.Add(Solterita);


        }
        
        public int ValidaProducto(string codigo)
        {
            int encontro = -1;

            for (int i = 0;i<this.Productos.Count;i++)
            {
                if (this.Productos[i].Codigo == codigo)
                {
                    encontro = i;
                }
            }
            return encontro;
        }
        
        
        public bool AgregarProducto(Producto producto)
        {
            int enc= this.ValidaProducto(producto.Codigo);
            if (enc>=0)
            {
                this.Productos[enc].SumarCantidad(producto.Cantidad);
            }
            else
            {
                this.Productos.Add(producto);
            }
            return true;
        }
        public bool EleminarProducto(string codigo)
        {
            int enc = this.ValidaProducto(codigo);
            if (enc >= 0) 
            {
                this.Productos.RemoveAt(enc);
                return true;
            }
            return false;
  
            
        }
        /// Metodo para validar si las monedas tiene alguna letra.
        public double ValidarMonedas (string[] monedas)
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
        //Las monedas van a ser: 1000-500-200-100
        public Producto Vender(string codigo)
        {
            int enc = this.ValidaProducto(codigo);
            if (enc >= 0)
            {
                if (this.Productos[enc].ValidarCantidad())
                {
                    string[] monedas = this.Pago.Split("-");
                    double total= this.ValidarMonedas(monedas);

                    if (this.Productos[enc].ValidarValor(total))
                    {
                        this.Productos[enc].RestarProducto();
                        return this.Productos[enc];
                    }
                    

                }
                

            }

            return null;
        }
        public string ListarProducto() 
        {
            string lista = "";
            foreach(Producto item in this.Productos)
            {
                lista += item.Codigo + " " + item.Nombre + " Categoria " + item.Categoria + " Cantidad " + item.Cantidad + " Costo unidad " + item.Valor + "\n";
            }
            return lista;
        }

    }
}
