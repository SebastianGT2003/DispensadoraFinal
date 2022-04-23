namespace Ventana_Grafica
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblInicio = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabOpciones = new System.Windows.Forms.TabControl();
            this.tabAgregar = new System.Windows.Forms.TabPage();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbValor = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lvwListaProductos = new System.Windows.Forms.ListView();
            this.chCodigo = new System.Windows.Forms.ColumnHeader();
            this.chNombre = new System.Windows.Forms.ColumnHeader();
            this.chCategoria = new System.Windows.Forms.ColumnHeader();
            this.chCantidad = new System.Windows.Forms.ColumnHeader();
            this.chValor = new System.Windows.Forms.ColumnHeader();
            this.tblInicio.SuspendLayout();
            this.tabOpciones.SuspendLayout();
            this.tabAgregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblInicio
            // 
            this.tblInicio.ColumnCount = 1;
            this.tblInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblInicio.Controls.Add(this.label1, 0, 0);
            this.tblInicio.Controls.Add(this.tabOpciones, 0, 1);
            this.tblInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblInicio.Location = new System.Drawing.Point(0, 0);
            this.tblInicio.Name = "tblInicio";
            this.tblInicio.RowCount = 2;
            this.tblInicio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.7931F));
            this.tblInicio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.20689F));
            this.tblInicio.Size = new System.Drawing.Size(800, 450);
            this.tblInicio.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(794, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dispensadora de Sara";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabOpciones
            // 
            this.tabOpciones.Controls.Add(this.tabAgregar);
            this.tabOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabOpciones.Location = new System.Drawing.Point(3, 65);
            this.tabOpciones.Name = "tabOpciones";
            this.tabOpciones.SelectedIndex = 0;
            this.tabOpciones.Size = new System.Drawing.Size(794, 382);
            this.tabOpciones.TabIndex = 3;
            // 
            // tabAgregar
            // 
            this.tabAgregar.Controls.Add(this.btnLimpiar);
            this.tabAgregar.Controls.Add(this.btnVender);
            this.tabAgregar.Controls.Add(this.btnEliminar);
            this.tabAgregar.Controls.Add(this.btnModificar);
            this.tabAgregar.Controls.Add(this.txtCantidad);
            this.tabAgregar.Controls.Add(this.lbCantidad);
            this.tabAgregar.Controls.Add(this.btnAgregar);
            this.tabAgregar.Controls.Add(this.txtNombre);
            this.tabAgregar.Controls.Add(this.txtValor);
            this.tabAgregar.Controls.Add(this.txtCategoria);
            this.tabAgregar.Controls.Add(this.txtCodigo);
            this.tabAgregar.Controls.Add(this.lbValor);
            this.tabAgregar.Controls.Add(this.lbCategoria);
            this.tabAgregar.Controls.Add(this.lbNombre);
            this.tabAgregar.Controls.Add(this.lbCodigo);
            this.tabAgregar.Controls.Add(this.lvwListaProductos);
            this.tabAgregar.Location = new System.Drawing.Point(4, 29);
            this.tabAgregar.Name = "tabAgregar";
            this.tabAgregar.Padding = new System.Windows.Forms.Padding(3);
            this.tabAgregar.Size = new System.Drawing.Size(786, 349);
            this.tabAgregar.TabIndex = 3;
            this.tabAgregar.Text = "Productos";
            this.tabAgregar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.Location = new System.Drawing.Point(89, 126);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(94, 29);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVender
            // 
            this.btnVender.Enabled = false;
            this.btnVender.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVender.Location = new System.Drawing.Point(489, 126);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(94, 29);
            this.btnVender.TabIndex = 1;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Location = new System.Drawing.Point(389, 126);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 29);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.Location = new System.Drawing.Point(289, 126);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(94, 29);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(115, 89);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(125, 27);
            this.txtCantidad.TabIndex = 16;
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCantidad.Location = new System.Drawing.Point(34, 92);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(75, 20);
            this.lbCantidad.TabIndex = 13;
            this.lbCantidad.Text = "Cantidad:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(189, 126);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 29);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(337, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ShortcutsEnabled = false;
            this.txtNombre.Size = new System.Drawing.Size(125, 27);
            this.txtNombre.TabIndex = 19;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(337, 92);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(125, 27);
            this.txtValor.TabIndex = 18;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(574, 33);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ShortcutsEnabled = false;
            this.txtCategoria.Size = new System.Drawing.Size(125, 27);
            this.txtCategoria.TabIndex = 17;
            this.txtCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCategoria_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(115, 33);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ShortcutsEnabled = false;
            this.txtCodigo.Size = new System.Drawing.Size(125, 27);
            this.txtCodigo.TabIndex = 15;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lbValor
            // 
            this.lbValor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbValor.Location = new System.Drawing.Point(271, 92);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(50, 20);
            this.lbValor.TabIndex = 14;
            this.lbValor.Text = "Valor:";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCategoria.Location = new System.Drawing.Point(488, 36);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(80, 20);
            this.lbCategoria.TabIndex = 12;
            this.lbCategoria.Text = "Categoria:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNombre.Location = new System.Drawing.Point(250, 36);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(71, 20);
            this.lbNombre.TabIndex = 11;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCodigo.Location = new System.Drawing.Point(47, 36);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(62, 20);
            this.lbCodigo.TabIndex = 10;
            this.lbCodigo.Text = "Codigo:";
            // 
            // lvwListaProductos
            // 
            this.lvwListaProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCodigo,
            this.chNombre,
            this.chCategoria,
            this.chCantidad,
            this.chValor});
            this.lvwListaProductos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvwListaProductos.FullRowSelect = true;
            this.lvwListaProductos.GridLines = true;
            this.lvwListaProductos.Location = new System.Drawing.Point(3, 161);
            this.lvwListaProductos.Name = "lvwListaProductos";
            this.lvwListaProductos.Size = new System.Drawing.Size(780, 185);
            this.lvwListaProductos.TabIndex = 7;
            this.lvwListaProductos.UseCompatibleStateImageBehavior = false;
            this.lvwListaProductos.View = System.Windows.Forms.View.Details;
            this.lvwListaProductos.SelectedIndexChanged += new System.EventHandler(this.lvwListaProductos_SelectedIndexChanged);
            // 
            // chCodigo
            // 
            this.chCodigo.Text = "Codigo";
            this.chCodigo.Width = 150;
            // 
            // chNombre
            // 
            this.chNombre.Text = "Nombre";
            this.chNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chNombre.Width = 200;
            // 
            // chCategoria
            // 
            this.chCategoria.Text = "Categoria";
            this.chCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chCategoria.Width = 150;
            // 
            // chCantidad
            // 
            this.chCantidad.Text = "Cantidad";
            this.chCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chCantidad.Width = 150;
            // 
            // chValor
            // 
            this.chValor.Text = "Valor";
            this.chValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chValor.Width = 150;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tblInicio);
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App Dispensadora";
            this.tblInicio.ResumeLayout(false);
            this.tblInicio.PerformLayout();
            this.tabOpciones.ResumeLayout(false);
            this.tabAgregar.ResumeLayout(false);
            this.tabAgregar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblInicio;
        private TabControl tabOpciones;
        private TabPage tabAgregar;
        private Button btnAgregar;
        private TextBox txtNombre;
        private TextBox txtValor;
        private TextBox txtCategoria;
        private TextBox txtCantidad;
        private TextBox txtCodigo;
        private Label lbValor;
        private Label lbCantidad;
        private Label lbCategoria;
        private Label lbNombre;
        private Label lbCodigo;
        private ListView lvwListaProductos;
        private ColumnHeader chCodigo;
        private ColumnHeader chNombre;
        private ColumnHeader chCategoria;
        private ColumnHeader chCantidad;
        private ColumnHeader chValor;
        private Label label1;
        private Button btnVender;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnLimpiar;
    }
}