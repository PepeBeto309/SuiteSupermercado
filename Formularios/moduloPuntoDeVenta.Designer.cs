namespace SuiteSupermercado
{
    partial class moduloPuntoDeVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pagEmpleados = new System.Windows.Forms.TabPage();
            this.pagVentas = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pagPuntoDeVen = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.rbClienteNom = new System.Windows.Forms.RadioButton();
            this.rbClienteId = new System.Windows.Forms.RadioButton();
            this.cbListaClientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbEmpleadoNom = new System.Windows.Forms.RadioButton();
            this.rbEmpleadoId = new System.Windows.Forms.RadioButton();
            this.cbListaVendedores = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butEliminar = new System.Windows.Forms.Button();
            this.butFinalizarCompara = new System.Windows.Forms.Button();
            this.butAgregar = new System.Windows.Forms.Button();
            this.pbProducto = new System.Windows.Forms.PictureBox();
            this.tbPrecioUnitario = new System.Windows.Forms.TextBox();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.tbProducto = new System.Windows.Forms.TextBox();
            this.tbClaveProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvDetallesVenta = new System.Windows.Forms.DataGridView();
            this.tpVentas = new System.Windows.Forms.TabControl();
            this.pagVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.pagPuntoDeVen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesVenta)).BeginInit();
            this.tpVentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pagEmpleados
            // 
            this.pagEmpleados.Location = new System.Drawing.Point(4, 22);
            this.pagEmpleados.Name = "pagEmpleados";
            this.pagEmpleados.Size = new System.Drawing.Size(1254, 654);
            this.pagEmpleados.TabIndex = 2;
            this.pagEmpleados.Text = "EMPLEADOS";
            this.pagEmpleados.UseVisualStyleBackColor = true;
            // 
            // pagVentas
            // 
            this.pagVentas.Controls.Add(this.splitContainer1);
            this.pagVentas.Location = new System.Drawing.Point(4, 22);
            this.pagVentas.Name = "pagVentas";
            this.pagVentas.Padding = new System.Windows.Forms.Padding(3);
            this.pagVentas.Size = new System.Drawing.Size(1254, 654);
            this.pagVentas.TabIndex = 0;
            this.pagVentas.Text = "VENTAS";
            this.pagVentas.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(1248, 648);
            this.splitContainer1.SplitterDistance = 416;
            this.splitContainer1.TabIndex = 0;
            // 
            // pagPuntoDeVen
            // 
            this.pagPuntoDeVen.Controls.Add(this.splitContainer2);
            this.pagPuntoDeVen.Location = new System.Drawing.Point(4, 22);
            this.pagPuntoDeVen.Name = "pagPuntoDeVen";
            this.pagPuntoDeVen.Size = new System.Drawing.Size(1254, 654);
            this.pagPuntoDeVen.TabIndex = 3;
            this.pagPuntoDeVen.Text = "PUNTO DE VENTA";
            this.pagPuntoDeVen.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer2.Panel2.Controls.Add(this.labTotal);
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Panel2.Controls.Add(this.dgvDetallesVenta);
            this.splitContainer2.Size = new System.Drawing.Size(1254, 654);
            this.splitContainer2.SplitterDistance = 418;
            this.splitContainer2.TabIndex = 1;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitContainer3.Panel2.Controls.Add(this.butEliminar);
            this.splitContainer3.Panel2.Controls.Add(this.butFinalizarCompara);
            this.splitContainer3.Panel2.Controls.Add(this.butAgregar);
            this.splitContainer3.Panel2.Controls.Add(this.pbProducto);
            this.splitContainer3.Panel2.Controls.Add(this.tbPrecioUnitario);
            this.splitContainer3.Panel2.Controls.Add(this.tbCantidad);
            this.splitContainer3.Panel2.Controls.Add(this.tbProducto);
            this.splitContainer3.Panel2.Controls.Add(this.tbClaveProducto);
            this.splitContainer3.Panel2.Controls.Add(this.label6);
            this.splitContainer3.Panel2.Controls.Add(this.label5);
            this.splitContainer3.Panel2.Controls.Add(this.label4);
            this.splitContainer3.Panel2.Controls.Add(this.label3);
            this.splitContainer3.Size = new System.Drawing.Size(418, 654);
            this.splitContainer3.SplitterDistance = 167;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.rbClienteNom);
            this.splitContainer4.Panel1.Controls.Add(this.rbClienteId);
            this.splitContainer4.Panel1.Controls.Add(this.cbListaClientes);
            this.splitContainer4.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.rbEmpleadoNom);
            this.splitContainer4.Panel2.Controls.Add(this.rbEmpleadoId);
            this.splitContainer4.Panel2.Controls.Add(this.cbListaVendedores);
            this.splitContainer4.Panel2.Controls.Add(this.label2);
            this.splitContainer4.Size = new System.Drawing.Size(418, 167);
            this.splitContainer4.SplitterDistance = 81;
            this.splitContainer4.TabIndex = 0;
            // 
            // rbClienteNom
            // 
            this.rbClienteNom.AutoSize = true;
            this.rbClienteNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbClienteNom.Location = new System.Drawing.Point(182, 50);
            this.rbClienteNom.Name = "rbClienteNom";
            this.rbClienteNom.Size = new System.Drawing.Size(190, 24);
            this.rbClienteNom.TabIndex = 4;
            this.rbClienteNom.TabStop = true;
            this.rbClienteNom.Text = "Clientes por Nombre";
            this.rbClienteNom.UseVisualStyleBackColor = true;
            this.rbClienteNom.CheckedChanged += new System.EventHandler(this.rbClienteNom_CheckedChanged);
            // 
            // rbClienteId
            // 
            this.rbClienteId.AutoSize = true;
            this.rbClienteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbClienteId.Location = new System.Drawing.Point(11, 50);
            this.rbClienteId.Name = "rbClienteId";
            this.rbClienteId.Size = new System.Drawing.Size(147, 24);
            this.rbClienteId.TabIndex = 3;
            this.rbClienteId.TabStop = true;
            this.rbClienteId.Text = "Clientes por ID";
            this.rbClienteId.UseVisualStyleBackColor = true;
            this.rbClienteId.CheckedChanged += new System.EventHandler(this.rbClienteId_CheckedChanged);
            // 
            // cbListaClientes
            // 
            this.cbListaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbListaClientes.FormattingEnabled = true;
            this.cbListaClientes.Location = new System.Drawing.Point(94, 12);
            this.cbListaClientes.Name = "cbListaClientes";
            this.cbListaClientes.Size = new System.Drawing.Size(310, 32);
            this.cbListaClientes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(2)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // rbEmpleadoNom
            // 
            this.rbEmpleadoNom.AutoSize = true;
            this.rbEmpleadoNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmpleadoNom.Location = new System.Drawing.Point(183, 40);
            this.rbEmpleadoNom.Name = "rbEmpleadoNom";
            this.rbEmpleadoNom.Size = new System.Drawing.Size(203, 24);
            this.rbEmpleadoNom.TabIndex = 6;
            this.rbEmpleadoNom.TabStop = true;
            this.rbEmpleadoNom.Text = "Vendedor por Nombre";
            this.rbEmpleadoNom.UseVisualStyleBackColor = true;
            this.rbEmpleadoNom.CheckedChanged += new System.EventHandler(this.rbEmpleadoNom_CheckedChanged);
            // 
            // rbEmpleadoId
            // 
            this.rbEmpleadoId.AutoSize = true;
            this.rbEmpleadoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmpleadoId.Location = new System.Drawing.Point(12, 40);
            this.rbEmpleadoId.Name = "rbEmpleadoId";
            this.rbEmpleadoId.Size = new System.Drawing.Size(160, 24);
            this.rbEmpleadoId.TabIndex = 5;
            this.rbEmpleadoId.TabStop = true;
            this.rbEmpleadoId.Text = "Vendedor por ID";
            this.rbEmpleadoId.UseVisualStyleBackColor = true;
            this.rbEmpleadoId.CheckedChanged += new System.EventHandler(this.rbEmpleadoId_CheckedChanged);
            // 
            // cbListaVendedores
            // 
            this.cbListaVendedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbListaVendedores.FormattingEnabled = true;
            this.cbListaVendedores.Location = new System.Drawing.Point(122, 2);
            this.cbListaVendedores.Name = "cbListaVendedores";
            this.cbListaVendedores.Size = new System.Drawing.Size(282, 32);
            this.cbListaVendedores.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(2)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vendedor:";
            // 
            // butEliminar
            // 
            this.butEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEliminar.Location = new System.Drawing.Point(122, 429);
            this.butEliminar.Name = "butEliminar";
            this.butEliminar.Size = new System.Drawing.Size(91, 44);
            this.butEliminar.TabIndex = 16;
            this.butEliminar.Text = "Eliminar";
            this.butEliminar.UseVisualStyleBackColor = true;
            this.butEliminar.Click += new System.EventHandler(this.butEliminar_Click);
            // 
            // butFinalizarCompara
            // 
            this.butFinalizarCompara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFinalizarCompara.Location = new System.Drawing.Point(219, 429);
            this.butFinalizarCompara.Name = "butFinalizarCompara";
            this.butFinalizarCompara.Size = new System.Drawing.Size(185, 44);
            this.butFinalizarCompara.TabIndex = 15;
            this.butFinalizarCompara.Text = "Finalizar Compra";
            this.butFinalizarCompara.UseVisualStyleBackColor = true;
            this.butFinalizarCompara.Click += new System.EventHandler(this.butFinalizarCompara_Click);
            // 
            // butAgregar
            // 
            this.butAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAgregar.Location = new System.Drawing.Point(12, 429);
            this.butAgregar.Name = "butAgregar";
            this.butAgregar.Size = new System.Drawing.Size(104, 44);
            this.butAgregar.TabIndex = 14;
            this.butAgregar.Text = "Agregar";
            this.butAgregar.UseVisualStyleBackColor = true;
            this.butAgregar.Click += new System.EventHandler(this.butAgregar_Click);
            // 
            // pbProducto
            // 
            this.pbProducto.Location = new System.Drawing.Point(81, 155);
            this.pbProducto.Name = "pbProducto";
            this.pbProducto.Size = new System.Drawing.Size(255, 255);
            this.pbProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProducto.TabIndex = 13;
            this.pbProducto.TabStop = false;
            // 
            // tbPrecioUnitario
            // 
            this.tbPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecioUnitario.Location = new System.Drawing.Point(145, 123);
            this.tbPrecioUnitario.Name = "tbPrecioUnitario";
            this.tbPrecioUnitario.Size = new System.Drawing.Size(259, 26);
            this.tbPrecioUnitario.TabIndex = 12;
            // 
            // tbCantidad
            // 
            this.tbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantidad.Location = new System.Drawing.Point(100, 91);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(304, 26);
            this.tbCantidad.TabIndex = 11;
            // 
            // tbProducto
            // 
            this.tbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProducto.Location = new System.Drawing.Point(100, 59);
            this.tbProducto.Name = "tbProducto";
            this.tbProducto.Size = new System.Drawing.Size(304, 26);
            this.tbProducto.TabIndex = 10;
            // 
            // tbClaveProducto
            // 
            this.tbClaveProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClaveProducto.Location = new System.Drawing.Point(145, 27);
            this.tbClaveProducto.Name = "tbClaveProducto";
            this.tbClaveProducto.Size = new System.Drawing.Size(259, 26);
            this.tbClaveProducto.TabIndex = 9;
            this.tbClaveProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbClaveProducto_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(2)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Precio Unitario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(2)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(2)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Clave Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(2)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Producto:";
            // 
            // labTotal
            // 
            this.labTotal.AutoSize = true;
            this.labTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(2)))));
            this.labTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotal.Location = new System.Drawing.Point(205, 538);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(0, 108);
            this.labTotal.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(2)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 538);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 55);
            this.label7.TabIndex = 16;
            this.label7.Text = "TOTAL:";
            // 
            // dgvDetallesVenta
            // 
            this.dgvDetallesVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesVenta.Location = new System.Drawing.Point(2, 3);
            this.dgvDetallesVenta.Name = "dgvDetallesVenta";
            this.dgvDetallesVenta.Size = new System.Drawing.Size(827, 532);
            this.dgvDetallesVenta.TabIndex = 0;
            // 
            // tpVentas
            // 
            this.tpVentas.Controls.Add(this.pagPuntoDeVen);
            this.tpVentas.Controls.Add(this.pagVentas);
            this.tpVentas.Controls.Add(this.pagEmpleados);
            this.tpVentas.Location = new System.Drawing.Point(1, 3);
            this.tpVentas.Name = "tpVentas";
            this.tpVentas.SelectedIndex = 0;
            this.tpVentas.Size = new System.Drawing.Size(1262, 680);
            this.tpVentas.TabIndex = 1;
            this.tpVentas.Tag = "";
            // 
            // moduloPuntoDeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tpVentas);
            this.Name = "moduloPuntoDeVenta";
            this.Text = "MicroCHEAT - Punto De Venta";
            this.pagVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pagPuntoDeVen.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesVenta)).EndInit();
            this.tpVentas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabPage pagEmpleados;
        private System.Windows.Forms.TabPage pagVentas;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage pagPuntoDeVen;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TabControl tpVentas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.RadioButton rbClienteNom;
        private System.Windows.Forms.RadioButton rbClienteId;
        private System.Windows.Forms.ComboBox cbListaClientes;
        private System.Windows.Forms.ComboBox cbListaVendedores;
        private System.Windows.Forms.RadioButton rbEmpleadoNom;
        private System.Windows.Forms.RadioButton rbEmpleadoId;
        private System.Windows.Forms.TextBox tbClaveProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPrecioUnitario;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.TextBox tbProducto;
        private System.Windows.Forms.PictureBox pbProducto;
        private System.Windows.Forms.Button butAgregar;
        private System.Windows.Forms.Button butFinalizarCompara;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvDetallesVenta;
        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.Button butEliminar;
    }
}