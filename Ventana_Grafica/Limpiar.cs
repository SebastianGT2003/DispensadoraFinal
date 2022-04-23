using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventana_Grafica
{
    public class Limpiar
    {
        public void limpiarCampos(Control control, TabPage gb)
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
            }
            foreach (var tab in gb.Controls)
            {
                if (tab is TextBox)
                {
                    ((TextBox)tab).Clear();
                }
            }
        }
    }
}
