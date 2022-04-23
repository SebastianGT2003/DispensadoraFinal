using Dispensador;
namespace Ventana_Grafica
{
    public partial class Inicio : Form
    {
        public Producto producto { get; set; }
        
        public Inicio()
        
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                this.producto = new Producto();
                producto.Nombre = txtNombre.Text;
                producto.Categoria = txtCategoria.Text;
                producto.Cantidad = int.Parse(txtCantidad.Text);
                producto.Codigo = txtCodigo.Text;
                producto.Valor = float.Parse(txtValor.Text);


                ListViewItem lista = new ListViewItem(producto.Codigo);
                lista.SubItems.Add(producto.Nombre);
                lista.SubItems.Add(producto.Categoria);
                lista.SubItems.Add(txtCantidad.Text);
                lista.SubItems.Add(txtValor.Text);
                lvwListaProductos.Items.Add(lista);


                Limpiar limpiar = new Limpiar();
                limpiar.limpiarCampos(this, tabAgregar);
            }
            

            

        }
        private bool VerificarDatos()
        {
            if (VerificarCodigo() && VerificarNombre() && VerificarCantidad() && VerificarValor() && VerificarCategoria())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VerificarCodigo()
        {
            txtCodigo.Focus();
            if (txtCodigo.Text== "")
            {
                MessageBox.Show("Por favor, ingresa el codigo.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            
            }
            else if (txtCodigo.TextLength > 15)
            {
                MessageBox.Show("El codigo excede los 15 caracteres.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }


            return true;



        


        }
        public bool VerificarCategoria()
        {
            txtCategoria.Focus();

            if (txtCategoria.Text == "")
            {
                MessageBox.Show("Por favor, ingresa la categoria del producto.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtCategoria.TextLength > 15)
            {
                MessageBox.Show("La categoria excede los 15 caracteres.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
           

            return true;



        }
        public bool VerificarValor()
        {
            txtValor.Focus();

            if (txtValor.Text == "")
            {
                MessageBox.Show("Por favor, ingresa el valor del producto.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtValor.TextLength > 10)
            {
                MessageBox.Show("El valor excede los 10 digitos.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (!Int64.TryParse(txtValor.Text, out _))
            {
                MessageBox.Show("La cantidad solo tiene que tener datos numericos.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else

                return true;



        }
        public bool VerificarNombre()
        {
            txtNombre.Focus();

            if (txtNombre.Text == "")
            {
                MessageBox.Show("Por favor, ingresa el nombre completo.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtNombre.TextLength > 50)
            {
                MessageBox.Show("El nombre excede los 50 caracteres.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            else
            
                return true;


   
        }
        public bool VerificarCantidad()
        {
            txtCantidad.Focus();
            if (txtCantidad.Text == "")
            {
                MessageBox.Show("Por favor, ingresa la cantidad.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;

            }
            else if (!Int64.TryParse(txtCantidad.Text, out _))
            {
                MessageBox.Show("La cantidad solo tiene que tener datos numericos.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtCantidad.Text== "0")
            {
                MessageBox.Show("La cantidad no puede ser 0.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;


            }
            else if (txtCantidad.TextLength > 15)
            {
                MessageBox.Show("La cantidad es exagerada.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;


            }

            return true;
        }
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            {
                foreach (ListViewItem lista in lvwListaProductos.SelectedItems) 
                {
                    lista.Remove();
                    Limpiar limpiar = new Limpiar();

                    limpiar.limpiarCampos(this, tabAgregar);
                }
            }
        }

        private void lvwListaProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtCodigo.Text = lvwListaProductos.SelectedItems[0].Text;
                txtNombre.Text = lvwListaProductos.SelectedItems[0].SubItems[1].Text;
                txtCategoria.Text = lvwListaProductos.SelectedItems[0].SubItems[2].Text;
                txtCantidad.Text = lvwListaProductos.SelectedItems[0].SubItems[3].Text;
                txtValor.Text = lvwListaProductos.SelectedItems[0].SubItems[4].Text;
            }
            catch
            {

            }
            if (lvwListaProductos.SelectedItems.Count > 0)
            {
                btnModificar.Enabled = true;
                btnVender.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                btnModificar.Enabled = false;
                btnVender.Enabled = false;


            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            lvwListaProductos.SelectedItems[0].Text = txtCodigo.Text;
            lvwListaProductos.SelectedItems[0].SubItems[1].Text = txtNombre.Text;
            lvwListaProductos.SelectedItems[0].SubItems[2].Text = txtCategoria.Text;
            lvwListaProductos.SelectedItems[0].SubItems[3].Text = txtCantidad.Text;
            lvwListaProductos.SelectedItems[0].SubItems[4].Text = txtValor.Text;
            Limpiar limpiar = new Limpiar();

            limpiar.limpiarCampos(this, tabAgregar);
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            try
            { 
                if (int.Parse(lvwListaProductos.SelectedItems[0].SubItems[3].Text)==1)
                {
                    foreach (ListViewItem lista in lvwListaProductos.SelectedItems)
                    {
                        lista.Remove();
                        Limpiar limpiar = new Limpiar();

                        limpiar.limpiarCampos(this, tabAgregar);
                    }
                }
                else
                {
                    int texto = int.Parse(lvwListaProductos.SelectedItems[0].SubItems[3].Text);

                    int total = (texto - 1);
                    Console.WriteLine(total);
                    Console.ReadLine();

                    total= int.Parse(lvwListaProductos.SelectedItems[0].SubItems[3].Text);
                    lvwListaProductos.SelectedItems[0].SubItems[3].Text = total.ToString();
                }
            }
            catch
            {

            }
        }
    }

}